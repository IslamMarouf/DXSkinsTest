using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Skins;
using DXSkinsTest.Properties;

namespace DXSkinsTest
{
    public partial class FrmSettings : DevExpress.XtraEditors.XtraForm
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cbAuto.Checked = Settings.Default.Auto;
            lblReady.Text = Settings.Default.State;
            foreach (SkinContainer skin in SkinManager.Default.Skins)
            {
                cmbxSkins.Properties.Items.Add(skin.SkinName);
            }

            lblSkinName.Text = Settings.Default.CurrentSkinName;

            cmbxSkins.Text = Settings.Default.CurrentSkinName;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Auto = cbAuto.Checked;
            //Settings.Default.CurrentSkinName = cmbxSkins.Text;
            //Settings.Default.Save();
        }

        private void cmbxSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = cmbxSkins.Text;
            Settings.Default.CurrentSkinName = cmbxSkins.Text;
            Settings.Default.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnFrm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
