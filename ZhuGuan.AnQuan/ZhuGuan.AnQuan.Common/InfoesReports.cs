using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;

namespace ZhuGuan.AnQuan.Common
{
    public class InfoesReports
    {
        public static void ExportToExcel(string fileName,string fileTitle,DataGridView dgv)
        {
            //创建工作簿
            HSSFWorkbook workbook = new HSSFWorkbook();
            //创建工作表
            HSSFSheet sheet = workbook.CreateSheet(fileTitle);
            //创建标题行
            HSSFRow rowTitle = sheet.CreateRow(0);
            //样式操作
            var style = workbook.CreateCellStyle();
            style.Alignment = HSSFCellStyle.ALIGN_CENTER;
            style.BorderTop = HSSFCellStyle.BORDER_THIN;
            style.BorderLeft = HSSFCellStyle.BORDER_THIN;
            style.BorderRight = HSSFCellStyle.BORDER_THIN;
            style.BorderBottom = HSSFCellStyle.BORDER_THIN;
            //标题行创建单元格
            HSSFCell cellTitle = rowTitle.CreateCell(0);
            cellTitle.SetCellValue(fileTitle);
            sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, dgv.ColumnCount-3));    //减去标题列和选择列，索引从2开始
            cellTitle.CellStyle = style;

            //创建列头
            HSSFRow rowHeader = sheet.CreateRow(1);
            //遍历创建列头单元格 //减去标题列和选择列，索引从2开始
            for (int i = 2; i < dgv.ColumnCount; i++)
            {
                var cellheader = rowHeader.CreateCell(i - 2);
                cellheader.SetCellValue(dgv.Columns[i].HeaderText);
                cellheader.CellStyle = style;
            }

            //创建表格内容行
            for (int i = 0; i < dgv.RowCount; i++)
            {
                var rowContent = sheet.CreateRow(i + 2);
                for (int j = 2; j < dgv.ColumnCount; j++)
                {
                    var cellContent = rowContent.CreateCell(j - 2);
                    cellContent.SetCellValue(dgv.Rows[i].Cells[j].Value == null ? String.Empty : dgv.Rows[i].Cells[j].Value.ToString());
                    cellContent.CellStyle = style;
                }
            }

            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                workbook.Write(fs);
                fs.Dispose();
                MessageBox.Show("导出完成", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }




        }
    }
}
