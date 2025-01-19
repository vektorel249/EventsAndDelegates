namespace Vektorel.Events.Biletix
{
    partial class FrmOrganizer
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
            groupBox1 = new GroupBox();
            btnSave = new Button();
            nudLimit = new NumericUpDown();
            label4 = new Label();
            dtpEnd = new DateTimePicker();
            label3 = new Label();
            dtpStart = new DateTimePicker();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvEvents = new DataGridView();
            groupBox3 = new GroupBox();
            prbStatus = new ProgressBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLimit).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(nudLimit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpEnd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpStart);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Etkinlik Bilgisi";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(95, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudLimit
            // 
            nudLimit.Location = new Point(6, 169);
            nudLimit.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudLimit.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudLimit.Name = "nudLimit";
            nudLimit.Size = new Size(164, 23);
            nudLimit.TabIndex = 7;
            nudLimit.TextAlign = HorizontalAlignment.Right;
            nudLimit.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 151);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 6;
            label4.Text = "Katılımcı Sayısı";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(6, 125);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(164, 23);
            dtpEnd.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Bitiş Tarihi";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(6, 81);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(164, 23);
            dtpStart.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Tarihi";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 37);
            txtName.MaxLength = 32;
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Etkinlik Adı";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvEvents);
            groupBox2.Location = new Point(194, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 221);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Etkinlik Listesi";
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(6, 22);
            dgvEvents.MultiSelect = false;
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(386, 193);
            dgvEvents.TabIndex = 0;
            dgvEvents.CellClick += dgvEvents_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(prbStatus);
            groupBox3.Location = new Point(194, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(398, 42);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Katılım Durumu";
            // 
            // prbStatus
            // 
            prbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prbStatus.Location = new Point(6, 22);
            prbStatus.Name = "prbStatus";
            prbStatus.Size = new Size(386, 14);
            prbStatus.TabIndex = 0;
            // 
            // FrmOrganizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 291);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(620, 330);
            Name = "FrmOrganizer";
            Text = "Etkinlik Yönetimi";
            Load += FrmOrganizer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLimit).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSave;
        private NumericUpDown nudLimit;
        private Label label4;
        private DateTimePicker dtpEnd;
        private Label label3;
        private DateTimePicker dtpStart;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvEvents;
        private GroupBox groupBox3;
        private ProgressBar prbStatus;
    }
}
