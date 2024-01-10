using System;
using Microsoft.Office.Interop.Excel;
namespace Pathfinder1ESpellbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadExcel(string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets[0];
        }
    }
}