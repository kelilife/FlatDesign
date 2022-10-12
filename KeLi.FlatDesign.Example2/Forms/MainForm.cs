using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using KeLi.FlatDesign.UI.Forms;
using KeLi.Power.UI.Extensions;

namespace KeLi.FlatDesign.Example2.Forms
{
    public partial class MainForm : BorderlessForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }

        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }

        private void PnlContent_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }

        private void PnlUser_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var form = new ProgressBarForm(10000);

            for (var i = 0; i <= 10; i++)
            {
                form.UpdateProgress(1000 * i);
                Thread.Sleep(1000);
            }

            pnlContent.Controls.OfType<Form>().ToList().ForEach(pnlContent.Controls.Remove);

            new DashboardForm(pnlContent).Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.OfType<Form>().ToList().ForEach(pnlContent.Controls.Remove);

            new CustomersForm(pnlContent).Show();
        }

        private void BtnMembership_Click(object sender, EventArgs e)
        {
            if (pnlMembershipMenu.Visible)
            {
                pnlMembershipMenu.Visible = false;
                btnPlans.Location = new Point(btnPlans.Location.X, btnPlans.Location.Y - pnlMembershipMenu.Size.Height);
                btnDevices.Location = new Point(btnDevices.Location.X, btnDevices.Location.Y - pnlMembershipMenu.Size.Height);
                btnUsers.Location = new Point(btnUsers.Location.X, btnUsers.Location.Y - pnlMembershipMenu.Size.Height);
            }

            else
            {
                pnlMembershipMenu.Visible = true;
                btnPlans.Location = new Point(btnPlans.Location.X, btnPlans.Location.Y + pnlMembershipMenu.Size.Height);
                btnDevices.Location = new Point(btnDevices.Location.X, btnDevices.Location.Y + pnlMembershipMenu.Size.Height);
                btnUsers.Location = new Point(btnUsers.Location.X, btnUsers.Location.Y + pnlMembershipMenu.Size.Height);
            }
        }

        private void BtnPlans_Click(object sender, EventArgs e)
        {
            var form = new MessageBoxForm("Do you start a plan?");
            var dlg = form.ShowDialog();

            if (dlg == DialogResult.Cancel)
                return;
            
            pnlContent.Controls.OfType<Form>().ToList().ForEach(pnlContent.Controls.Remove);

            new PlansForm(pnlContent).Show();
        }

        private void BtnDevices_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.OfType<Form>().ToList().ForEach(pnlContent.Controls.Remove);

            new DevicesForm(pnlContent).Show();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.OfType<Form>().ToList().ForEach(pnlContent.Controls.Remove);

            new UsersForm(pnlContent).Show();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void BtnMax_Click(object sender, EventArgs e)
        {
            var maxSize = this.GetWorkingAreaSize();

            if (Size == maxSize)
            {
                Size = MinimumSize;
                Location = this.GetScreenCenter();
            }

            else
            {
                Size = maxSize;
                Location = new Point();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 230)
            {
                tmrCollapseMenu.Start();

                if (pnlMembershipMenu.Visible)
                    btnMembership.PerformClick();
            }

            else if (pnlMenu.Width == 55)
            {
                tmrExpandMenu.Start();

                if (!pnlMembershipMenu.Visible)
                    btnMembership.PerformClick();
            }
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void TmrExpandMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 230)
                tmrExpandMenu.Stop();

            else
                pnlMenu.Width += 5;
        }

        private void TmrCollapseMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 55)
                tmrCollapseMenu.Stop();

            else
                pnlMenu.Width -= 5;
        }
    }
}