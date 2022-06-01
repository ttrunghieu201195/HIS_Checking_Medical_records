namespace Tool_BV
{
    partial class FunctionsForm
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lblTotal_1 = new System.Windows.Forms.Label();
            this.lblTotal_2 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TotalPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TotalPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(18, 85);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(29, 29);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "--";
            // 
            // lblTotal_1
            // 
            this.lblTotal_1.AutoSize = true;
            this.lblTotal_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_1.Location = new System.Drawing.Point(225, 85);
            this.lblTotal_1.Name = "lblTotal_1";
            this.lblTotal_1.Size = new System.Drawing.Size(29, 29);
            this.lblTotal_1.TabIndex = 4;
            this.lblTotal_1.Text = "--";
            // 
            // lblTotal_2
            // 
            this.lblTotal_2.AutoSize = true;
            this.lblTotal_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_2.Location = new System.Drawing.Point(225, 142);
            this.lblTotal_2.Name = "lblTotal_2";
            this.lblTotal_2.Size = new System.Drawing.Size(29, 29);
            this.lblTotal_2.TabIndex = 5;
            this.lblTotal_2.Text = "--";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TotalPage);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(539, 304);
            this.TabControl.TabIndex = 6;
            // 
            // TotalPage
            // 
            this.TotalPage.Controls.Add(this.lbl_2);
            this.TotalPage.Controls.Add(this.lblTotal_2);
            this.TotalPage.Controls.Add(this.lbl_1);
            this.TotalPage.Controls.Add(this.lblTotal_1);
            this.TotalPage.Location = new System.Drawing.Point(4, 25);
            this.TotalPage.Name = "TotalPage";
            this.TotalPage.Padding = new System.Windows.Forms.Padding(3);
            this.TotalPage.Size = new System.Drawing.Size(531, 275);
            this.TotalPage.TabIndex = 0;
            this.TotalPage.Text = "Tổng chi";
            this.TotalPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(18, 142);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(29, 29);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "--";
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 328);
            this.Controls.Add(this.TabControl);
            this.Name = "FunctionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FunctionsForm";
            this.Load += new System.EventHandler(this.FunctionsForm_Load);
            this.TabControl.ResumeLayout(false);
            this.TotalPage.ResumeLayout(false);
            this.TotalPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lblTotal_1;
        private System.Windows.Forms.Label lblTotal_2;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TotalPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_2;
    }
}