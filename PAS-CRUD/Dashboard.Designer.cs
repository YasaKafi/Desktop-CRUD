namespace PAS_CRUD
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tanggal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_resep = new System.Windows.Forms.RadioButton();
            this.rb_bebas = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_harga = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ada = new System.Windows.Forms.CheckBox();
            this.cb_kosong = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Gilroy-Bold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(410, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 35);
            this.label1.TabIndex = 55;
            this.label1.Text = "Dashboard Admin";
            // 
            // tb_tanggal
            // 
            this.tb_tanggal.Location = new System.Drawing.Point(221, 502);
            this.tb_tanggal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_tanggal.Name = "tb_tanggal";
            this.tb_tanggal.ReadOnly = true;
            this.tb_tanggal.Size = new System.Drawing.Size(134, 26);
            this.tb_tanggal.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(36, 506);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 18);
            this.label10.TabIndex = 70;
            this.label10.Text = "Tanggal Kadaluwarsa";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // calendar
            // 
            this.calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendar.Location = new System.Drawing.Point(37, 547);
            this.calendar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 69;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShow.BackColor = System.Drawing.Color.Orange;
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Location = new System.Drawing.Point(286, 689);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(91, 27);
            this.buttonShow.TabIndex = 73;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHide.BackColor = System.Drawing.Color.Orange;
            this.buttonHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHide.Location = new System.Drawing.Point(286, 600);
            this.buttonHide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(91, 27);
            this.buttonHide.TabIndex = 72;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(160, 311);
            this.tb_desc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(293, 100);
            this.tb_desc.TabIndex = 68;
            this.tb_desc.TextChanged += new System.EventHandler(this.textboxKeterangan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 67;
            this.label4.Text = "Deskripsi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(160, 162);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(293, 26);
            this.tb_nama.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nama Obat";
            // 
            // rb_resep
            // 
            this.rb_resep.AutoSize = true;
            this.rb_resep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_resep.Location = new System.Drawing.Point(286, 210);
            this.rb_resep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_resep.Name = "rb_resep";
            this.rb_resep.Size = new System.Drawing.Size(104, 24);
            this.rb_resep.TabIndex = 64;
            this.rb_resep.TabStop = true;
            this.rb_resep.Text = "Obat Resep";
            this.rb_resep.UseVisualStyleBackColor = true;
            // 
            // rb_bebas
            // 
            this.rb_bebas.AutoSize = true;
            this.rb_bebas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_bebas.Location = new System.Drawing.Point(160, 210);
            this.rb_bebas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rb_bebas.Name = "rb_bebas";
            this.rb_bebas.Size = new System.Drawing.Size(104, 24);
            this.rb_bebas.TabIndex = 63;
            this.rb_bebas.TabStop = true;
            this.rb_bebas.Text = "Obat Bebas";
            this.rb_bebas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Stock Obat";
            // 
            // cb_harga
            // 
            this.cb_harga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_harga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_harga.FormattingEnabled = true;
            this.cb_harga.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_harga.Location = new System.Drawing.Point(159, 257);
            this.cb_harga.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_harga.Name = "cb_harga";
            this.cb_harga.Size = new System.Drawing.Size(294, 27);
            this.cb_harga.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Harga Obat";
            // 
            // tb_kode
            // 
            this.tb_kode.Location = new System.Drawing.Point(160, 116);
            this.tb_kode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(293, 26);
            this.tb_kode.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Kode Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Stock Obat";
            // 
            // cb_ada
            // 
            this.cb_ada.AutoSize = true;
            this.cb_ada.Location = new System.Drawing.Point(160, 447);
            this.cb_ada.Name = "cb_ada";
            this.cb_ada.Size = new System.Drawing.Size(55, 24);
            this.cb_ada.TabIndex = 75;
            this.cb_ada.Text = "Ada";
            this.cb_ada.UseVisualStyleBackColor = true;
            this.cb_ada.CheckedChanged += new System.EventHandler(this.cb_ada_CheckedChanged);
            // 
            // cb_kosong
            // 
            this.cb_kosong.AutoSize = true;
            this.cb_kosong.Location = new System.Drawing.Point(286, 447);
            this.cb_kosong.Name = "cb_kosong";
            this.cb_kosong.Size = new System.Drawing.Size(78, 24);
            this.cb_kosong.TabIndex = 76;
            this.cb_kosong.Text = "Kosong";
            this.cb_kosong.UseVisualStyleBackColor = true;
            this.cb_kosong.CheckedChanged += new System.EventHandler(this.cb_resep_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(472, 295);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(602, 678);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 38);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(755, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 38);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(602, 589);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 38);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(755, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 38);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(597, 495);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(117, 38);
            this.btn_insert.TabIndex = 78;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(503, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Search";
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(602, 113);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(373, 26);
            this.tbx_search.TabIndex = 83;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(755, 683);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 38);
            this.btn_close.TabIndex = 85;
            this.btn_close.Text = "LogOut";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1056, 795);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_kosong);
            this.Controls.Add(this.cb_ada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tanggal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_resep);
            this.Controls.Add(this.rb_bebas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_harga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_kode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sss";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_tanggal;
        private Label label10;
        private MonthCalendar calendar;
        private Button buttonShow;
        private Button buttonHide;
        private TextBox tb_desc;
        private Label label4;
        private TextBox tb_nama;
        private Label label2;
        private RadioButton rb_resep;
        private RadioButton rb_bebas;
        private Label label3;
        private ComboBox cb_harga;
        private Label label8;
        private TextBox tb_kode;
        private Label label5;
        private Label label6;
        private CheckBox cb_ada;
        private CheckBox cb_kosong;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btn_insert;
        private Label label7;
        private TextBox tbx_search;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btn_close;
    }
}