﻿namespace FontSize
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSizeCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSizeCheck
            // 
            this.btnSizeCheck.Location = new System.Drawing.Point(652, 17);
            this.btnSizeCheck.Name = "btnSizeCheck";
            this.btnSizeCheck.Size = new System.Drawing.Size(89, 45);
            this.btnSizeCheck.TabIndex = 0;
            this.btnSizeCheck.Text = "SizeCheck";
            this.btnSizeCheck.UseVisualStyleBackColor = true;
            this.btnSizeCheck.Click += new System.EventHandler(this.btnSizeCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSizeCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSizeCheck;
    }
}