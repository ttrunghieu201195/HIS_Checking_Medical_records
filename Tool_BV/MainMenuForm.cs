using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_BV
{
    public partial class MainMenuForm : Form
    {
        private CheckDataForm checkDataForm = new CheckDataForm();

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnCheckDataFunc_Click(object sender, EventArgs e)
        {
            checkDataForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ChromeDriver chromeDriver = new ChromeDriver();

            chromeDriver.Url = "https://demonl.000webhostapp.com/NienLuanN5/kngu/product.php?page=1";
            //chromeDriver.Navigate();

            // thực thi JavaScript dùng IJavaScriptExecutor
            IJavaScriptExecutor js = chromeDriver as IJavaScriptExecutor;
            // javascript cần return giá trị.
            var dataFromJS = (string)js.ExecuteScript("var content = document.getElementsByClassName('price-box')[0].children[0].innerHTML;return content;");
            var dataFromJS1 = (string)js.ExecuteScript("var content = document.getElementsByClassName('price-box')[1].children[0].innerHTML;return content;");
            if (dataFromJS == dataFromJS1) MessageBox.Show("Bằng");
            else MessageBox.Show("Khác");*/
        }

        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }
    }
}
