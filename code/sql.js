using System;
using System.Data.SqlClient;

public class SqlInjectionExample
{
    public static void Main(stringargs)
    {
        Console.WriteLine("Lütfen aranacak kullanıcı adını girin:");
        string username = Console.ReadLine();

        string connectionString = "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"; // Kendi veritabanı bilgilerinizi girin

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Username = '" + username + "'"; // DİKKAT: SQL Injection zafiyeti burada
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("Kullanıcı bulundu:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, Kullanıcı Adı: {reader["Username"]}, Email: {reader["Email"]}");
                    }
                }
                else
                {
                    Console.WriteLine("Belirtilen kullanıcı adı bulunamadı.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }

        Console.ReadKey();
    }
}
