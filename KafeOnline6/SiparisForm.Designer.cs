namespace KafeOnline6
{
    partial class SiparisForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cboUrun = new ComboBox();
            nudAdet = new NumericUpDown();
            btnDetayEkle = new Button();
            label3 = new Label();
            cboMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblMasaNo = new Label();
            label5 = new Label();
            lblOdemeTutari = new Label();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnasayfayaDon = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(12, 33);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(234, 29);
            cboUrun.TabIndex = 2;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(252, 33);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(72, 29);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(330, 33);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(100, 29);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            btnDetayEkle.Click += btnDetayEkle_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(553, 8);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 5;
            label3.Text = "Masa No";
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(553, 32);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(72, 29);
            cboMasaNo.TabIndex = 6;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(631, 32);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(75, 29);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.AllowUserToDeleteRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location = new Point(13, 68);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(433, 323);
            dgvDetaylar.TabIndex = 8;
            dgvDetaylar.KeyDown += dgvDetaylar_KeyDown;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün Ad";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Birim Fiyat";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblMasaNo.ForeColor = Color.WhiteSmoke;
            lblMasaNo.Location = new Point(468, 68);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(238, 153);
            lblMasaNo.TabIndex = 8;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(506, 251);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 9;
            label5.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Location = new Point(617, 251);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(49, 21);
            lblOdemeTutari.TabIndex = 10;
            lblOdemeTutari.Text = "₺0,00";
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.Location = new Point(468, 301);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(116, 42);
            btnSiparisIptal.TabIndex = 11;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = true;
            btnSiparisIptal.Click += btnSiparisIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.Location = new Point(590, 301);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(116, 42);
            btnOdemeAl.TabIndex = 12;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = true;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.Location = new Point(468, 349);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(238, 42);
            btnAnasayfayaDon.TabIndex = 13;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = true;
            btnAnasayfayaDon.Click += btnAnasayfayaDon_Click;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 403);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(lblOdemeTutari);
            Controls.Add(label5);
            Controls.Add(lblMasaNo);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(label3);
            Controls.Add(btnDetayEkle);
            Controls.Add(nudAdet);
            Controls.Add(cboUrun);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(620, 386);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboUrun;
        private NumericUpDown nudAdet;
        private Button btnDetayEkle;
        private Label label3;
        private ComboBox cboMasaNo;
        private Button btnMasaTasi;
        private DataGridView dgvDetaylar;
        private Label lblMasaNo;
        private Label label5;
        private Label lblOdemeTutari;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnasayfayaDon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}