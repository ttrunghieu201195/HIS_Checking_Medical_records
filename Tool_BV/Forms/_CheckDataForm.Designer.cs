namespace Tool_BV
{
    partial class CheckDataForm
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
            this.dataGridViewLeft = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileNameLeft = new System.Windows.Forms.TextBox();
            this.btnBrowser1 = new System.Windows.Forms.Button();
            this.cboSheetLeft = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dataGridViewRight = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSheetRight = new System.Windows.Forms.ComboBox();
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.txtFileNameRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv1
            // 
            this.dataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeft.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLeft.Name = "dtgv1";
            this.dataGridViewLeft.RowHeadersWidth = 51;
            this.dataGridViewLeft.RowTemplate.Height = 24;
            this.dataGridViewLeft.Size = new System.Drawing.Size(670, 488);
            this.dataGridViewLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên File:";
            // 
            // txtFileName1
            // 
            this.txtFileNameLeft.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNameLeft.Location = new System.Drawing.Point(105, 521);
            this.txtFileNameLeft.Name = "txtFileName1";
            this.txtFileNameLeft.ReadOnly = true;
            this.txtFileNameLeft.Size = new System.Drawing.Size(445, 27);
            this.txtFileNameLeft.TabIndex = 2;
            // 
            // btnBrowser1
            // 
            this.btnBrowser1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowser1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBrowser1.Location = new System.Drawing.Point(570, 518);
            this.btnBrowser1.Name = "btnBrowser1";
            this.btnBrowser1.Size = new System.Drawing.Size(112, 33);
            this.btnBrowser1.TabIndex = 3;
            this.btnBrowser1.Text = "Chọn File";
            this.btnBrowser1.UseVisualStyleBackColor = false;
            this.btnBrowser1.Click += new System.EventHandler(this.btnBrowserLeft_Click);
            // 
            // cboSheet1
            // 
            this.cboSheetLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheetLeft.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSheetLeft.FormattingEnabled = true;
            this.cboSheetLeft.Location = new System.Drawing.Point(105, 563);
            this.cboSheetLeft.Name = "cboSheet1";
            this.cboSheetLeft.Size = new System.Drawing.Size(445, 27);
            this.cboSheetLeft.TabIndex = 4;
            this.cboSheetLeft.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCheck.Location = new System.Drawing.Point(641, 600);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 37);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Tag = "";
            this.btnCheck.Text = "Kiểm Tra";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dtgv2
            // 
            this.dataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRight.Location = new System.Drawing.Point(698, 12);
            this.dataGridViewRight.Name = "dtgv2";
            this.dataGridViewRight.RowHeadersWidth = 51;
            this.dataGridViewRight.RowTemplate.Height = 24;
            this.dataGridViewRight.Size = new System.Drawing.Size(670, 488);
            this.dataGridViewRight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(708, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sheet:";
            // 
            // cboSheet2
            // 
            this.cboSheetRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheetRight.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSheetRight.FormattingEnabled = true;
            this.cboSheetRight.Location = new System.Drawing.Point(804, 559);
            this.cboSheetRight.Name = "cboSheet2";
            this.cboSheetRight.Size = new System.Drawing.Size(434, 27);
            this.cboSheetRight.TabIndex = 11;
            this.cboSheetRight.SelectedIndexChanged += new System.EventHandler(this.cboSheet2_SelectedIndexChanged);
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowser2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBrowser2.Location = new System.Drawing.Point(1254, 513);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(112, 35);
            this.btnBrowser2.TabIndex = 10;
            this.btnBrowser2.Text = "Chọn File";
            this.btnBrowser2.UseVisualStyleBackColor = false;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowserRight_Click);
            // 
            // txtFileName2
            // 
            this.txtFileNameRight.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNameRight.Location = new System.Drawing.Point(804, 517);
            this.txtFileNameRight.Name = "txtFileName2";
            this.txtFileNameRight.ReadOnly = true;
            this.txtFileNameRight.Size = new System.Drawing.Size(434, 27);
            this.txtFileNameRight.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(708, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên File:";
            // 
            // CheckDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 659);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSheetRight);
            this.Controls.Add(this.btnBrowser2);
            this.Controls.Add(this.txtFileNameRight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewRight);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSheetLeft);
            this.Controls.Add(this.btnBrowser1);
            this.Controls.Add(this.txtFileNameLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLeft);
            this.Name = "CheckDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tool kiểm tra lệch thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileNameLeft;
        private System.Windows.Forms.Button btnBrowser1;
        private System.Windows.Forms.ComboBox cboSheetLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dataGridViewLeft;
        private System.Windows.Forms.DataGridView dataGridViewRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSheetRight;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.TextBox txtFileNameRight;
        private System.Windows.Forms.Label label4;
    }
}

