using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace P18.Data.DataAcces
{
    internal class PersonajesDB
    {
        private string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=crocomodo";//Cadena de conexion a la base de datos
       
        //Metodo para probar la conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//Abrir la conexion con la base de datos
                    return true;//Funciono
                }
                catch (Exception)
                {
                    return false;//No funciono
                }
            }
        }

        //Método para leer todos los personajes de la base de datos y retornarlos como un DataTable
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes); // Llenar el DataTable con los resultados de la consulta
                    }
                }
            }

            return personajes;//Devolver el DataTable con los personajes 
        }

        //Metodo para crear un personaje
        public int CrearPersonaje(string nombre, string raza, int nivelPoder, string historia, DateTime fecha_creacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, historia,fecha_creacion) VALUES (@nombre, @raza, @nivelPoder,@historia,@fecha_creacion)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    //Establecer los parametros de la consulta
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);
                    command.Parameters.AddWithValue("@fecha_Creacion", fecha_creacion);

                    return command.ExecuteNonQuery();//Ejecutar la consulta y retornar el numero de filas afectadas
                }
            }
        }

        //Busca un personaje por id
        public DataTable BuscarPersonajes(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);//Establecer el parametro id

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);// // Llenar el DataTable con los resultados de la consulta
                    }
                }
            }

            return personaje; // Devolver el DataTable con el personaje encontrado
        }

        //Busca un personaje por historia 

        public DataTable BuscarPersonajes(string historia)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE historia like @historia";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@historia", "%" + historia + "%");//Establecer el parametro historia 

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;// Devolver el DataTable con el personaje encontrado
        }

        //Buscar un personaje por fecha de creacion
        public DataTable Buscarfecha(DateTime firstdate, DateTime seconddate)
        {
            DataTable personaje = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE fecha_creacion BETWEEN @firstdate and @seconddate";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@firstdate", firstdate);//Establecer el primer parametro de la fecha, la inicial
                    command.Parameters.AddWithValue("@seconddate", seconddate);//Establecer el segundo parametro de la fecha, la final

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }
            return personaje;// Devolver el DataTable con el personaje encontrado
        }

        // Método para actualizar un personaje
        public void ActualizarPersonaje(int id, string nombre, string raza, int nivelPoder, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE personajes_dragon_ball SET nombre = @nombre, raza = @raza, nivel_poder = @nivelPoder, historia= @historia WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    //Parametros de la consulta
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);
                    command.ExecuteNonQuery();//Ejecutar la consulta
                }
            }
        }

        // Método para eliminar un personaje
        public void EliminarPersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
