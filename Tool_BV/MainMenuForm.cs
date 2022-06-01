using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
