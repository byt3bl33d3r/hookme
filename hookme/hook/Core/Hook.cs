using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nektra.Deviare2;
using System.Runtime.InteropServices;

namespace hook.Core
{
    class Hook
    {
        public NktSpyMgr spyMgr = new NktSpyMgr();
        public NktProcess process;

        public System.Collections.Stack stackFunctions = new System.Collections.Stack();

        public delegate void newFunctionHandler();

        public bool InitializeSpyMgr()
        {
            int res = spyMgr.Initialize();

            if (res == 0)
            {
                spyMgr.OnFunctionCalled += new DNktSpyMgrEvents_OnFunctionCalledEventHandler(OnFunctionCalled);
                return true;
            }
            return false;
        }

        private bool HookFunction(NktProcess process, string function, eNktHookFlags flag)
        {
            NktHook hook = spyMgr.CreateHook(function, (int)flag);
            
            if (hook == null)
                return false;
            try
            {
                hook.Hook(true);
                hook.Attach(process,true);// false);



            }
            catch
            {
                return false;
            }
            return true;
        }


        public bool HookProcess(int pid)
        {
            // Hay que hacerlo con un for, porque utilizando el ProcessFromPID(int) da una excepción... cosas de deviare
            // Program.hook.spyMgr.ProcessFromPID(pid);

            for (int i = 0; i < Program.hook.spyMgr.Processes().Count; i++)
            {
                NktProcess p = (NktProcess) Program.hook.spyMgr.Processes().GetAt(i);
                if (p.Id == pid)
                    return HookProcess(p);
            }

            return false;
        }

        public bool HookProcess(NktProcess process)
        {
            /*
             OJO: Es importante que se hookee la funcion como 'send' y no como 'Send', porque si no el hook se hará bien
                  pero la función devolverá 0 parámetros en vez de los 4 que tiene en su estructura
            */
            bool result = false;

            result = HookFunction(process, "Secur32.dll!EncryptMessage", eNktHookFlags.flgOnlyPreCall);
            if (result == false)
                return result;
            result = HookFunction(process, "Secur32.dll!DecryptMessage", eNktHookFlags.flgOnlyPostCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!send", eNktHookFlags.flgOnlyPreCall);
            if (result == false)  
                return result;
            result = HookFunction(process, "WS2_32.dll!recv", eNktHookFlags.flgOnlyPostCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!sendto", eNktHookFlags.flgOnlyPreCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!recvfrom", eNktHookFlags.flgOnlyPostCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!WSASend", eNktHookFlags.flgOnlyPreCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!WSASendTo", eNktHookFlags.flgOnlyPreCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!WSARecv", eNktHookFlags.flgOnlyPostCall);
            if (result == false)
                return result;
            result = HookFunction(process, "WS2_32.dll!WSARecvFrom", eNktHookFlags.flgOnlyPostCall);
            if (result == false)
                return result;
            
            this.process = process;
           return true;
        }

        public void OnFunctionCalled(NktHook hook, NktProcess process, NktHookCallInfo hookCallInfo)
        {
            System.Windows.Forms.MessageBox.Show("A");
            string function = hook.FunctionName.ToLower();
            wrappers.FunctionWrapper functionWr = new wrappers.FunctionWrapper(hook, process, hookCallInfo);

            
            stackFunctions.Push(functionWr);

            while (functionWr.status == wrappers.FunctionWrapper.Status.Waiting)
            {
                System.Threading.Thread.Sleep(0);
            }

            if (functionWr.status == wrappers.FunctionWrapper.Status.Droped)
            {
                hookCallInfo.SkipCall();
                Program.data.AceptingNewFunctions = true;
                return;
            }

            Program.data.AceptingNewFunctions = true;
        }
    }
}
