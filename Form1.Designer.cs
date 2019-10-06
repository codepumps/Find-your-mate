namespace Esini_Bul_Uygulamasi
{
    partial class E
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E));
            this.groupOyun = new System.Windows.Forms.GroupBox();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.clcHata = new DevExpress.XtraEditors.CalcEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ChkBenimSecimim = new DevExpress.XtraEditors.CheckButton();
            this.chkCokZor = new DevExpress.XtraEditors.CheckButton();
            this.chkZor = new DevExpress.XtraEditors.CheckButton();
            this.chkOrta = new DevExpress.XtraEditors.CheckButton();
            this.chkKolay = new DevExpress.XtraEditors.CheckButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSure = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDikey = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYatay = new DevExpress.XtraEditors.TextEdit();
            this.BtnReplay = new DevExpress.XtraEditors.SimpleButton();
            this.BtnStart = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clcHata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDikey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYatay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOyun
            // 
            this.groupOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.groupOyun, "groupOyun");
            this.groupOyun.Name = "groupOyun";
            this.groupOyun.TabStop = false;
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.labelControl5);
            this.groupMenu.Controls.Add(this.clcHata);
            this.groupMenu.Controls.Add(this.simpleButton1);
            this.groupMenu.Controls.Add(this.ChkBenimSecimim);
            this.groupMenu.Controls.Add(this.chkCokZor);
            this.groupMenu.Controls.Add(this.chkZor);
            this.groupMenu.Controls.Add(this.chkOrta);
            this.groupMenu.Controls.Add(this.chkKolay);
            this.groupMenu.Controls.Add(this.labelControl4);
            this.groupMenu.Controls.Add(this.labelControl3);
            this.groupMenu.Controls.Add(this.txtSure);
            this.groupMenu.Controls.Add(this.labelControl2);
            this.groupMenu.Controls.Add(this.txtDikey);
            this.groupMenu.Controls.Add(this.labelControl1);
            this.groupMenu.Controls.Add(this.txtYatay);
            this.groupMenu.Controls.Add(this.BtnReplay);
            this.groupMenu.Controls.Add(this.BtnStart);
            resources.ApplyResources(this.groupMenu, "groupMenu");
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl5.Appearance.Font")));
            this.labelControl5.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // clcHata
            // 
            resources.ApplyResources(this.clcHata, "clcHata");
            this.clcHata.Name = "clcHata";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ChkBenimSecimim
            // 
            this.ChkBenimSecimim.AllowAllUnchecked = true;
            this.ChkBenimSecimim.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ChkBenimSecimim.Appearance.Font")));
            this.ChkBenimSecimim.Appearance.Options.UseFont = true;
            this.ChkBenimSecimim.GroupIndex = 1;
            resources.ApplyResources(this.ChkBenimSecimim, "ChkBenimSecimim");
            this.ChkBenimSecimim.Name = "ChkBenimSecimim";
            this.ChkBenimSecimim.TabStop = false;
            this.ChkBenimSecimim.CheckedChanged += new System.EventHandler(this.ChkBenimSecimim_CheckedChanged);
            // 
            // chkCokZor
            // 
            this.chkCokZor.AllowAllUnchecked = true;
            this.chkCokZor.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("chkCokZor.Appearance.Font")));
            this.chkCokZor.Appearance.Options.UseFont = true;
            this.chkCokZor.GroupIndex = 1;
            resources.ApplyResources(this.chkCokZor, "chkCokZor");
            this.chkCokZor.Name = "chkCokZor";
            this.chkCokZor.TabStop = false;
            this.chkCokZor.CheckedChanged += new System.EventHandler(this.chkCokZor_CheckedChanged);
            // 
            // chkZor
            // 
            this.chkZor.AllowAllUnchecked = true;
            this.chkZor.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("chkZor.Appearance.Font")));
            this.chkZor.Appearance.Options.UseFont = true;
            this.chkZor.GroupIndex = 1;
            resources.ApplyResources(this.chkZor, "chkZor");
            this.chkZor.Name = "chkZor";
            this.chkZor.TabStop = false;
            this.chkZor.CheckedChanged += new System.EventHandler(this.chkZor_CheckedChanged);
            // 
            // chkOrta
            // 
            this.chkOrta.AllowAllUnchecked = true;
            this.chkOrta.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("chkOrta.Appearance.Font")));
            this.chkOrta.Appearance.Options.UseFont = true;
            this.chkOrta.GroupIndex = 1;
            resources.ApplyResources(this.chkOrta, "chkOrta");
            this.chkOrta.Name = "chkOrta";
            this.chkOrta.TabStop = false;
            this.chkOrta.CheckedChanged += new System.EventHandler(this.chkOrta_CheckedChanged);
            // 
            // chkKolay
            // 
            this.chkKolay.AllowAllUnchecked = true;
            this.chkKolay.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("chkKolay.Appearance.BackColor")));
            this.chkKolay.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("chkKolay.Appearance.BackColor2")));
            this.chkKolay.Appearance.BorderColor = ((System.Drawing.Color)(resources.GetObject("chkKolay.Appearance.BorderColor")));
            this.chkKolay.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("chkKolay.Appearance.Font")));
            this.chkKolay.Appearance.Options.UseBackColor = true;
            this.chkKolay.Appearance.Options.UseBorderColor = true;
            this.chkKolay.Appearance.Options.UseFont = true;
            this.chkKolay.AppearanceDisabled.BackColor = ((System.Drawing.Color)(resources.GetObject("chkKolay.AppearanceDisabled.BackColor")));
            this.chkKolay.AppearanceDisabled.Options.UseBackColor = true;
            this.chkKolay.GroupIndex = 1;
            resources.ApplyResources(this.chkKolay, "chkKolay");
            this.chkKolay.Name = "chkKolay";
            this.chkKolay.CheckedChanged += new System.EventHandler(this.chkKolay_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // txtSure
            // 
            resources.ApplyResources(this.txtSure, "txtSure");
            this.txtSure.Name = "txtSure";
            this.txtSure.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtSure.Properties.Appearance.Font")));
            this.txtSure.Properties.Appearance.Options.UseFont = true;
            this.txtSure.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSure.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtSure.Properties.Buttons"))))});
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // txtDikey
            // 
            resources.ApplyResources(this.txtDikey, "txtDikey");
            this.txtDikey.Name = "txtDikey";
            this.txtDikey.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtDikey.Properties.Appearance.Font")));
            this.txtDikey.Properties.Appearance.Options.UseFont = true;
            this.txtDikey.Properties.Mask.EditMask = resources.GetString("txtDikey.Properties.Mask.EditMask");
            this.txtDikey.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtDikey.Properties.Mask.MaskType")));
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtYatay
            // 
            resources.ApplyResources(this.txtYatay, "txtYatay");
            this.txtYatay.Name = "txtYatay";
            this.txtYatay.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtYatay.Properties.Appearance.Font")));
            this.txtYatay.Properties.Appearance.Options.UseFont = true;
            this.txtYatay.Properties.Mask.EditMask = resources.GetString("txtYatay.Properties.Mask.EditMask");
            this.txtYatay.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtYatay.Properties.Mask.MaskType")));
            // 
            // BtnReplay
            // 
            this.BtnReplay.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnReplay.Appearance.Font")));
            this.BtnReplay.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.BtnReplay, "BtnReplay");
            this.BtnReplay.Name = "BtnReplay";
            this.BtnReplay.Click += new System.EventHandler(this.BtnReplay_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("BtnStart.Appearance.Font")));
            this.BtnStart.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.BtnStart, "BtnStart");
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // E
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("E.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupOyun);
            this.Controls.Add(this.groupMenu);
            this.Name = "E";
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clcHata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDikey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYatay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOyun;
        private System.Windows.Forms.GroupBox groupMenu;
        private DevExpress.XtraEditors.TextEdit txtYatay;
        private DevExpress.XtraEditors.SimpleButton BtnReplay;
        private DevExpress.XtraEditors.SimpleButton BtnStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDikey;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit txtSure;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.CheckButton ChkBenimSecimim;
        private DevExpress.XtraEditors.CheckButton chkCokZor;
        private DevExpress.XtraEditors.CheckButton chkZor;
        private DevExpress.XtraEditors.CheckButton chkOrta;
        private DevExpress.XtraEditors.CheckButton chkKolay;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CalcEdit clcHata;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

