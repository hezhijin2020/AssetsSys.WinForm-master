using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utils.clsControl
{
    public partial class EditForm : XtraForm
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    SendKeys.Send("{TAB}");
        }
    }
}
