using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_BV
{
    public partial class ResultTableForm : Form
    {
        private CheckDataForm checkDataForm;
        private DataTable table_1;
        private DataTable table_2;
        private DataTable table1_copy;
        private DataTable table2_copy;

        public ResultTableForm()
        {
            InitializeComponent();
        }

        private void ResultTableForm_Load(object sender, EventArgs e)
        {
            table1_copy = table_1.Copy();
            table2_copy = table_2.Copy();

            table1_copy.TableName = "Ketqua_BenhVien";
            table2_copy.TableName = "Ketqua_BHXH";
        }

        public void SetTable_1(DataTable table)
        {
            table_1 = table;
            dtgvResult_1.DataSource = table_1;
        }

        public void SetTable_2(DataTable table)
        {
            table_2 = table;
            dtgvResult_2.DataSource = table_2;
        }

        public DataSet getDataSetExportToExcel()
        {
            DataSet ds = new DataSet();

            ds.Tables.Add(table1_copy);
            ds.Tables.Add(table2_copy);
            
            return ds;
        }

        public void ExportDataSetToExcel(DataSet ds)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook())
                        {
                            for (int i = 0; i < ds.Tables.Count; i++)
                            {
                                wb.Worksheets.Add(ds.Tables[i], ds.Tables[i].TableName);
                            }
                            wb.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                            wb.Style.Font.Bold = true;
                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportDataSetToExcel(getDataSetExportToExcel());
        }

        private void ResultTableForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
