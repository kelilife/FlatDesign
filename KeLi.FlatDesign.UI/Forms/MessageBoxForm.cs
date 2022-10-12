using System;
using System.Windows.Forms;

namespace KeLi.FlatDesign.UI.Forms
{
    public partial class MessageBoxForm : BorderlessForm
    {
        private MessageBoxForm()
        {
            InitializeComponent();
        }

        public MessageBoxForm(string message) : this()
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException(nameof(message));

            txtMessage.Text = message;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}