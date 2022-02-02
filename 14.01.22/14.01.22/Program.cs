using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _14._01._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToStepDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                int k = 0;
                while (k != 13)
                {
                    Console.WriteLine(
                        "1-  Select All kanc\n" +
                        "2-  Select all type\n" +
                        "3-  Select all manager name\n" +
                        "4-  Select max kanc count\n" +
                        "5-  Select min kanc count\n" +
                        "6-  Select min kanc price\n" +
                        "7-  Select max kanc price\n" +
                        "8-  Select kanc for type\n" +
                        "9-  Select sale kanc for manager\n" +
                        "10-  Select buy kanc for firm\n" +
                        "11-  Select info for new sale\n" +
                        "12-  Select avg kanc price\n" +
                        "13-  Exit\n"
                        );
                    k = Int32.Parse(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            Queries.SelectAll(connection);
                            break;

                        case 2:
                            Queries.SelectType(connection);
                            break;

                        case 3:
                            Queries.SelectManager(connection);
                            break;
                        case 4:
                            Queries.SelectMaxCount(connection);
                            break;
                        case 5:
                            Queries.SelectMinCount(connection);
                            break;
                        case 6:
                            Queries.SelectMinPrice(connection);
                            break;
                        case 7:
                            Queries.SelectMaxPrice(connection);
                            break;
                        case 8:
                            Queries.SelectKancForType(connection);
                            break;
                        case 9:
                            Queries.SelectSaleKancForManager(connection);
                            break;
                        case 10:
                            Queries.SelectBuyKancForFirm(connection);
                            break;
                        case 11:
                            Queries.SelectInfoForNewSale(connection);
                            break;
                        case 12:
                            Queries.SelectAvgKancPrice(connection);
                            break;


                    }
                }
            }

        }
    }
}
