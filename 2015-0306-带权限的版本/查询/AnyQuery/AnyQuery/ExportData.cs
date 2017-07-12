using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;

namespace AnyQuery
{
    public partial class ExportData : Form
    {
        public ExportData()
        {
            InitializeComponent();
        }

        SqlConnection con;//连接
        string sql = "";

        public ExportData(string sqltext)
        {
            InitializeComponent();
            sql = sqltext;
        }

        //初始化
        private void ExportData_Load(object sender, EventArgs e)
        {

        }

        //取消
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确定输出
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename.Text != "")
                {
                    DataSet ds;
                    con = new SqlConnection(dbHelp.Connection);
                    string sqlstring = sql;
                    SqlDataAdapter da = new SqlDataAdapter(sqlstring, con);
                    ds = new DataSet();
                    da.Fill(ds);
                    DataSetToExcel(ds, filename.Text, toopen.Checked);
                }
                else
                {
                    MessageBox.Show("请选择保存路径！", "提示");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("输出异常！", "提示");
                return;
            }
        }

        //选择路径
        private void btnfilename_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.ShowDialog();
            string path = fld.SelectedPath;
            if (path != "")
            {
                filename.Text = path;
            }
        }

        //DataSet数据导出Excel
        public bool DataSetToExcel(DataSet dataSet, string path, bool isShowExcle)
        {
            System.Data.DataTable dataTable = dataSet.Tables[0];
            int rowNumber = dataTable.Rows.Count;//不包括字段名 
            int columnNumber = dataTable.Columns.Count;
            int colIndex = 0;

            exportprogress.Maximum = rowNumber;
            exportprogress.Minimum = 0;

            if (rowNumber == 0)
            {
                MessageBox.Show("没有任何数据可以导入到Excel文件！","提示");
                return false;
            }

            //建立Excel对象 
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.Application.Workbooks.Add(true); 
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            excel.Visible = false;
            //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1]; 
            Microsoft.Office.Interop.Excel.Range range;

            //生成字段名称 
            foreach (DataColumn col in dataTable.Columns)
            {
                colIndex++;
                excel.Cells[1, colIndex] = col.ColumnName;
            }

            object[,] objData = new object[rowNumber, columnNumber];

            for (int r = 0; r < rowNumber; r++)
            {
                for (int c = 0; c < columnNumber; c++)
                {
                    objData[r, c] = dataTable.Rows[r][c];
                }
                //Application.DoEvents(); 
                exportprogress.Value = r + 1;
            }

            // 写入Excel 
            range = worksheet.Range[excel.Cells[2, 1], excel.Cells[rowNumber + 1, columnNumber]];
            range.NumberFormat = "@";//设置单元格为文本格式 
            range.Value2 = objData;
            worksheet.Range[excel.Cells[2, 1], excel.Cells[rowNumber + 1, 1]].NumberFormat = "yyyy-mm-dd hh:mm";

            //路径处理
            string last = path.Substring(path.Length - 1, 1);
            if (last == "\\")
            {
                path = path.Substring(0, path.Length - 1);
            }
            //时间处理
            string time = DateTime.Now.ToString("yyyy-mm-dd HH-mm-ss");
            //保存的文件名整合
            string fileName = path + "\\" + SearchMain.selnameCN.ToString() + "查询结果 " + time + ".xls";
            //导出
            workbook.SaveAs(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

            try
            {
                workbook.Saved = true;
                excel.UserControl = false;
                //excelapp.Quit(); 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                workbook.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges, Missing.Value, Missing.Value);
                excel.Quit();
            }

            if (isShowExcle)
            {
                System.Diagnostics.Process.Start(fileName);
            }
            MessageBox.Show("导出数据成功！", "提示");
            this.Close();
            return true;
        }
    }
}
