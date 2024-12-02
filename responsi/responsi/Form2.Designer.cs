namespace responsi
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            lblNamKar = new Label();
            lblDepKar = new Label();
            tbNamaKaryawan = new TextBox();
            tbDepKar = new ComboBox();
            lvKet = new ListView();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(117, 41);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(31, 15);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "logo";
            lblLogo.Click += label1_Click;
            // 
            // lblNamKar
            // 
            lblNamKar.AutoSize = true;
            lblNamKar.Location = new Point(38, 115);
            lblNamKar.Name = "lblNamKar";
            lblNamKar.Size = new Size(99, 15);
            lblNamKar.TabIndex = 2;
            lblNamKar.Text = "Nama Karyawan :";
            // 
            // lblDepKar
            // 
            lblDepKar.AutoSize = true;
            lblDepKar.Location = new Point(38, 144);
            lblDepKar.Name = "lblDepKar";
            lblDepKar.Size = new Size(91, 15);
            lblDepKar.TabIndex = 3;
            lblDepKar.Text = "Dep. Karyawan :";
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(156, 112);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(159, 23);
            tbNamaKaryawan.TabIndex = 4;
            // 
            // tbDepKar
            // 
            tbDepKar.FormattingEnabled = true;
            tbDepKar.Location = new Point(156, 144);
            tbDepKar.Name = "tbDepKar";
            tbDepKar.Size = new Size(159, 23);
            tbDepKar.TabIndex = 5;
            // 
            // lvKet
            // 
            lvKet.Location = new Point(347, 12);
            lvKet.Name = "lvKet";
            lvKet.Size = new Size(357, 155);
            lvKet.TabIndex = 7;
            lvKet.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(38, 183);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(168, 23);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(279, 183);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(168, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(536, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(536, 425);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(168, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(38, 228);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(666, 191);
            dgvData.TabIndex = 12;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 460);
            Controls.Add(dgvData);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(lvKet);
            Controls.Add(tbDepKar);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(lblDepKar);
            Controls.Add(lblNamKar);
            Controls.Add(lblLogo);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogo;
        private Label lblNamKar;
        private Label lblDepKar;
        private TextBox tbNamaKaryawan;
        private ComboBox tbDepKar;
        private ListView lvKet;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
        private DataGridView dgvData;
    }
}