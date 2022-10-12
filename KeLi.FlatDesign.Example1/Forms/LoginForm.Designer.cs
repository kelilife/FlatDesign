
namespace KeLi.FlatDesign.Example1.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.scShape = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lsPwd = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lsUserName = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkForgetPwd = new System.Windows.Forms.LinkLabel();
            this.labTitlt = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 330);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLeft_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::KeLi.FlatDesign.Example1.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(45, 80);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(154, 150);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // scShape
            // 
            this.scShape.Location = new System.Drawing.Point(0, 0);
            this.scShape.Margin = new System.Windows.Forms.Padding(0);
            this.scShape.Name = "scShape";
            this.scShape.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lsPwd,
            this.lsUserName});
            this.scShape.Size = new System.Drawing.Size(780, 330);
            this.scShape.TabIndex = 1;
            this.scShape.TabStop = false;
            // 
            // lsPwd
            // 
            this.lsPwd.BorderColor = System.Drawing.Color.Silver;
            this.lsPwd.Name = "lsPwd";
            this.lsPwd.X1 = 311;
            this.lsPwd.X2 = 718;
            this.lsPwd.Y1 = 165;
            this.lsPwd.Y2 = 165;
            // 
            // lsUserName
            // 
            this.lsUserName.BorderColor = System.Drawing.Color.Silver;
            this.lsUserName.Name = "lsUserName";
            this.lsUserName.X1 = 310;
            this.lsUserName.X2 = 717;
            this.lsUserName.Y1 = 100;
            this.lsUserName.Y2 = 100;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(311, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(408, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "Please input user name";
            this.txtUserName.Text = "Please input user name";
            this.txtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPwd.ForeColor = System.Drawing.Color.Silver;
            this.txtPwd.Location = new System.Drawing.Point(311, 145);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(408, 20);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.Tag = "Please input password";
            this.txtPwd.Text = "Please input password";
            this.txtPwd.Enter += new System.EventHandler(this.TxtPwd_Enter);
            this.txtPwd.Leave += new System.EventHandler(this.TxtPwd_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(311, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(408, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkForgetPwd
            // 
            this.linkForgetPwd.AutoSize = true;
            this.linkForgetPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.linkForgetPwd.LinkColor = System.Drawing.Color.DarkGray;
            this.linkForgetPwd.Location = new System.Drawing.Point(453, 278);
            this.linkForgetPwd.Name = "linkForgetPwd";
            this.linkForgetPwd.Size = new System.Drawing.Size(124, 17);
            this.linkForgetPwd.TabIndex = 4;
            this.linkForgetPwd.TabStop = true;
            this.linkForgetPwd.Text = "Forgot password?";
            this.linkForgetPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkForgetPwd_LinkClicked);
            // 
            // labTitlt
            // 
            this.labTitlt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitlt.AutoSize = true;
            this.labTitlt.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labTitlt.ForeColor = System.Drawing.Color.White;
            this.labTitlt.Location = new System.Drawing.Point(471, 0);
            this.labTitlt.Name = "labTitlt";
            this.labTitlt.Size = new System.Drawing.Size(101, 32);
            this.labTitlt.TabIndex = 5;
            this.labTitlt.Text = "LOGIN";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::KeLi.FlatDesign.Example1.Properties.Resources.Close;
            this.pbClose.Location = new System.Drawing.Point(761, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(16, 16);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // pbMin
            // 
            this.pbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMin.Image = global::KeLi.FlatDesign.Example1.Properties.Resources.Minimize;
            this.pbMin.Location = new System.Drawing.Point(739, 3);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(16, 16);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMin.TabIndex = 6;
            this.pbMin.TabStop = false;
            this.pbMin.Click += new System.EventHandler(this.PbMin_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbMin);
            this.Controls.Add(this.labTitlt);
            this.Controls.Add(this.linkForgetPwd);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.scShape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginFrm_MouseDown);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer scShape;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsPwd;
        private Microsoft.VisualBasic.PowerPacks.LineShape lsUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkForgetPwd;
        private System.Windows.Forms.Label labTitlt;
        private System.Windows.Forms.PictureBox pbMin;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

