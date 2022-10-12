using System.Windows.Forms;

namespace KeLi.FlatDesign.UI.Forms
{
    public partial class BorderlessSubForm : Form
    {
        private BorderlessSubForm()
        {
            InitializeComponent();
        }

        protected BorderlessSubForm(Panel parent) : this()
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            Dock = DockStyle.Fill;

            TopLevel = false;
            Parent = parent;

            BringToFront();
        }
    }
}