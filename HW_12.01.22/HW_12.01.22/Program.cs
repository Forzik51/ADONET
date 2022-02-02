// See https://aka.ms/new-console-template for more information



using HW_12._01._22;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Encoding enc = new UTF8Encoding(true, true);
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectToStepDB"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
                Console.WriteLine(connection.Database);
                Console.WriteLine(connection.ConnectionString);
                Console.WriteLine("=====================");
                int k = 0;
                while (k != 12)
                {
                    Console.WriteLine(
                        "1- Отображение всей информации о товаре\n" +
                        "2-  Отображение всех типов товаров\n" +
                        "3-  Отображение всех поставщиков\n" +
                        "4-  Показать товар с максимальным количеством\n" +
                        "5-  Показать товар с минимальным количеством\n" +
                        "6- Показать товар с минимальной себестоимостью\n" +
                        "7- Показать товар с максимальной себестоимостью\n" +
                        "8- Показать товары, заданной категории\n" +
                        "9- Показать товары, заданного поставщика\n" +
                        "10- Показать самый старый товар на складе\n" +
                        "11- Показать среднее количество товаров по каждому типу товара\n" +
                        "12- Exit"

                        );
                    k = Int32.Parse(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            Queries.GetAll(connection);
                            break;

                        case 2:
                            Queries.GetAllType(connection);
                            break;

                        case 3:
                            Queries.GetAllProv(connection);
                            break;
                        case 4:
                            Queries.GetMaxCount(connection);
                            break;
                        case 5:
                            Queries.GetMinCount(connection);
                            break;
                        case 6:
                            Queries.GetMinPrice(connection);
                            break;
                        case 7:
                            Queries.GetMaxPrice(connection);
                            break;
                        case 8:
                            Queries.SelectCategory(connection);
                            break;
                        case 9:
                            Queries.SelectProv(connection);
                            break;
                        case 10:
                            Queries.GetOldTov(connection);
                            break;
                        case 11:
                            Queries.GetAvgType(connection);
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}