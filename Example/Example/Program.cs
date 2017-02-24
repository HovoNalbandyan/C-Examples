using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace Example
{
    public class Program
    {

        static void Main(string[] args)
        {
            Excel.Application xlApp = new
            Microsoft.Office.Interop.Excel.Application();
            var workbook = new Excel.Application();
            // Add new worksheet to Excel file.
            var worksheet = workbook.Worksheets.Add("New worksheet");
            // Set the value of the cell "A1".
            worksheet.Cells["A1"].Value = "Hello world!";
            // Save Excel file.
            workbook.Save("Workbook.xls");
        }
    }
}
