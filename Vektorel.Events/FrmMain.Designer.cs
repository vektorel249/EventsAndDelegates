﻿namespace Vektorel.Events
{
    partial class FrmMain
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
            btnCreateFamily = new Button();
            SuspendLayout();
            // 
            // btnCreateFamily
            // 
            btnCreateFamily.Location = new Point(297, 223);
            btnCreateFamily.Name = "btnCreateFamily";
            btnCreateFamily.Size = new Size(92, 23);
            btnCreateFamily.TabIndex = 0;
            btnCreateFamily.Text = "Aile Oluştur";
            btnCreateFamily.UseVisualStyleBackColor = true;
            btnCreateFamily.Click += btnCreateFamily_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 258);
            Controls.Add(btnCreateFamily);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateFamily;
    }
}
