using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class DatosTrabajador
    {
        private string connectionString = "YourConnectionString";

        public void InsertarTrabajador(string nombre, string apellidos, decimal sueldoBruto, string categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Trabajadores (Nombre, Apellidos, SueldoBruto, Categoria) VALUES (@Nombre, @Apellidos, @SueldoBruto, @Categoria)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellidos", apellidos);
                command.Parameters.AddWithValue("@SueldoBruto", sueldoBruto);
                command.Parameters.AddWithValue("@Categoria", categoria);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Trabajador> ObtenerTrabajadores()
        {
            List<Trabajador> trabajadores = new List<Trabajador>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Trabajadores";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Trabajador trabajador = new Trabajador
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        SueldoBruto = Convert.ToDecimal(reader["SueldoBruto"]),
                        Categoria = reader["Categoria"].ToString()
                    };
                    trabajadores.Add(trabajador);
                }
            }
            return trabajadores;
        }
    }
}
