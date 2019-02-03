namespace DXSkinsTest
{
    partial class FrmSettings
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
            this.lblReady = new System.Windows.Forms.Label();
            this.lblSkinName = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnFrm1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbAuto = new DevExpress.XtraEditors.CheckEdit();
            this.cmbxSkins = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnFrm2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxSkins.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Location = new System.Drawing.Point(10, 116);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(0, 13);
            this.lblReady.TabIndex = 1;
            // 
            // lblSkinName
            // 
            this.lblSkinName.AutoSize = true;
            this.lblSkinName.Location = new System.Drawing.Point(275, 44);
            this.lblSkinName.Name = "lblSkinName";
            this.lblSkinName.Size = new System.Drawing.Size(0, 13);
            this.lblSkinName.TabIndex = 3;
            // 
            // btnFrm1
            // 
            this.btnFrm1.Location = new System.Drawing.Point(12, 64);
            this.btnFrm1.Name = "btnFrm1";
            this.btnFrm1.Size = new System.Drawing.Size(75, 23);
            this.btnFrm1.TabIndex = 4;
            this.btnFrm1.Text = "Show Form #1";
            this.btnFrm1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.Location = new System.Drawing.Point(13, 12);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Properties.Caption = "Auto";
            this.cbAuto.Size = new System.Drawing.Size(75, 19);
            this.cbAuto.TabIndex = 5;
            // 
            // cmbxSkins
            // 
            this.cmbxSkins.Location = new System.Drawing.Point(13, 38);
            this.cmbxSkins.Name = "cmbxSkins";
            this.cmbxSkins.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbxSkins.Size = new System.Drawing.Size(189, 20);
            this.cmbxSkins.TabIndex = 6;
            this.cmbxSkins.SelectedIndexChanged += new System.EventHandler(this.cmbxSkins_SelectedIndexChanged);
            // 
            // btnFrm2
            // 
            this.btnFrm2.Location = new System.Drawing.Point(93, 64);
            this.btnFrm2.Name = "btnFrm2";
            this.btnFrm2.Size = new System.Drawing.Size(75, 23);
            this.btnFrm2.TabIndex = 7;
            this.btnFrm2.Text = "Show Form #2";
            this.btnFrm2.Click += new System.EventHandler(this.btnFrm2_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 136);
            this.Controls.Add(this.btnFrm2);
            this.Controls.Add(this.cmbxSkins);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.btnFrm1);
            this.Controls.Add(this.lblSkinName);
            this.Controls.Add(this.lblReady);
            this.Name = "FrmSettings";
            this.Text = "frmSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxSkins.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Label lblSkinName;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnFrm1;
        private DevExpress.XtraEditors.CheckEdit cbAuto;
        private DevExpress.XtraEditors.ComboBoxEdit cmbxSkins;
        private DevExpress.XtraEditors.SimpleButton btnFrm2;
    }
}