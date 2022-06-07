using ExcelDataReader;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tool_BV
{
    public partial class CheckDataForm : Form
    {
        private ResultTableForm resultTableForm = new ResultTableForm();
        private FunctionsForm functionsForm = new FunctionsForm();

        public CheckDataForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = tableCollection1[cboSheet1.SelectedItem.ToString()];
            dtgv1.DataSource = dt1;
        }

        private void cboSheet2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = tableCollection2[cboSheet2.SelectedItem.ToString()];
            dtgv2.DataSource = dt2;
        }

        DataTableCollection tableCollection1;
        DataTableCollection tableCollection2;

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName1.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection1 = result.Tables;
                            cboSheet1.Items.Clear();
                            foreach (DataTable table in tableCollection1)
                                cboSheet1.Items.Add(table.TableName);
                        }
                        cboSheet1.SelectedIndex = cboSheet1.Items.Count - 1;
                    }
                }
            }
        }

        private void btnBrowser2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName2.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection2 = result.Tables;
                            cboSheet2.Items.Clear();
                            foreach (DataTable table in tableCollection2)
                                cboSheet2.Items.Add(table.TableName);
                        }
                        cboSheet2.SelectedIndex = cboSheet2.Items.Count - 1;
                    }
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (dtgv1.DataSource == null || dtgv2.DataSource == null)
            {
                MessageBox.Show("Chưa đủ dữ liệu kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string keyname1, keyname2;

                DataTable dt1 = tableCollection1[cboSheet1.SelectedItem.ToString()];
                if (dt1.Columns.Contains("SOPHIEU"))
                {
                    dt1.PrimaryKey = new DataColumn[] { dt1.Columns["SOPHIEU"] };
                    keyname1 = "SOPHIEU";
                }
                else if(dt1.Columns.Contains("Mã liên kết"))
                {
                    dt1.PrimaryKey = new DataColumn[] { dt1.Columns["Mã liên kết"] };
                    keyname1 = "Mã liên kết";
                }
                else
                {
                    keyname1 = "";
                }
                DataRow[] rows_1 = dt1.Select();

                
                DataTable dt2 = tableCollection2[cboSheet2.SelectedItem.ToString()];    
                if(dt2.Columns.Contains("Mã liên kết"))
                {
                    dt2.PrimaryKey = new DataColumn[] { dt2.Columns["Mã liên kết"] };
                    keyname2 = "Mã liên kết";
                }
                else if(dt2.Columns.Contains("SOPHIEU"))
                {
                    dt2.PrimaryKey = new DataColumn[] { dt2.Columns["SOPHIEU"] };
                    keyname2 = "SOPHIEU";
                }
                else
                {
                    keyname2 = "";
                }
                DataRow[] rows_2 = dt2.Select();

                DataTable key_dt2 = new DataTable();
                DataColumn MLK = new DataColumn("Mã liên kết");
                DataColumn Total = new DataColumn("Tổng chi");
                DataColumn STT = new DataColumn("STT");
                key_dt2.Columns.Add(STT);
                key_dt2.Columns.Add(MLK);
                key_dt2.Columns.Add(Total);
                key_dt2.PrimaryKey = new DataColumn[] { MLK };

                DataTable dt1_copy = new DataTable();
                
                if(keyname1 == "Mã liên kết")
                {
                    dt1_copy = dt2.Copy();
                    for (int j = 0; j < rows_1.Length; j++)
                    {
                        string mlk = (string)rows_1[j]["Mã liên kết"];
                        string[] arrList_mlk = mlk.Split('_');
                        key_dt2.Rows.Add(rows_1[j]["STT"], arrList_mlk[0], rows_1[j]["Tổng chi"]);
                    }
                }else if(keyname2 == "Mã liên kết")
                {
                    dt1_copy = dt1.Copy();
                    for (int j = 0; j < rows_2.Length; j++)
                    {
                        string mlk = (string)rows_2[j]["Mã liên kết"];
                        string[] arrList_mlk = mlk.Split('_');
                        key_dt2.Rows.Add(rows_2[j]["STT"], arrList_mlk[0], rows_2[j]["Tổng chi"]);
                    }
                }else if(keyname1 == keyname2)
                {
                    MessageBox.Show("File so sánh không thể giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else
                {
                    MessageBox.Show("Dữ liệu trong file tải lên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow[] rows_dt1_copy = dt1_copy.Select();
                DataRow[] rows_key_dt2 = key_dt2.Select();

                //Console.WriteLine("----------RESULT TABLE 1----------");
                var result_t1 = from t1 in rows_dt1_copy
                             join t2 in rows_key_dt2 on t1["SOPHIEU"] equals t2["Mã liên kết"] into temp
                             from t3 in temp.DefaultIfEmpty()
                             select new
                             {
                                 STT = t1["STT"],
                                 MLK = (t3 != null)? t3["Mã liên kết"] : null,
                                 SOPHIEU = (t3 == null)? t1["SOPHIEU"] : null,
                                 total_t1 = t1["T_TONGCHI"],
                                 total_t2 = (t3 == null)? null : t3["Tổng chi"],
                                 MA_BN = t1["MA_BN"],
                                 HO_TEN = t1["HO_TEN"]
                                 /*NGAY_SINH = t1["NGAY_SINH"],
                                 GIOI_TINH = t1["GIOI_TINH"],
                                 DIA_CHI = t1["DIA_CHI"],
                                 MA_THE = t1["MA_THE"],
                                 MA_DKBD = t1["MA_DKBD"],
                                 GT_THE_TU = t1["GT_THE_TU"],
                                 GT_THE_DEN = t1["GT_THE_DEN"],
                                 MA_BENH = t1["MA_BENH"],
                                 MA_BENHKHAC = t1["MA_BENHKHAC"],
                                 MA_LYDO_VVIEN = t1["MA_LYDO_VVIEN"],
                                 MA_NOI_CHUYEN = t1["MA_NOI_CHUYEN"],
                                 NGAY_VAO = */
                             };

                DataTable Result_TB1 = new DataTable();
                DataColumn T_Total = new DataColumn("T_TONGCHI");
                DataColumn SP = new DataColumn("SOPHIEU");
                DataColumn STT2 = new DataColumn("STT");
                Result_TB1.Columns.Add(STT2);
                Result_TB1.Columns.Add(SP);
                Result_TB1.Columns.Add(T_Total);
                foreach (var i in result_t1)
                {
                    if(i.total_t2 != null && Convert.ToDouble(i.total_t1) != Convert.ToDouble(i.total_t2) && i.MLK != null)
                    {
                        //Console.WriteLine($"{i.STT,5} {i.MLK,10} {i.total_t1,10} {i.total_t2,10}");
                        Result_TB1.Rows.Add(i.STT, i.MLK, i.total_t1);
                    }
                    else if(i.SOPHIEU != null)
                    {
                        //Console.WriteLine($"{i.STT,5} {i.SOPHIEU,10} {i.total_t1,10}");
                        Result_TB1.Rows.Add(i.STT, i.SOPHIEU, i.total_t1);
                    }
                }


                //Console.WriteLine("\n\n----------RESULT TABLE 2----------");
                var result_t2 = from t2 in rows_key_dt2
                             join t1 in rows_dt1_copy on t2["Mã liên kết"] equals t1["SOPHIEU"] into temp
                             from t3 in temp.DefaultIfEmpty()
                             select new
                             {
                                 STT = t2["STT"],
                                 SOPHIEU = (t3 != null) ? t3["SOPHIEU"] : null,
                                 MLK = (t3 == null) ? t2["Mã liên kết"] : null,
                                 total_t1 = (t3 == null) ? null : t3["T_TONGCHI"],
                                 total_t2 = t2["Tổng chi"]
                                 //MA_BN = t1["MA_BN"],
                                 //HO_TEN = t1["HO_TEN"]
                             };

                DataTable Result_TB2 = new DataTable();
                Result_TB2 = key_dt2.Clone();
                foreach (var j in result_t2)
                {
                    if (j.total_t1 != null && Convert.ToDouble(j.total_t1) != Convert.ToDouble(j.total_t2) && j.SOPHIEU != null)
                    {
                        //Console.WriteLine($"{j.STT,5} {j.SOPHIEU,10} {j.total_t2,10} {j.total_t1,10}");
                        Result_TB2.Rows.Add(j.STT, j.SOPHIEU, j.total_t2);
                    }
                    else if (j.MLK != null)
                    {
                        //Console.WriteLine($"{j.STT,5} {j.MLK,10} {j.total_t2,10}");
                        Result_TB2.Rows.Add(j.STT, j.MLK, j.total_t2);
                    }
                }

                resultTableForm.SetTable_1(Result_TB1);
                resultTableForm.SetTable_2(Result_TB2);
                resultTableForm.ShowDialog();

                /*DataRow[] foundRows = dt1.Select("STT < 10", "STT DESC");
                PrintRows(foundRows, "filtered rows");

                foundRows = dt1.Select();
                PrintRows(foundRows, "all rows");*/
            }
        }

        private static void PrintRows(DataRow[] rows, string label)
        {
            Console.WriteLine("\n{0}", label);
            if (rows.Length <= 0)
            {
                Console.WriteLine("no rows found");
                return;
            }
            foreach (DataRow row in rows)
            {
                foreach (DataColumn column in row.Table.Columns)
                {
                    Console.Write("\ttable {0}", row[column]);
                }
                Console.WriteLine();
            }
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void CheckDataForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void dtgv1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

/*Tổng chi
if(dtgv1.DataSource != null || dtgv2.DataSource != null)
{
    if (dtgv1.DataSource != null)
    {
        DataTable dt1 = tableCollection1[cboSheet1.SelectedItem.ToString()];
        DataRow[] rows_1 = dt1.Select();
        double total_1 = 0;

        if (dt1.Columns.Contains("T_TONGCHI"))
        {
            var result = from t1 in rows_1 select new { total = t1["T_TONGCHI"] };
            total_1 = result.AsEnumerable().Sum(t1 => Convert.ToDouble(t1.total));
        }
        else if (dt1.Columns.Contains("Tổng chi"))
        {
            var result = from t1 in rows_1 select new { total = t1["Tổng chi"] };
            total_1 = result.AsEnumerable().Sum(t1 => Convert.ToDouble(t1.total));
        }
        else
        {
            MessageBox.Show("Dữ liệu trong file tải lên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        functionsForm.SetTotal_1(cboSheet1.Text, total_1);
    }

    if (dtgv2.DataSource != null)
    {
        DataTable dt2 = tableCollection2[cboSheet2.SelectedItem.ToString()];
        DataRow[] rows_2 = dt2.Select();
        double total_2 = 0;

        if (dt2.Columns.Contains("T_TONGCHI"))
        {
            var result = from t2 in rows_2 select new { total = t2["T_TONGCHI"] };
            total_2 = result.AsEnumerable().Sum(t2 => Convert.ToDouble(t2.total));
        }
        else if (dt2.Columns.Contains("Tổng chi"))
        {
            var result = from t2 in rows_2 select new { total = t2["Tổng chi"] };
            total_2 = result.AsEnumerable().Sum(t2 => Convert.ToDouble(t2.total));
        }
        else
        {
            MessageBox.Show("Dữ liệu trong file tải lên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        functionsForm.SetTotal_2(cboSheet2.Text, total_2);
    }
}
            
functionsForm.ShowDialog();*/