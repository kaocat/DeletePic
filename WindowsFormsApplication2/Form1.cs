using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

using Microsoft.Office.Interop.Excel;
using NPOI;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        protected List<string> delList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tDelDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnOpenXnl_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "Excel Files|*.xlsx;*.xlsm";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tDelDirXml.Text = dialog.FileName;
                openEXcel();
            }
        }

        private void oputRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void openEXcel()
        {
            string fileExt = Path.GetExtension(tDelDirXml.Text);
            //Declare the sheet interface
            ISheet sheet;

            //Get the Excel file according to the extension
            if (fileExt.ToLower() == ".xls")
            {
                //Use the NPOI Excel xls object
                /*HSSFWorkbook hssfwb;
                using (FileStream file = new FileStream(tDelDirXml.Text, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new HSSFWorkbook(file);
                }

                //Assign the sheet
                sheet = hssfwb.GetSheetAt(0);
                readExcelToList(sheet);*/
                MessageBox.Show("不支援xls");
            }
            else //.xlsx extension
            {
                //Use the NPOI Excel xlsx object
                XSSFWorkbook hssfwb;
                using (FileStream file = new FileStream(tDelDirXml.Text, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new XSSFWorkbook(file);
                }

                //Assign the sheet
                sheet = hssfwb.GetSheetAt(0);
                readExcelToList(sheet);
            }

        }

        private void readExcelToList(ISheet sheet)
        {
            XSSFRow hr = (XSSFRow)sheet.GetRow(0);
            //取得欄位數量
            int dLastNum = hr.LastCellNum;
            //有多少筆資料 j=1 有標題,j=0 無標題 (從哪開始讀取資料)
            for (int j = 0; j <= sheet.LastRowNum; j++)
            {
                hr = (XSSFRow)sheet.GetRow(j);
                //宣告陣列 並將資料同時置入
                if (hr == null)
                {
                    string tempS = "";
                    delList.Add(tempS);
                    //oputRes.Text = tempS + "\n";
                }
                else
                {
                    delList.Add(hr.GetCell(0).ToString());
                    //oputRes.Text = hr.GetCell(0).ToString() + "\n";
                }
                //將每一行的資料存放至arrMyData儲存 ，之後要做什麼應用取得 arrMyData 即可~

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DirSearch(tDelDir.Text);
        }

        public void DirSearch(string sDir)
        {
            string[] operators = { "png", "jpg", "jpeg" };
            
            if(delList.Count == 0)
            {
                MessageBox.Show("請選擇參考用EXCEL或是EXCEL清單格式不符");
                return;
            }
            //DirectoryInfo d = new DirectoryInfo(sDir);
            foreach (var file in Directory.GetFiles(sDir))
            {
                if (operators.Any(x => file.EndsWith(x)))
                {
                    string tempName = Path.GetFileNameWithoutExtension(file) + Path.GetExtension(file);
                    foreach (var key in delList)
                    {
                        if (key == tempName)
                        {
                            oputRes.Text += "我被刪除了 : " + file + "\r\n";
                            File.Delete(file);
                        }
                    }
                }
            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                foreach (var file in Directory.GetFiles(d))
                {
                    if (operators.Any(x => file.EndsWith(x)))
                    {
                        string tempName = Path.GetFileNameWithoutExtension(file) + Path.GetExtension(file);
                        foreach (var key in delList)
                        {
                            if (key == tempName)
                            {
                                oputRes.Text += "我被刪除了 : " + file + "\r\n";
                                File.Delete(file);
                            }
                        }
                    }
                }
                DirSearch(d);
            }       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
