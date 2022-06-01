namespace Tool_BV
{
    partial class MainMenuForm
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
            this.btnCheckDataFunc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckDataFunc
            // 
            this.btnCheckDataFunc.Location = new System.Drawing.Point(36, 42);
            this.btnCheckDataFunc.Name = "btnCheckDataFunc";
            this.btnCheckDataFunc.Size = new System.Drawing.Size(177, 60);
            this.btnCheckDataFunc.TabIndex = 0;
            this.btnCheckDataFunc.Text = "Kiểm tra dữ liệu";
            this.btnCheckDataFunc.UseVisualStyleBackColor = true;
            this.btnCheckDataFunc.Click += new System.EventHandler(this.btnCheckDataFunc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chức năng A";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Chức năng C";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 60);
            this.button4.TabIndex = 2;
            this.button4.Text = "Chức năng B";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCheckDataFunc);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu chức năng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckDataFunc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}