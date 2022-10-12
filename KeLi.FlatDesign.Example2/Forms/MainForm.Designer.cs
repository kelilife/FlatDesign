
namespace KeLi.FlatDesign.Example2.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMembershipMenu = new System.Windows.Forms.Panel();
            this.btnMembershipItem3 = new System.Windows.Forms.Button();
            this.btnMembershipItem2 = new System.Windows.Forms.Button();
            this.btnMembershipItem1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnPlans = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblDefaultTxt = new System.Windows.Forms.Label();
            this.pbContentLogo = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrExpandMenu = new System.Windows.Forms.Timer(this.components);
            this.tmrCollapseMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlMembershipMenu.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContentLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.pnlMenu.Controls.Add(this.pnlMembershipMenu);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.btnUsers);
            this.pnlMenu.Controls.Add(this.btnDevices);
            this.pnlMenu.Controls.Add(this.btnPlans);
            this.pnlMenu.Controls.Add(this.btnMembership);
            this.pnlMenu.Controls.Add(this.btnCustomers);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 460);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlMenu_MouseDown);
            // 
            // pnlMembershipMenu
            // 
            this.pnlMembershipMenu.Controls.Add(this.btnMembershipItem3);
            this.pnlMembershipMenu.Controls.Add(this.btnMembershipItem2);
            this.pnlMembershipMenu.Controls.Add(this.btnMembershipItem1);
            this.pnlMembershipMenu.Location = new System.Drawing.Point(1, 185);
            this.pnlMembershipMenu.Name = "pnlMembershipMenu";
            this.pnlMembershipMenu.Size = new System.Drawing.Size(226, 129);
            this.pnlMembershipMenu.TabIndex = 3;
            // 
            // btnMembershipItem3
            // 
            this.btnMembershipItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembershipItem3.FlatAppearance.BorderSize = 0;
            this.btnMembershipItem3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMembershipItem3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMembershipItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembershipItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembershipItem3.ForeColor = System.Drawing.Color.Silver;
            this.btnMembershipItem3.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Membership;
            this.btnMembershipItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembershipItem3.Location = new System.Drawing.Point(28, 88);
            this.btnMembershipItem3.Name = "btnMembershipItem3";
            this.btnMembershipItem3.Size = new System.Drawing.Size(196, 37);
            this.btnMembershipItem3.TabIndex = 4;
            this.btnMembershipItem3.Text = "Item3";
            this.btnMembershipItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembershipItem3.UseVisualStyleBackColor = true;
            // 
            // btnMembershipItem2
            // 
            this.btnMembershipItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembershipItem2.FlatAppearance.BorderSize = 0;
            this.btnMembershipItem2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMembershipItem2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMembershipItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembershipItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembershipItem2.ForeColor = System.Drawing.Color.Silver;
            this.btnMembershipItem2.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Membership;
            this.btnMembershipItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembershipItem2.Location = new System.Drawing.Point(28, 45);
            this.btnMembershipItem2.Name = "btnMembershipItem2";
            this.btnMembershipItem2.Size = new System.Drawing.Size(196, 37);
            this.btnMembershipItem2.TabIndex = 4;
            this.btnMembershipItem2.Text = "Item2";
            this.btnMembershipItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembershipItem2.UseVisualStyleBackColor = true;
            // 
            // btnMembershipItem1
            // 
            this.btnMembershipItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembershipItem1.FlatAppearance.BorderSize = 0;
            this.btnMembershipItem1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMembershipItem1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMembershipItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembershipItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembershipItem1.ForeColor = System.Drawing.Color.Silver;
            this.btnMembershipItem1.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Membership;
            this.btnMembershipItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembershipItem1.Location = new System.Drawing.Point(26, 3);
            this.btnMembershipItem1.Name = "btnMembershipItem1";
            this.btnMembershipItem1.Size = new System.Drawing.Size(196, 37);
            this.btnMembershipItem1.TabIndex = 4;
            this.btnMembershipItem1.Text = "Item1";
            this.btnMembershipItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembershipItem1.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.Silver;
            this.btnMenu.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Menu2;
            this.btnMenu.Location = new System.Drawing.Point(188, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 30);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Silver;
            this.btnUsers.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.User;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(1, 403);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(226, 37);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevices.FlatAppearance.BorderSize = 0;
            this.btnDevices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevices.ForeColor = System.Drawing.Color.Silver;
            this.btnDevices.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Devices;
            this.btnDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevices.Location = new System.Drawing.Point(1, 361);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Size = new System.Drawing.Size(226, 37);
            this.btnDevices.TabIndex = 0;
            this.btnDevices.Text = "Devices";
            this.btnDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.BtnDevices_Click);
            // 
            // btnPlans
            // 
            this.btnPlans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlans.FlatAppearance.BorderSize = 0;
            this.btnPlans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPlans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlans.ForeColor = System.Drawing.Color.Silver;
            this.btnPlans.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Planes;
            this.btnPlans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlans.Location = new System.Drawing.Point(1, 318);
            this.btnPlans.Name = "btnPlans";
            this.btnPlans.Size = new System.Drawing.Size(226, 37);
            this.btnPlans.TabIndex = 0;
            this.btnPlans.Text = "Plans";
            this.btnPlans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlans.UseVisualStyleBackColor = true;
            this.btnPlans.Click += new System.EventHandler(this.BtnPlans_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMembership.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembership.ForeColor = System.Drawing.Color.Silver;
            this.btnMembership.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Membership;
            this.btnMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembership.Location = new System.Drawing.Point(1, 143);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(226, 37);
            this.btnMembership.TabIndex = 0;
            this.btnMembership.Text = "Membership";
            this.btnMembership.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembership.UseVisualStyleBackColor = true;
            this.btnMembership.Click += new System.EventHandler(this.BtnMembership_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Silver;
            this.btnCustomers.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Customers;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(1, 101);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(226, 37);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Silver;
            this.btnDashboard.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(1, 58);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(226, 37);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.btnMax);
            this.pnlTitle.Controls.Add(this.btnMin);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 40);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(763, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.Silver;
            this.btnMax.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Maximize3;
            this.btnMax.Location = new System.Drawing.Point(725, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(32, 30);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.Silver;
            this.btnMin.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Minimize1;
            this.btnMin.Location = new System.Drawing.Point(687, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 30);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(43, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ISP SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.SatelliteDish1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblTime);
            this.pnlUser.Controls.Add(this.lblDate);
            this.pnlUser.Controls.Add(this.lblAddress);
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Controls.Add(this.pbUser);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser.Location = new System.Drawing.Point(230, 408);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(570, 92);
            this.pnlUser.TabIndex = 2;
            this.pnlUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlUser_MouseDown);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(330, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(170, 48);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "21:49:45";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(336, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 22);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "2021/01/01";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(93, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(93, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // pbUser
            // 
            this.pbUser.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Profile2;
            this.pbUser.Location = new System.Drawing.Point(21, 18);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(65, 60);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblDefaultTxt);
            this.pnlContent.Controls.Add(this.pbContentLogo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(570, 368);
            this.pnlContent.TabIndex = 3;
            this.pnlContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlContent_MouseDown);
            // 
            // lblDefaultTxt
            // 
            this.lblDefaultTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDefaultTxt.AutoSize = true;
            this.lblDefaultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDefaultTxt.Location = new System.Drawing.Point(132, 247);
            this.lblDefaultTxt.Name = "lblDefaultTxt";
            this.lblDefaultTxt.Size = new System.Drawing.Size(325, 39);
            this.lblDefaultTxt.TabIndex = 3;
            this.lblDefaultTxt.Text = "KELI Code Advance";
            // 
            // pbContentLogo
            // 
            this.pbContentLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbContentLogo.Image = global::KeLi.FlatDesign.Example2.Properties.Resources.Default;
            this.pbContentLogo.Location = new System.Drawing.Point(182, 107);
            this.pbContentLogo.Name = "pbContentLogo";
            this.pbContentLogo.Size = new System.Drawing.Size(225, 135);
            this.pbContentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContentLogo.TabIndex = 2;
            this.pbContentLogo.TabStop = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1;
            this.tmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // tmrExpandMenu
            // 
            this.tmrExpandMenu.Interval = 10;
            this.tmrExpandMenu.Tick += new System.EventHandler(this.TmrExpandMenu_Tick);
            // 
            // tmrCollapseMenu
            // 
            this.tmrCollapseMenu.Interval = 10;
            this.tmrCollapseMenu.Tick += new System.EventHandler(this.TmrCollapseMenu_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMembershipMenu.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContentLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnPlans;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDefaultTxt;
        private System.Windows.Forms.PictureBox pbContentLogo;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrExpandMenu;
        private System.Windows.Forms.Timer tmrCollapseMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel pnlMembershipMenu;
        private System.Windows.Forms.Button btnMembershipItem1;
        private System.Windows.Forms.Button btnMembershipItem3;
        private System.Windows.Forms.Button btnMembershipItem2;
    }
}

