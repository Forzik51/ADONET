using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12._01._22
{
    public class Queries
    {
        public static void GetAll(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }
        public static void GetAllType(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Type FROM Storage";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Type"]);
            }
            reader.Close();
        }
        public static void GetAllProv(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Provider FROM Storage";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Provider"]);
            }
            reader.Close();
        }
        public static void GetMaxCount(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage WHERE Count = MAX(Count)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }
        public static void GetMinCount(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage WHERE Count = MIN(Count)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }

        public static void GetMaxPrice(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage WHERE Price = MAX(Price)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }
        public static void GetMinPrice(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage WHERE Price = MIN(Price)";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }
        public static void SelectCategory(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage WHERE Type = 'TV'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }
        public static void SelectProv(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Storage WHERE Provider = 'China'";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            }
            reader.Close();
        }
        public static void GetOldTov(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM StudentsMarks WHERE Data = MIN(Data)";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            reader.Close();
        }

        public static void GetAvgType(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT AVG(Count),Type FROM StudentsMarks WHERE Type = 'TV'";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Console.WriteLine(reader["Id"] + "  " + reader["Name"] + "  " + reader["Type"] + "  " + reader["Provider"] + "  " + reader["Count"] + "  " + reader["Price"] + "  " + reader["Data"]);
            reader.Close();
        }
    }
}
