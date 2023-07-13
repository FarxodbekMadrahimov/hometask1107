namespace MyLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            DbFunctions dbFunctions = new DbFunctions();

            //dbFunctions.Add();
            //dbFunctions.GetAll();
            //dbFunctions.GetById();
            //dbFunctions.GetByName();
            //dbFunctions.DeleteByName();
            //dbFunctions.DeleteById();
            //dbFunctions.DeleteAll();
            //dbFunctions.Update();
        }
    }
}
//using Npgsql;

//namespace MyLesson
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=dvdRental;";

//            var con = new NpgsqlConnection(connectionString);

//            con.Open();

//            using var cmd = new NpgsqlCommand();

//            cmd.Connection = con;

//            var result = GetBySubject();

//            foreach (var i in result)
//            {
//                Console.WriteLine(i);
//            }

//            IEnumerable<List<object>> GetBySubject()
//            {
//                cmd.CommandText = $"select * from actor inner join film_actor using(actor_id);";

//                NpgsqlDataReader reader = cmd.ExecuteReader();

//                var result = new List<List<object>>();

//                while (reader.Read())
//                {
//                    result.AddRange(reader);
//                }

//                return result;
//            }
//        }
//    }
//}



//using System;
//using Npgsql;
//using System.Collections.Generic;
//using System.IO.Pipes;

//namespace MyProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=dvdRental;";

//            var cmd = new NpgsqlCommand();

//            string commandText = Console.ReadLine();

//            using (var con = new NpgsqlConnection(connectionString))
//            {
//                con.Open();
//                cmd.Connection = con;

//                var result = GetBySubject(cmd,commandText);

//                foreach (var i in result)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            IEnumerable<object> GetBySubject(NpgsqlCommand cmd,string commandText)
//            {
//                cmd.CommandText = /*"SELECT * FROM actor INNER JOIN film_actor USING(actor_id);";*/ commandText;

//                using (NpgsqlDataReader reader = cmd.ExecuteReader())
//                {
//                    var result = new List<object>();

//                    while (reader.Read())
//                    {
//                        result.Add($"{reader[0]} {reader[1]} {reader[2]} {reader[3]}");
//                    }

//                    return result;
//                }
//            }
//        }
//    }
//}


//using Dapper;
//using MyLessons;
//using Npgsql;

//namespace MyLesson
//{
//    class Program
//    {   
//        static void Main(string[] args)
//        {
//            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=dvdRental;";

//            var con = new NpgsqlConnection(connectionString);


//        }
//        static void Get()
//        {
//            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=dvdRental;";

//            var con = new NpgsqlConnection(connectionString);

//            con.Open();

//            string sql = "select * from actor";

//            var users = con.Query<actor>(sql);

//            foreach (var i in users)
//            {
//                Console.WriteLine($"{i.actor_id} {i.first_name} {i.last_name} {i.last_update}");
//            }
//        }
//        static void Add()
//        {
//            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=dvdRental;";

//            Console.Write("firstName: ");
//            string firstName = Console.ReadLine();
//            Console.Write("lastName: ");
//            string lastName = Console.ReadLine();

//            var con = new NpgsqlConnection(connectionString);

//            con.Open();

//            string sql = $"insert into actor(first_name,last_name)values('{firstName}','{lastName}')";

//            var users = con.Query<actor>(sql);
//        }
//        static void DeleteAll()
//        {
//            Console.Write("DatabaseName: ");
//            string databaseName = Console.ReadLine();
//            Console.Write("Table Name");
//            string tableName = Console.ReadLine();

//            string connectionString = $"Server=localhost;Port=5433;User Id=postgres;Password=1234;Database={databaseName};";

//            var con = new NpgsqlConnection(connectionString);

//            con.Open();

//            string sql = $"delete from {tableName} where id = id";

//            var users = con.Query<actor>(sql);
//        }
//    }
//}