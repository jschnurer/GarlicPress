﻿namespace GarlicPress
{
    partial class AboutForm
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
            this.labTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labIssue = new System.Windows.Forms.Label();
            this.labCoffee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTitle.Location = new System.Drawing.Point(0, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(370, 23);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "GarlicPress";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by prostheticHead\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("m5x7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ver. 16072023";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labIssue
            // 
            this.labIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labIssue.ForeColor = System.Drawing.Color.Blue;
            this.labIssue.Location = new System.Drawing.Point(0, 85);
            this.labIssue.Name = "labIssue";
            this.labIssue.Size = new System.Drawing.Size(370, 39);
            this.labIssue.TabIndex = 3;
            this.labIssue.Text = "For Help, Feature Requests or Reporting an Error\r\nSubmit an Issue on GitHub";
            this.labIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labIssue.Click += new System.EventHandler(this.labIssue_Click);
            // 
            // labCoffee
            // 
            this.labCoffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labCoffee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCoffee.ForeColor = System.Drawing.Color.Blue;
            this.labCoffee.Location = new System.Drawing.Point(0, 158);
            this.labCoffee.Name = "labCoffee";
            this.labCoffee.Size = new System.Drawing.Size(370, 40);
            this.labCoffee.TabIndex = 4;
            this.labCoffee.Text = "Want to thank me? Buy Me a Coffee";
            this.labCoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labCoffee.Click += new System.EventHandler(this.labCoffee_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 214);
            this.Controls.Add(this.labCoffee);
            this.Controls.Add(this.labIssue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labTitle;
        private Label label2;
        private Label label1;
        private Label labIssue;
        private Label labCoffee;
    }
}