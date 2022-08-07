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
        private DataTableCollection tableCollectionLeft;
        private DataTableCollection tableCollectionRight;

        public CheckDataForm()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewLeft.DataSource = tableCollectionLeft[cboSheetLeft.SelectedItem.ToString()];
        }

        private void cboSheet2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewRight.DataSource = tableCollectionRight[cboSheetRight.SelectedItem.ToString()];
        }

        private void btnBrowserLeft_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = Constants.EXCEL_FILTERS })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileNameLeft.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollectionLeft = result.Tables;
                            cboSheetLeft.Items.Clear();
                            foreach (DataTable table in tableCollectionLeft)
                                cboSheetLeft.Items.Add(table.TableName);
                        }
                        cboSheetLeft.SelectedIndex = cboSheetLeft.Items.Count - 1;
                    }
                }
            }
        }

        private void btnBrowserRight_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = Constants.EXCEL_FILTERS })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileNameRight.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollectionRight = result.Tables;
                            cboSheetRight.Items.Clear();
                            foreach (DataTable table in tableCollectionRight)
                                cboSheetRight.Items.Add(table.TableName);
                        }
                        cboSheetRight.SelectedIndex = cboSheetRight.Items.Count - 1;
                    }
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (dataGridViewLeft.DataSource == null || dataGridViewRight.DataSource == null)
            {
                MessageBox.Show("Chưa đủ dữ liệu kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string keyLeft, keyRight;

                DataTable dataTableLeft = tableCollectionLeft[cboSheetLeft.SelectedItem.ToString()];
                
                if (dataTableLeft.Columns.Contains(Constants.HIS_SOPHIEU_COLUMN))
                {
                    dataTableLeft.PrimaryKey = new DataColumn[] { dataTableLeft.Columns[Constants.HIS_SOPHIEU_COLUMN] };
                    keyLeft = Constants.HIS_SOPHIEU_COLUMN;
                }
                else if(dataTableLeft.Columns.Contains(Constants.BHXH_MALIENKET_COLUMN))
                {
                    dataTableLeft.PrimaryKey = new DataColumn[] { dataTableLeft.Columns[Constants.BHXH_MALIENKET_COLUMN] };
                    keyLeft = Constants.BHXH_MALIENKET_COLUMN;
                }
                else
                {
                    keyLeft = Constants.EMPTY_STRING;
                }
                DataRow[] dataRowLeft = dataTableLeft.Select();

                
                DataTable dataTableRight = tableCollectionRight[cboSheetRight.SelectedItem.ToString()];    
                if(dataTableRight.Columns.Contains(Constants.BHXH_MALIENKET_COLUMN))
                {
                    dataTableRight.PrimaryKey = new DataColumn[] { dataTableRight.Columns[Constants.BHXH_MALIENKET_COLUMN] };
                    keyRight = Constants.BHXH_MALIENKET_COLUMN;
                }
                else if(dataTableRight.Columns.Contains(Constants.HIS_SOPHIEU_COLUMN))
                {
                    dataTableRight.PrimaryKey = new DataColumn[] { dataTableRight.Columns[Constants.HIS_SOPHIEU_COLUMN] };
                    keyRight = Constants.HIS_SOPHIEU_COLUMN;
                }
                else
                {
                    keyRight = Constants.EMPTY_STRING;
                }
                DataRow[] dataRowRight = dataTableRight.Select();

                DataTable dataTableBHXH = new DataTable();
                DataColumn maLienKetColumn = new DataColumn(Constants.BHXH_MALIENKET_COLUMN);
                dataTableBHXH.Columns.Add(new DataColumn(Constants.STT_COLUMN));
                dataTableBHXH.Columns.Add(maLienKetColumn);
                dataTableBHXH.Columns.Add(new DataColumn(Constants.BHXH_TONGCHI_COLUMN));
                dataTableBHXH.PrimaryKey = new DataColumn[] { maLienKetColumn };

                DataTable dataTableHIS = new DataTable();

                if (keyLeft.Equals(keyRight))
                {
                    MessageBox.Show(Message.ERROR_SIMILAR_TEMPLATE_FILE, Message.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Constants.BHXH_MALIENKET_COLUMN.Equals(keyLeft))
                {
                    dataTableHIS = dataTableRight.Copy();
                    foreach (DataRow dataRow in dataRowLeft)
                    {
                        string maLienKet = dataRow[Constants.BHXH_MALIENKET_COLUMN].ToString();
                        dataTableBHXH.Rows.Add(dataRow[Constants.STT_COLUMN], maLienKet.Split('_')[0], dataRow[Constants.BHXH_TONGCHI_COLUMN]);
                    }
                }
                else if (Constants.BHXH_MALIENKET_COLUMN.Equals(keyRight))
                {
                    dataTableHIS = dataTableLeft.Copy();
                    foreach (DataRow dataRow in dataRowRight)
                    {
                        string maLienKet = dataRow[Constants.BHXH_MALIENKET_COLUMN].ToString();
                        dataTableBHXH.Rows.Add(dataRow[Constants.STT_COLUMN], maLienKet.Split('_')[0], dataRow[Constants.BHXH_TONGCHI_COLUMN]);
                    }

                }
                else
                {
                    MessageBox.Show(Message.ERROR_WRONG_TEMPLATE_FILE, Message.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow[] dataRowHIS = dataTableHIS.Select();
                DataRow[] dataRowBHXH = dataTableBHXH.Select();

                //Console.WriteLine("----------RESULT TABLE HIS----------");
                var tableHIS_Checked = from rowHIS in dataRowHIS
                             join rowBHXH in dataRowBHXH on rowHIS[Constants.HIS_SOPHIEU_COLUMN] equals rowBHXH[Constants.BHXH_MALIENKET_COLUMN] into temp
                             from rowJoin in temp.DefaultIfEmpty()
                             select new
                             {
                                 STT = rowHIS[Constants.STT_COLUMN],
                                 BHXH_maLienKet = rowJoin?[Constants.BHXH_MALIENKET_COLUMN],
                                 HIS_SOPHIEU = (rowJoin == null)? rowHIS[Constants.HIS_SOPHIEU_COLUMN] : null,
                                 HIS_tongchi = rowHIS[Constants.HIS_TONGCHI_COLUMN],
                                 BHXH_tongchi = rowJoin?[Constants.BHXH_TONGCHI_COLUMN],
                                 HIS_MA_BN = rowHIS[Constants.HIS_MA_BN_COLUMN],
                                 HIS_HO_TEN = rowHIS[Constants.HIS_HO_TEN_COLUMN]
                             };

                DataTable dataTableHIS_Checked = new DataTable();
                dataTableHIS_Checked.Columns.Add(new DataColumn(Constants.STT_COLUMN));
                dataTableHIS_Checked.Columns.Add(new DataColumn(Constants.HIS_SOPHIEU_COLUMN));
                dataTableHIS_Checked.Columns.Add(new DataColumn(Constants.HIS_TONGCHI_COLUMN));

                DataTable dataTableTongTien_Checked = new DataTable();
                dataTableTongTien_Checked.Columns.Add(new DataColumn(Constants.STT_COLUMN));
                dataTableTongTien_Checked.Columns.Add(new DataColumn(Constants.HIS_SOPHIEU_COLUMN));
                dataTableTongTien_Checked.Columns.Add(new DataColumn(Constants.HIS_TONGCHI_COLUMN));
                dataTableTongTien_Checked.Columns.Add(new DataColumn(Constants.BHXH_MALIENKET_COLUMN));
                dataTableTongTien_Checked.Columns.Add(new DataColumn(Constants.BHXH_TONGCHI_COLUMN));
                foreach (var row in tableHIS_Checked)
                {
                    if(row.BHXH_tongchi != null && Convert.ToInt32(row.HIS_tongchi) != Convert.ToInt32(row.BHXH_tongchi) && row.BHXH_maLienKet != null)
                    {
                        dataTableTongTien_Checked.Rows.Add(row.STT, row.HIS_SOPHIEU, row.HIS_tongchi, row.BHXH_maLienKet, row.BHXH_tongchi);
                    }
                    else if(row.HIS_SOPHIEU != null)
                    {
                        dataTableHIS_Checked.Rows.Add(row.STT, row.HIS_SOPHIEU, row.HIS_tongchi);
                    }
                }


                //Console.WriteLine("\n\n----------RESULT TABLE 2----------");
                var result_t2 = from t2 in dataRowBHXH
                             join t1 in dataRowHIS on t2[Constants.BHXH_MALIENKET_COLUMN] equals t1[Constants.HIS_SOPHIEU_COLUMN] into temp
                             from t3 in temp.DefaultIfEmpty()
                             select new
                             {
                                 STT = t2[Constants.STT_COLUMN],
                                 HIS_SOPHIEU = (t3 != null) ? t3[Constants.HIS_SOPHIEU_COLUMN] : null,
                                 BHXH_maLienKet = (t3 == null) ? t2[Constants.BHXH_MALIENKET_COLUMN] : null,
                                 HIS_tongchi = (t3 == null) ? null : t3[Constants.HIS_TONGCHI_COLUMN],
                                 BHXH_tongchi = t2[Constants.BHXH_TONGCHI_COLUMN]
                             };

                DataTable dataTableBHXH_Checked = new DataTable();
                dataTableBHXH_Checked = dataTableBHXH.Clone();
                foreach (var row in result_t2)
                {
                    if (row.HIS_tongchi != null && Convert.ToDouble(row.HIS_tongchi) != Convert.ToDouble(row.BHXH_tongchi) && row.HIS_SOPHIEU != null)
                    {
                        //dataTableTongTien_Checked.Rows.Add(row.STT, row.HIS_SOPHIEU, row.HIS_tongchi, row.BHXH_maLienKet, row.BHXH_tongchi);
                    }
                    else if (row.BHXH_maLienKet != null)
                    {
                        dataTableBHXH_Checked.Rows.Add(row.STT, row.BHXH_maLienKet, row.BHXH_tongchi);
                    }
                }

                resultTableForm.SetTable_HIS(dataTableHIS_Checked);
                resultTableForm.SetTable_BHXH(dataTableBHXH_Checked);
                resultTableForm.SetTable_TongTien(dataTableTongTien_Checked);
                resultTableForm.ShowDialog();
            }
        }
    }
}