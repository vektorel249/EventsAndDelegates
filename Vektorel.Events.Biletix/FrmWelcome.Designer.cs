namespace Vektorel.Events.Biletix
{
    partial class FrmWelcome
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
            btnOrganizer = new Button();
            btnParticipant = new Button();
            SuspendLayout();
            // 
            // btnOrganizer
            // 
            btnOrganizer.Location = new Point(50, 50);
            btnOrganizer.Name = "btnOrganizer";
            btnOrganizer.Size = new Size(120, 120);
            btnOrganizer.TabIndex = 0;
            btnOrganizer.Text = "Organizatör";
            btnOrganizer.UseVisualStyleBackColor = true;
            btnOrganizer.Click += btnOrganizer_Click;
            // 
            // btnParticipant
            // 
            btnParticipant.Location = new Point(176, 50);
            btnParticipant.Name = "btnParticipant";
            btnParticipant.Size = new Size(120, 120);
            btnParticipant.TabIndex = 1;
            btnParticipant.Text = "Katılımcı";
            btnParticipant.UseVisualStyleBackColor = true;
            btnParticipant.Click += btnParticipant_Click;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 231);
            ControlBox = false;
            Controls.Add(btnParticipant);
            Controls.Add(btnOrganizer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etkinlik Takibi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOrganizer;
        private Button btnParticipant;
    }
}