
namespace KeLi.FlatDesign.UI.Forms
{
    partial class ProgressBarForm
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
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.pnlProgress.Location = new System.Drawing.Point(30, 59);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(100, 5);
            this.pnlProgress.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(139, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 21);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "Loading...";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(338, 51);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(115, 21);
            this.lblProgress.TabIndex = 10;
            this.lblProgress.Text = "10,000/30,000";
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.White;
            this.pnlBorder.Location = new System.Drawing.Point(28, 57);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(304, 9);
            this.pnlBorder.TabIndex = 9;
            // 
            // ProgressBarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(151)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(500, 108);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlBorder);
            this.Name = "ProgressBarForm";
            this.Text = "ProgressBarFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel pnlBorder;
    }
}