namespace QL_TuyenSinh
{
    partial class Frm_Truong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.cbo_id = new System.Windows.Forms.ComboBox();
            this.rbtn_name = new System.Windows.Forms.RadioButton();
            this.rbtn_id = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 643);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(594, 634);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_timkiem);
            this.panel2.Controls.Add(this.cbo_name);
            this.panel2.Controls.Add(this.cbo_id);
            this.panel2.Controls.Add(this.rbtn_name);
            this.panel2.Controls.Add(this.rbtn_id);
            this.panel2.Location = new System.Drawing.Point(630, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 526);
            this.panel2.TabIndex = 1;
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.Location = new System.Drawing.Point(4, 3);
            this.lbl_timkiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(155, 37);
            this.lbl_timkiem.TabIndex = 4;
            this.lbl_timkiem.Text = "Tìm kiếm";
            // 
            // cbo_name
            // 
            this.cbo_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Location = new System.Drawing.Point(156, 149);
            this.cbo_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(360, 28);
            this.cbo_name.TabIndex = 7;
            this.cbo_name.SelectedIndexChanged += new System.EventHandler(this.cbo_name_SelectedIndexChanged);
            // 
            // cbo_id
            // 
            this.cbo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_id.FormattingEnabled = true;
            this.cbo_id.Location = new System.Drawing.Point(156, 66);
            this.cbo_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_id.Name = "cbo_id";
            this.cbo_id.Size = new System.Drawing.Size(360, 28);
            this.cbo_id.TabIndex = 6;
            this.cbo_id.SelectedIndexChanged += new System.EventHandler(this.cbo_id_SelectedIndexChanged);
            // 
            // rbtn_name
            // 
            this.rbtn_name.AutoSize = true;
            this.rbtn_name.Location = new System.Drawing.Point(4, 155);
            this.rbtn_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_name.Name = "rbtn_name";
            this.rbtn_name.Size = new System.Drawing.Size(115, 24);
            this.rbtn_name.TabIndex = 5;
            this.rbtn_name.TabStop = true;
            this.rbtn_name.Text = "Tên trường:";
            this.rbtn_name.UseVisualStyleBackColor = true;
            this.rbtn_name.CheckedChanged += new System.EventHandler(this.rbtn_name_CheckedChanged);
            // 
            // rbtn_id
            // 
            this.rbtn_id.AutoSize = true;
            this.rbtn_id.Location = new System.Drawing.Point(4, 66);
            this.rbtn_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_id.Name = "rbtn_id";
            this.rbtn_id.Size = new System.Drawing.Size(110, 24);
            this.rbtn_id.TabIndex = 4;
            this.rbtn_id.TabStop = true;
            this.rbtn_id.Text = "Mã trường:";
            this.rbtn_id.UseVisualStyleBackColor = true;
            this.rbtn_id.CheckedChanged += new System.EventHandler(this.rbtn_id_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Location = new System.Drawing.Point(630, 555);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 106);
            this.panel3.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(306, 5);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(156, 5);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 35);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Frm_Truong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Truong";
            this.Text = "Truong";
            this.Load += new System.EventHandler(this.Trường_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.ComboBox cbo_id;
        private System.Windows.Forms.RadioButton rbtn_name;
        private System.Windows.Forms.RadioButton rbtn_id;
        private System.Windows.Forms.Label lbl_timkiem;
    }
}