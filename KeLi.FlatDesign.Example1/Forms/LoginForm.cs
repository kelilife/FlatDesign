using System;
using System.Drawing;
using System.Windows.Forms;

using KeLi.Power.UI.Extensions;

namespace KeLi.FlatDesign.Example1.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }

        private void PnlLeft_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
                Handle.MoveWindow();
        }

        private void PbMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == txtUserName.Tag.ToString())
            {
                txtUserName.Text = string.Empty;
                txtUserName.ForeColor = Color.White;
            }
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = txtUserName.Tag.ToString();
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == txtPwd.Tag.ToString())
            {
                txtPwd.Text = string.Empty;
                txtPwd.ForeColor = Color.White;
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        private void TxtPwd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                txtPwd.Text = txtPwd.Tag.ToString();
                txtPwd.ForeColor = Color.Silver;
                txtPwd.UseSystemPasswordChar = false;
            }
        }
    }
}