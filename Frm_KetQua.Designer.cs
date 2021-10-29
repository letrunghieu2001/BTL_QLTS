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
            this.dataGridView_Ketqua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.bTL_QLtuyensinhDataSet = new QL_TuyenSinh.BTL_QLtuyensinhDataSet();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new QL_TuyenSinh.BTL_QLtuyensinhDataSetTableAdapters.KetQuaTableAdapter();
            this.bTLQLtuyensinhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ketqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTL_QLtuyensinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLQLtuyensinhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(435, 14);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(324, 37);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "TRA CỨU KẾT QUẢ";
            // 
            // dataGridView_Ketqua
            // 
            this.dataGridView_Ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ketqua.Location = new System.Drawing.Point(13, 274);
            this.dataGridView_Ketqua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Ketqua.Name = "dataGridView_Ketqua";
            this.dataGridView_Ketqua.RowHeadersWidth = 62;
            this.dataGridView_Ketqua.Size = new System.Drawing.Size(1164, 95);
            this.dataGridView_Ketqua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập số báo danh:";
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(483, 145);
            this.txtb_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(254, 26);
            this.txtb_id.TabIndex = 4;
            this.txtb_id.TextChanged += new System.EventHandler(this.txtb_id_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(816, 138);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 35);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(958, 138);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bTL_QLtuyensinhDataSet
            // 
            this.bTL_QLtuyensinhDataSet.DataSetName = "BTL_QLtuyensinhDataSet";
            this.bTL_QLtuyensinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.bTL_QLtuyensinhDataSet;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // bTLQLtuyensinhDataSetBindingSource
            // 
            this.bTLQLtuyensinhDataSetBindingSource.DataSource = this.bTL_QLtuyensinhDataSet;
            this.bTLQLtuyensinhDataSetBindingSource.Position = 0;
            // 
            // ketQuaBindingSource1
            // 
            this.ketQuaBindingSource1.DataMember = "KetQua";
            this.ketQuaBindingSource1.DataSource = this.bTLQLtuyensinhDataSetBindingSource;
            // 
            // Frm_KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Ketqua);
            this.Controls.Add(this.lbl_info);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_KetQua";
            this.Text = "Frm_KetQua";
            this.Load += new System.EventHandler(this.Frm_KetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ketqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTL_QLtuyensinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLQLtuyensinhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.DataGridView dataGridView_Ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private BTL_QLtuyensinhDataSet bTL_QLtuyensinhDataSet;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private BTL_QLtuyensinhDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private System.Windows.Forms.BindingSource bTLQLtuyensinhDataSetBindingSource;
        private System.Windows.Forms.BindingSource ketQuaBindingSource1;
    }
}