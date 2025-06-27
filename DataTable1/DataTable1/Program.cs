using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataTable1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DataTable Table = new DataTable();

            Table.Columns.Add("ID", typeof(int));
            Table.Columns.Add("Name", typeof(string));
            Table.Columns.Add("Country", typeof(string));
            Table.Columns.Add("Salary", typeof(Double));
            Table.Columns.Add("Date", typeof(DateTime));
           

            Table.Rows.Add(1,"John Doe", "USA", 50000.00, DateTime.Now);
            Table.Rows.Add(2, "Jane Smith", "UK", 60000.00, DateTime.Now);
            Table.Rows.Add(3, "Sam Brown", "Canada", 55000.00, DateTime.Now);
            Table.Rows.Add(4, "Lisa White", "Australia", 70000.00, DateTime.Now);



            Console.WriteLine("\t _________________________________________________________________________________________");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-10}|{4,-21}|", "ID", "Name", "Country", "Salary", "Date Of Birth");

            foreach (DataRow row in Table.Rows)
            {
                Console.WriteLine("\t|-----------------------------------------------------------------------------------------|");
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-10}|{4,-21}|", row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }
            Console.WriteLine("\t|_________________________________________________________________________________________|");

        }
    }
}
