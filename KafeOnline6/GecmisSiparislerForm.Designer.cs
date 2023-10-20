namespace KafeOnline6
{
    partial class GecmisSiparislerForm
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
            splitContainer1 = new SplitContainer();
            dgvSiparisler = new DataGridView();
            label1 = new Label();
            dgvSiparisDetaylar = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(5, 6, 5, 6);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvSiparisler);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSiparisDetaylar);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(668, 488);
            splitContainer1.SplitterDistance = 240;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 0;
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.AllowUserToAddRows = false;
            dgvSiparisler.AllowUserToDeleteRows = false;
            dgvSiparisler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSiparisler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(14, 36);
            dgvSiparisler.Margin = new Padding(5, 6, 5, 6);
            dgvSiparisler.MultiSelect = false;
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.ReadOnly = true;
            dgvSiparisler.RowHeadersVisible = false;
            dgvSiparisler.RowTemplate.Height = 25;
            dgvSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisler.Size = new Size(639, 198);
            dgvSiparisler.TabIndex = 1;
            dgvSiparisler.SelectionChanged += dgvSiparisler_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Siparişler";
            // 
            // dgvSiparisDetaylar
            // 
            dgvSiparisDetaylar.AllowUserToAddRows = false;
            dgvSiparisDetaylar.AllowUserToDeleteRows = false;
            dgvSiparisDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSiparisDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisDetaylar.Location = new Point(15, 28);
            dgvSiparisDetaylar.Margin = new Padding(4);
            dgvSiparisDetaylar.MultiSelect = false;
            dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            dgvSiparisDetaylar.ReadOnly = true;
            dgvSiparisDetaylar.RowHeadersVisible = false;
            dgvSiparisDetaylar.RowTemplate.Height = 25;
            dgvSiparisDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisDetaylar.Size = new Size(638, 187);
            dgvSiparisDetaylar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 2;
            label2.Text = "Sipariş Detayları";
            // 
            // GecmisSiparislerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 488);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GecmisSiparislerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Geçmiş Siparişler";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvSiparisler;
        private Label label1;
        private DataGridView dgvSiparisDetaylar;
        private Label label2;
    }
}