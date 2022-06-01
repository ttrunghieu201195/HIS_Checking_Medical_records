using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_BV
{
    public partial class FunctionsForm : Form
    {
        public FunctionsForm()
        {
            InitializeComponent();
        }

        private void FunctionsForm_Load(object sender, EventArgs e)
        {

        }

        public void SetTotal_1(string name, double total)
        {
            lbl_1.Text = name + ":";
            lblTotal_1.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", total) + " VNĐ";
        }

        public void SetTotal_2(string name, double total)
        {
            lbl_2.Text = name + ":";
            lblTotal_2.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", total) + " VNĐ";
        }
    }
}
