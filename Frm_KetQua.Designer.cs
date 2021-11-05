namespace QL_TuyenSinh
{
    partial class Frm_KetQua
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.ketQuaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrid_KQ = new System.Windows.Forms.DataGridView();
            this.qUANLYTUYENSINHDataSet = new QL_TuyenSinh.QUANLYTUYENSINHDataSet();
            this.qUANLYTUYENSINHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_KQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTUYENSINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTUYENSINHDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(184, 26);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(218, 25);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "TRA CỨU KẾT QUẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập số báo danh:";
            // 
            // txtsbd
            // 
            this.txtsbd.Location = new System.Drawing.Point(189, 82);
            this.txtsbd.Name = "txtsbd";
            this.txtsbd.Size = new System.Drawing.Size(171, 20);
            this.txtsbd.TabIndex = 4;
            this.txtsbd.TextChanged += new System.EventHandler(this.txtb_id_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(366, 80);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Location = new System.Drawing.Point(240, 207);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 39);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // DataGrid_KQ
            // 
            this.DataGrid_KQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_KQ.Location = new System.Drawing.Point(12, 111);
            this.DataGrid_KQ.Name = "DataGrid_KQ";
            this.DataGrid_KQ.Size = new System.Drawing.Size(540, 90);
            this.DataGrid_KQ.TabIndex = 7;
            // 
            // qUANLYTUYENSINHDataSet
            // 
            this.qUANLYTUYENSINHDataSet.DataSetName = "QUANLYTUYENSINHDataSet";
            this.qUANLYTUYENSINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYTUYENSINHDataSetBindingSource
            // 
            this.qUANLYTUYENSINHDataSetBindingSource.DataSource = this.qUANLYTUYENSINHDataSet;
            this.qUANLYTUYENSINHDataSetBindingSource.Position = 0;
            // 
            // Frm_KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 258);
            this.Controls.Add(this.DataGrid_KQ);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtsbd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_info);
            this.Name = "Frm_KetQua";
            this.Text = "Frm_KetQua";
            this.Load += new System.EventHandler(this.Frm_KetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_KQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTUYENSINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTUYENSINHDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsbd;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.BindingSource ketQuaBindingSource1;
        private System.Windows.Forms.DataGridView DataGrid_KQ;
        private System.Windows.Forms.BindingSource qUANLYTUYENSINHDataSetBindingSource;
        private QUANLYTUYENSINHDataSet qUANLYTUYENSINHDataSet;
    }
}