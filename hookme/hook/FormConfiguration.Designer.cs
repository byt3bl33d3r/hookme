namespace hook
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeviareLicense = new System.Windows.Forms.TextBox();
            this.linkDeviare = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLicensing = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.tbSearchPath = new System.Windows.Forms.TextBox();
            this.btRemoveSearchPath = new System.Windows.Forms.Button();
            this.btAddSearchPath = new System.Windows.Forms.Button();
            this.lbSearchPath = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLicensing.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviare license (Base64)";
            // 
            // tbDeviareLicense
            // 
            this.tbDeviareLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeviareLicense.Location = new System.Drawing.Point(6, 19);
            this.tbDeviareLicense.Multiline = true;
            this.tbDeviareLicense.Name = "tbDeviareLicense";
            this.tbDeviareLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDeviareLicense.Size = new System.Drawing.Size(660, 104);
            this.tbDeviareLicense.TabIndex = 1;
            // 
            // linkDeviare
            // 
            this.linkDeviare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkDeviare.AutoSize = true;
            this.linkDeviare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkDeviare.Location = new System.Drawing.Point(618, 3);
            this.linkDeviare.Name = "linkDeviare";
            this.linkDeviare.Size = new System.Drawing.Size(48, 13);
            this.linkDeviare.TabIndex = 5;
            this.linkDeviare.TabStop = true;
            this.linkDeviare.Text = "Get one!";
            this.linkDeviare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeviare_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLicensing);
            this.tabControl1.Controls.Add(this.tabPlugins);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 236);
            this.tabControl1.TabIndex = 6;
            // 
            // tabLicensing
            // 
            this.tabLicensing.Controls.Add(this.label2);
            this.tabLicensing.Controls.Add(this.label1);
            this.tabLicensing.Controls.Add(this.linkDeviare);
            this.tabLicensing.Controls.Add(this.tbDeviareLicense);
            this.tabLicensing.Location = new System.Drawing.Point(4, 22);
            this.tabLicensing.Name = "tabLicensing";
            this.tabLicensing.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicensing.Size = new System.Drawing.Size(674, 210);
            this.tabLicensing.TabIndex = 0;
            this.tabLicensing.Text = "Licensing";
            this.tabLicensing.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 71);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tabPlugins
            // 
            this.tabPlugins.Controls.Add(this.label5);
            this.tabPlugins.Controls.Add(this.label4);
            this.tabPlugins.Controls.Add(this.tbSearchPath);
            this.tabPlugins.Controls.Add(this.btRemoveSearchPath);
            this.tabPlugins.Controls.Add(this.btAddSearchPath);
            this.tabPlugins.Controls.Add(this.lbSearchPath);
            this.tabPlugins.Controls.Add(this.label3);
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlugins.Size = new System.Drawing.Size(674, 210);
            this.tabPlugins.TabIndex = 1;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // tbSearchPath
            // 
            this.tbSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSearchPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbSearchPath.Location = new System.Drawing.Point(74, 108);
            this.tbSearchPath.Name = "tbSearchPath";
            this.tbSearchPath.Size = new System.Drawing.Size(493, 20);
            this.tbSearchPath.TabIndex = 4;
            this.tbSearchPath.Text = "c:\\";
            // 
            // btRemoveSearchPath
            // 
            this.btRemoveSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemoveSearchPath.Image = global::hook.Properties.Resources.delete;
            this.btRemoveSearchPath.Location = new System.Drawing.Point(627, 107);
            this.btRemoveSearchPath.Name = "btRemoveSearchPath";
            this.btRemoveSearchPath.Size = new System.Drawing.Size(39, 23);
            this.btRemoveSearchPath.TabIndex = 3;
            this.btRemoveSearchPath.UseVisualStyleBackColor = true;
            this.btRemoveSearchPath.Click += new System.EventHandler(this.btRemoveSearchPath_Click);
            // 
            // btAddSearchPath
            // 
            this.btAddSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddSearchPath.Image = global::hook.Properties.Resources.add;
            this.btAddSearchPath.Location = new System.Drawing.Point(582, 107);
            this.btAddSearchPath.Name = "btAddSearchPath";
            this.btAddSearchPath.Size = new System.Drawing.Size(39, 23);
            this.btAddSearchPath.TabIndex = 2;
            this.btAddSearchPath.UseVisualStyleBackColor = true;
            this.btAddSearchPath.Click += new System.EventHandler(this.btAddSearchPath_Click);
            // 
            // lbSearchPath
            // 
            this.lbSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchPath.FormattingEnabled = true;
            this.lbSearchPath.Location = new System.Drawing.Point(6, 19);
            this.lbSearchPath.Name = "lbSearchPath";
            this.lbSearchPath.Size = new System.Drawing.Size(662, 82);
            this.lbSearchPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search paths";
            // 
            // btCancel
            // 
            this.btCancel.Image = global::hook.Properties.Resources.x;
            this.btCancel.Location = new System.Drawing.Point(608, 254);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 27);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Image = global::hook.Properties.Resources.v2;
            this.btSave.Location = new System.Drawing.Point(12, 254);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 27);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 65);
            this.label4.TabIndex = 5;
            this.label4.Text = "Folders where the python plugins will search for imports.\r\n\r\nExample:\r\nc:\\python2" +
                "6\\libs\r\nc:\\python27\\libs\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Local folder";
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 293);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLicensing.ResumeLayout(false);
            this.tabLicensing.PerformLayout();
            this.tabPlugins.ResumeLayout(false);
            this.tabPlugins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeviareLicense;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.LinkLabel linkDeviare;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLicensing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.TextBox tbSearchPath;
        private System.Windows.Forms.Button btRemoveSearchPath;
        private System.Windows.Forms.Button btAddSearchPath;
        private System.Windows.Forms.ListBox lbSearchPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}