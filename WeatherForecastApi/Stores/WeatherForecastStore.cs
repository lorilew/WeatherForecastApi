namespace TodoApi.Models
{
    using System;
    using System.Collections.Generic;
    using Dapper;
    using Npgsql;

    public class WeatherForecastStore
    {
        private static string Host = "postgresdb";
        private static string User = "postgres";
        private static string DBname = "postgres";
        private static string Password = "fred";
        private static string Port = "5432";

        public static IEnumerable<WeatherForecast> Get()
        {
            // Build connection string using parameters from portal
            //
            string connString =
                String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
            
            using (var connection = new NpgsqlConnection(connString))
            {
                return connection.Query<WeatherForecast>($@"SELECT * FROM ""weatherForecast""");
            }
        }
    }
}
