using System;
using System.IO;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;


namespace WriteID.Units
{
    public partial class HistoricalRecord : UserControl
    {
        public HistoricalRecord()
        {
            InitializeComponent();
        }

        public bool Savedata(string ID, string SIGFOX_ID, string SIGFOX_PAC)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                string datetime= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = ID;
                this.dataGridView1.Rows[index].Cells[1].Value = SIGFOX_ID;
                this.dataGridView1.Rows[index].Cells[2].Value = SIGFOX_PAC;
                this.dataGridView1.Rows[index].Cells[3].Value = datetime;
                SaveToExcel(ID, SIGFOX_ID, SIGFOX_PAC, datetime);

            }));
            return true;
        }

        void SaveToExcel(string ID, string SIGFOX_ID, string SIGFOX_PAC,string datetime)
        {
            string filepath= System.Environment.CurrentDirectory +"\\DeviceID.xls";

            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);//读取流

            POIFSFileSystem ps = new POIFSFileSystem(fs);//需using NPOI.POIFS.FileSystem;
            IWorkbook workbook = new HSSFWorkbook(ps);
            ISheet sheet = workbook.GetSheetAt(0);//获取工作表
            IRow row = sheet.GetRow(0); //得到表头
            FileStream fout = new FileStream(filepath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);//写入流
            row = sheet.CreateRow((sheet.LastRowNum + 1));//在工作表中添加一行

            ICell cell1 = row.CreateCell(0);
            cell1.SetCellValue(ID);//赋值

            ICell cell_1 = row.CreateCell(1);
            cell_1.SetCellValue(SIGFOX_ID);

            ICell cell_2 = row.CreateCell(2);
            cell_2.SetCellValue(SIGFOX_PAC);
            ICell cell_3 = row.CreateCell(3);
            cell_3.SetCellValue(datetime);
            fout.Flush();
            workbook.Write(fout);//写入文件
            workbook = null;
            fout.Close();




        }

    }
}
