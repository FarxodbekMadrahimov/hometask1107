using Azure;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons
{
    internal class DbFunctions : IDbFunctions
    {

        public void Add()
        {
            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            Console.Write("firstName: ");
            string firstName = Console.ReadLine();
            Console.Write("lastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            string sql = $"insert into users(firstName,lastname,age)values('{firstName}','{lastName}','{age}')";

            var users = con.Query<user>(sql);
        }

        public void DeleteAll()
        {
            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            string sql = $"delete from users where id = id";

            var users = con.Query<user>(sql);
        }

        public void DeleteById()
        {
            GetAll();
            Console.WriteLine();
            Console.Write("Id: ");
            int name = int.Parse(Console.ReadLine());

            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            string sql = $"delete from users where id = '{name}'";

            var users = con.Query<user>(sql);
        }

        public void DeleteByName()
        {
            GetAll();
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();

            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            string sql = $"delete from users where firstname = '{name}'";

            var users = con.Query<user>(sql);
        }

        public void GetAll()
        {
            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            string sql = $"select * from users";

            var users = con.Query<user>(sql);

            foreach (var i in users)
            {
                Console.WriteLine($"Id: {i.id}\nFirstName: {i.firstName}\nLastName: {i.lastName}\nAge: {i.age}");
                Console.WriteLine();
            }
        }

        public void GetById()
        {
            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            string sql = $"select * from users where id = '{id}'";

            var users = con.Query<user>(sql);

            foreach (var i in users)
            {
                Console.WriteLine($"Id: {i.id}\nFirstName: {i.firstName}\nLastName: {i.lastName}\nAge: {i.age}");
                Console.WriteLine();
            }
        }

        public void GetByName()
        {
            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            Console.Write("Name: ");

            string  name = Console.ReadLine();

            string sql = $"select * from users where firstName = '{name}'";

            var users = con.Query<user>(sql);

            foreach (var i in users)
            {
                Console.WriteLine($"Id: {i.id}\nFirstName: {i.firstName}\nLastName: {i.lastName}\nAge: {i.age}");
                Console.WriteLine();
            }
        }

        public void Update()
        {
            GetAll();

            Console.Write("UserId: ");
            int id = int.Parse(Console.ReadLine());

            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=mydata;";

            var con = new NpgsqlConnection(connectionString);

            con.Open();

            Console.Write("FirstName: ");
            string firstName = Console.ReadLine();
            Console.Write("LastName: ");
            string lastName = Console.ReadLine(); 
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            string sql = $"update users set firstName = '{firstName}',lastName = '{lastName}',age = '{age}' where id = '{id}'";

            var users = con.Query<user>(sql);
        }
    }
}
