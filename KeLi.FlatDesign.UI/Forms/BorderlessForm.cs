using System.Windows.Forms;

using KeLi.Power.UI.Extensions;

namespace KeLi.FlatDesign.UI.Forms
{
    public partial class BorderlessForm : Form
    {
        protected BorderlessForm()
        {
            InitializeComponent();
        }

        private void BaseFrm_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }
    }
}