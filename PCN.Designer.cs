﻿
namespace QL_TuyenSinh
{
    partial class PCN
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
            this.CRV1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV1
            // 
            this.CRV1.ActiveViewIndex = -1;
            this.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV1.Location = new System.Drawing.Point(0, 0);
            this.CRV1.Name = "CRV1";
            this.CRV1.Size = new System.Drawing.Size(800, 450);
            this.CRV1.TabIndex = 0;
            this.CRV1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // PCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRV1);
            this.Name = "PCN";
            this.Text = "PCN";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV1;
    }
}