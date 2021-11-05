
namespace QL_TuyenSinh
{
    partial class Frm_PhieuBaoDiem
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
            this.components = new System.ComponentModel.Container();
            this.lbl_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsbd = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.DataGrid_KQ = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiemchuan = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkhoi = new System.Windows.Forms.TextBox();
            this.qUANLYTUYENSINHDataSet = new QL_TuyenSinh.QUANLYTUYENSINHDataSet();
            this.diemChuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemChuanTableAdapter = new QL_TuyenSinh.QUANLYTUYENSINHDataSetTableAdapters.DiemChuanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_KQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTUYENSINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemChuanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(189, 19);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(322, 37);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "TRA CỨU ĐIỂM THI";
            this.lbl_info.Click += new System.EventHandler(this.lbl_info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập số báo danh:";
            // 
            // txtsbd
            // 
            this.txtsbd.Location = new System.Drawing.Point(220, 77);
            this.txtsbd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsbd.Name = "txtsbd";
            this.txtsbd.Size = new System.Drawing.Size(254, 26);
            this.txtsbd.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(548, 73);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 35);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tra Cứu";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // DataGrid_KQ
            // 
            this.DataGrid_KQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_KQ.Location = new System.Drawing.Point(41, 126);
            this.DataGrid_KQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGrid_KQ.Name = "DataGrid_KQ";
            this.DataGrid_KQ.RowHeadersWidth = 62;
            this.DataGrid_KQ.Size = new System.Drawing.Size(666, 100);
            this.DataGrid_KQ.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "KẾT QUẢ:";
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(584, 253);
            this.txtketqua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(123, 26);
            this.txtketqua.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ĐIỂM CHUẨN:";
            // 
            // txtdiemchuan
            // 
            this.txtdiemchuan.Location = new System.Drawing.Point(345, 256);
            this.txtdiemchuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiemchuan.Name = "txtdiemchuan";
            this.txtdiemchuan.Size = new System.Drawing.Size(109, 26);
            this.txtdiemchuan.TabIndex = 12;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Location = new System.Drawing.Point(321, 307);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 60);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Khối:";
            // 
            // txtkhoi
            // 
            this.txtkhoi.Location = new System.Drawing.Point(65, 256);
            this.txtkhoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkhoi.Name = "txtkhoi";
            this.txtkhoi.Size = new System.Drawing.Size(109, 26);
            this.txtkhoi.TabIndex = 15;
            // 
            // qUANLYTUYENSINHDataSet
            // 
            this.qUANLYTUYENSINHDataSet.DataSetName = "QUANLYTUYENSINHDataSet";
            this.qUANLYTUYENSINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemChuanBindingSource
            // 
            this.diemChuanBindingSource.DataMember = "DiemChuan";
            this.diemChuanBindingSource.DataSource = this.qUANLYTUYENSINHDataSet;
            // 
            // diemChuanTableAdapter
            // 
            this.diemChuanTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_PhieuBaoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.txtkhoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txtdiemchuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGrid_KQ);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtsbd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_info);
            this.Name = "Frm_PhieuBaoDiem";
            this.Text = "Frm_PhieuBaoDiem";
            this.Load += new System.EventHandler(this.Frm_PhieuBaoDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_KQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTUYENSINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemChuanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsbd;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView DataGrid_KQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiemchuan;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkhoi;
        private QUANLYTUYENSINHDataSet qUANLYTUYENSINHDataSet;
        private System.Windows.Forms.BindingSource diemChuanBindingSource;
        private QUANLYTUYENSINHDataSetTableAdapters.DiemChuanTableAdapter diemChuanTableAdapter;
    }
}