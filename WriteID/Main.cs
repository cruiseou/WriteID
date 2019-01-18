using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace WriteID
{
    public partial class Main : Form
    {
        public Main()
        {
            string dateold = "2019-01-17";
            DateTime dateoldtime = Convert.ToDateTime(dateold);
            DateTime datenew = DateTime.Now;
            TimeSpan td = datenew.Subtract(dateoldtime).Duration();
            int cha = td.Days;
            if (cha > 3)
            {
                this.Close();
                this.Dispose();
            }
            InitializeComponent();

            


            string filePath = System.Environment.CurrentDirectory;

            if (!File.Exists(filePath+ "\\DeviceID.xls"))
            {


                HSSFWorkbook workbook = new HSSFWorkbook();
                ICellStyle cellStyle = workbook.CreateCellStyle();
                cellStyle.FillPattern = FillPattern.SolidForeground;
                cellStyle.FillBackgroundColor = HSSFColor.Red.Index;
                ISheet sheet = workbook.CreateSheet("DeviceID ");
                IRow row = sheet.CreateRow(0);
                ICell cell_0 = row.CreateCell(0, CellType.String);
                cell_0.SetCellValue("ID");


                ICell cell_1 = row.CreateCell(1, CellType.String);
                cell_1.SetCellValue("DeviceID");

                ICell cell_2 = row.CreateCell(2, CellType.String);
                cell_2.SetCellValue("PAC ");
                ICell cell_3 = row.CreateCell(3, CellType.String);
                cell_3.SetCellValue("记录时间");

                FileStream fs = new FileStream(Path.Combine(filePath, "DeviceID.xls"), FileMode.Create);
                workbook.Write(fs);
                fs.Close();
                fs.Dispose();
            }
          




        }

        
    }
}
