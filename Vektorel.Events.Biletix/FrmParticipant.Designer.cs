namespace Vektorel.Events.Biletix
{
    partial class FrmParticipant
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
            lstOrganizations = new ListBox();
            btnAttend = new Button();
            btnLeave = new Button();
            groupBox1 = new GroupBox();
            rtbNotifications = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstOrganizations
            // 
            lstOrganizations.FormattingEnabled = true;
            lstOrganizations.ItemHeight = 15;
            lstOrganizations.Location = new Point(12, 12);
            lstOrganizations.Name = "lstOrganizations";
            lstOrganizations.Size = new Size(174, 214);
            lstOrganizations.TabIndex = 0;
            // 
            // btnAttend
            // 
            btnAttend.Location = new Point(192, 12);
            btnAttend.Name = "btnAttend";
            btnAttend.Size = new Size(75, 23);
            btnAttend.TabIndex = 1;
            btnAttend.Text = "Katıl";
            btnAttend.UseVisualStyleBackColor = true;
            btnAttend.Click += btnAttend_Click;
            // 
            // btnLeave
            // 
            btnLeave.Location = new Point(273, 12);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(75, 23);
            btnLeave.TabIndex = 2;
            btnLeave.Text = "Ayrıl";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbNotifications);
            groupBox1.Location = new Point(192, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 185);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bildirimler";
            // 
            // rtbNotifications
            // 
            rtbNotifications.BackColor = SystemColors.ControlLight;
            rtbNotifications.Location = new Point(6, 22);
            rtbNotifications.Name = "rtbNotifications";
            rtbNotifications.ReadOnly = true;
            rtbNotifications.Size = new Size(330, 157);
            rtbNotifications.TabIndex = 0;
            rtbNotifications.Text = "";
            // 
            // FrmParticipant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 238);
            Controls.Add(groupBox1);
            Controls.Add(btnLeave);
            Controls.Add(btnAttend);
            Controls.Add(lstOrganizations);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmParticipant";
            Text = "Etkinlik Katılımı";
            Load += FrmParticipant_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOrganizations;
        private Button btnAttend;
        private Button btnLeave;
        private GroupBox groupBox1;
        private RichTextBox rtbNotifications;
    }
}