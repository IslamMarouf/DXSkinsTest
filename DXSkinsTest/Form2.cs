using DXSkinsTest.Properties;

namespace DXSkinsTest
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}