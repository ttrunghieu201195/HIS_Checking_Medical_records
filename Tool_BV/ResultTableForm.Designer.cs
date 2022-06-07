namespace Tool_BV
{
    partial class ResultTableForm
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
            this.dtgvResult_2 = new System.Windows.Forms.DataGridView();
            this.dtgvResult_1 = new System.Windows.Forms.DataGridView();
            this.lblTable1 = new System.Windows.Forms.Label();
            this.lblTable2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResult_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResult_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvResult_2
            // 
            this.dtgvResult_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvResult_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResult_2.Location = new System.Drawing.Point(593, 61);
            this.dtgvResult_2.Name = "dtgvResult_2";
            this.dtgvResult_2.RowHeadersWidth = 51;
            this.dtgvResult_2.RowTemplate.Height = 24;
            this.dtgvResult_2.Size = new System.Drawing.Size(571, 469);
            this.dtgvResult_2.TabIndex = 9;
            // 
            // dtgvResult_1
            // 
            this.dtgvResult_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvResult_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResult_1.Location = new System.Drawing.Point(12, 61);
            this.dtgvResult_1.Name = "dtgvResult_1";
            this.dtgvResult_1.RowHeadersWidth = 51;
            this.dtgvResult_1.RowTemplate.Height = 24;
            this.dtgvResult_1.Size = new System.Drawing.Size(571, 469);
            this.dtgvResult_1.TabIndex = 8;
            // 
            // lblTable1
            // 
            this.lblTable1.AutoSize = true;
            this.lblTable1.BackColor = System.Drawing.Color.Transparent;
            this.lblTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTable1.Location = new System.Drawing.Point(7, 29);
            this.lblTable1.Name = "lblTable1";
            this.lblTable1.Size = new System.Drawing.Size(129, 29);
            this.lblTable1.TabIndex = 10;
            this.lblTable1.Text = "Bệnh Viện:";
            // 
            // lblTable2
            // 
            this.lblTable2.AutoSize = true;
            this.lblTable2.BackColor = System.Drawing.Color.Transparent;
            this.lblTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTable2.Location = new System.Drawing.Point(588, 29);
            this.lblTable2.Name = "lblTable2";
            this.lblTable2.Size = new System.Drawing.Size(204, 29);
            this.lblTable2.TabIndex = 11;
            this.lblTable2.Text = "Bảo Hiểm Xã Hội:";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExport.Location = new System.Drawing.Point(502, 544);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 40);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Xuất File Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ResultTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1178, 596);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblTable2);
            this.Controls.Add(this.lblTable1);
            this.Controls.Add(this.dtgvResult_2);
            this.Controls.Add(this.dtgvResult_1);
            this.Name = "ResultTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết quả kiểm tra";
            this.Load += new System.EventHandler(this.ResultTableForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultTableForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResult_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResult_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvResult_2;
        private System.Windows.Forms.DataGridView dtgvResult_1;
        private System.Windows.Forms.Label lblTable1;
        private System.Windows.Forms.Label lblTable2;
        private System.Windows.Forms.Button btnExport;
    }
}