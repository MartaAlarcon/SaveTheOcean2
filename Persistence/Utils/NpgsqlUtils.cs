using SaveTheOcean2.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Microsoft.Extensions.Configuration;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.Persistence.Utils;
using SaveTheOcean2.DTO;
using Microsoft.Extensions.Configuration;
using SaveTheOcean2.Persistence.Mapping;


namespace SaveTheOcean2.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Cargar la cadena de conexión a la base de datos desde el archivo de configuración
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static AnimalDTO GetAnimal(NpgsqlDataReader reader)
        {
            AnimalDTO animal = new AnimalDTO
            {
                Date = reader.GetDateTime(0), // Suponiendo que el primer campo es para 'Date'
                Name = reader.GetString(1), // Suponiendo que el segundo campo es para 'Name'
                Place = reader.GetString(2), // Suponiendo que el tercer campo es para 'Place'
                Family = reader.GetString(3), // Suponiendo que el cuarto campo es para 'Family'
                Species = reader.GetString(4), // Suponiendo que el quinto campo es para 'Species'
                Weight = reader.GetDouble(5) // Suponiendo que el sexto campo es para 'Weight'
            };

            return animal;
        }
    }

}
