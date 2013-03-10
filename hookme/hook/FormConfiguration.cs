using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hook
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            LoadConf();
        }

        private void LoadConf()
        {
            tbDeviareLicense.Text = Program.data.configuration.deviareLicenseBase64;

            foreach (string path in Program.data.configuration.lstPluginsSearchPath)
            {
                lbSearchPath.Items.Add(path);
            }
        }

        private void SaveConf()
        {
            Program.data.configuration.deviareLicenseBase64 = tbDeviareLicense.Text;

            Program.data.configuration.lstPluginsSearchPath.Clear();
            foreach (string path in lbSearchPath.Items)
            {
                Program.data.configuration.lstPluginsSearchPath.Add(path);
            }

            Program.data.configuration.SaveConfiguration();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveConf();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelectLicense_Click(object sender, EventArgs e)
        {

        }

        private void linkDeviare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nektra.com/products/deviare-api-hook-windows/purchase/");
        }

        private void btAddSearchPath_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(tbSearchPath.Text))
            {
                MessageBox.Show("Folder not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                lbSearchPath.Items.Add(tbSearchPath.Text);
        }

        private void btRemoveSearchPath_Click(object sender, EventArgs e)
        {
            if (lbSearchPath.SelectedIndex > -1)
            {
                lbSearchPath.Items.RemoveAt(lbSearchPath.SelectedIndex);
            }
        }
    }
}
