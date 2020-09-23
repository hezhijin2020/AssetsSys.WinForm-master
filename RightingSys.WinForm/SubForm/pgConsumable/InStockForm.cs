

using RightingSys.WinForm.Utils.clsControl;
using RightingSys.WinForm.Utils.clsEnum;

namespace RightingSys.WinForm.SubForm.pgConsumable
{
    public partial class InStockForm : BaseForm
    {
        public InStockForm()
        {
            InitializeComponent();
        }

        public override void InitFeatureButton()
        {
            base.SetFeatureButton(FeatureButton.Add, FeatureButton.Modify, FeatureButton.Query, FeatureButton.Preview, FeatureButton.Print, FeatureButton.Export, FeatureButton.Import); ;
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

        }

        private void gridControl1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
