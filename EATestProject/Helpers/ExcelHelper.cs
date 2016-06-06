using System.Collections.Generic;
using System.Data;
using System.IO;
using Excel;

namespace EATestProject.Helpers
{
    public class Excelhelper
    {
        private static List<DataCollection> _dataCol = new List<DataCollection>();

        //reading data from excel and storing it in a DataTable
        private static DataTable ExcelToDataTable(string fileName)
        {
            //Open file and return as a stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //CreateXMLreader
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //Read first row as col name
            excelReader.IsFirstRowAsColumnNames = true;
            //store the data as a dataset
            DataSet tableDataSet = excelReader.AsDataSet();
            //get all the tables of a dataset
            DataTableCollection resulTableCollection = tableDataSet.Tables;
            //store the data in a datatable
            DataTable resultTable = resulTableCollection["Sheet1"];
            //return
            return resultTable;
        }

        public static void PopulateDataIntoCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);
            
            //Iterate through the rows and columns of the table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dataTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName =  table.Columns[col].ColumnName,
                        colvalue = table.Rows[row - 1][col].ToString()
                   };
                _dataCol.Add(dataTable);
                }
            }
        }
        
    }

    public class DataCollection
    {
        public int rowNumber { get; set; }
        public string colvalue { get; set; }
        public string colName { get; set; }
    }
}
