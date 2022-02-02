using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._01._22
{
    class Queries
    {
        public static void SelectAll(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shop", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }
                Console.WriteLine("\n======================\n");
            }


        }

        public static void SelectType(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [Type] FROM Shop", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }

        public static void SelectManager(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [Name] FROM Manager", connection);
            DataTable shop = new DataTable("Manager");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }

        public static void SelectMaxCount(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Shop ORDER BY [Count] DESC", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }

        public static void SelectMinCount(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Shop ORDER BY [Count] ASC", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }


        public static void SelectMinPrice(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Shop ORDER BY Price ASC", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }


        public static void SelectMaxPrice(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Shop ORDER BY Price DESC", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }

        public static void SelectKancForType(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shop WHERE Type = 'pencil' ", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }
        public static void SelectSaleKancForManager(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shop Where sale = 1", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }
        public static void SelectBuyKancForFirm(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Shop Where firm = 'towukrkanc'", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }
        public static void SelectInfoForNewSale(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Manager ORDER BY date DESC", connection);
            DataTable shop = new DataTable("Manager");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }
        public static void SelectAvgKancPrice(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT AVG(count) FROM Shop WHERE type = 'pencil'", connection);
            DataTable shop = new DataTable("Shop");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(shop);
            Console.WriteLine("\n======================\n");

            foreach (DataRow row in shop.Rows)

            {
                foreach (DataColumn column in shop.Columns)
                {
                    Console.WriteLine("{0} : {1}", column.ColumnName, row[column]);
                }

            }

            Console.WriteLine("\n======================\n");
        }
    }
}
