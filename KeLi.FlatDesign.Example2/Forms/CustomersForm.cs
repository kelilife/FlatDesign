using System;
using System.Windows.Forms;

using KeLi.FlatDesign.Example2.Utils;
using KeLi.FlatDesign.UI.Forms;

namespace KeLi.FlatDesign.Example2.Forms
{
    public partial class CustomersForm : BorderlessSubForm
    {
        public CustomersForm(Panel parent) : base(parent)
        {
            InitializeComponent();
        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = CustomerUtil.GetCustomerModels();
        }
    }
}