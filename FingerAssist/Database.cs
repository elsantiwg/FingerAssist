using System;
using System.Data;
using Npgsql;

namespace Sistema_Empresarial
{
    public class Database
    {
        private string cadenaConexion;

        public Database(string servidor, string puerto, string usuario, string contraseña, string baseDatos)
        {
            cadenaConexion = $"Server={servidor};Port={puerto};User Id={usuario};Password={contraseña};Database={baseDatos};";
        }

        private NpgsqlConnection ObtenerConexion()
        {
            return new NpgsqlConnection(cadenaConexion);
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable resultado = new DataTable();
            try
            {
                using (NpgsqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(consulta, conexion))
                    {
                        adapter.Fill(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar consulta: " + ex.Message);
            }
            return resultado;
        }

        public void EjecutarComando(string comando)
        {
            try
            {
                using (NpgsqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(comando, conexion))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar comando: " + ex.Message);
            }
        }
        public void InsertarHuella(int empleadoId, string huellaBase64)
        {
            // Comando SQL que intenta insertar o actualizar si hay un conflicto en empleado_id
            string comando = @"
        INSERT INTO HuellasEmpleados (empleado_id, huella) 
        VALUES (@empleadoId, @huella)
        ON CONFLICT (empleado_id) 
        DO UPDATE SET huella = EXCLUDED.huella;
    ";

            try
            {
                using (NpgsqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(comando, conexion))
                    {
                        command.Parameters.AddWithValue("@empleadoId", empleadoId);
                        command.Parameters.AddWithValue("@huella", huellaBase64);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar o actualizar huella: " + ex.Message);
            }
        }
        public List<string> ObtenerTodasLasHuellas()
        {
            List<string> huellas = new List<string>();
            string consulta = "SELECT huella FROM HuellasEmpleados";
            try
            {
                using (NpgsqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(consulta, conexion))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string huellaBase64 = reader.GetString(0);
                                huellas.Add(huellaBase64);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las huellas: " + ex.Message);
            }
            return huellas;
        }
        public int ObtenerEmpleadoIdPorHuella(string huellaBase64)
        {
            int empleadoId = 0;
            string consulta = "SELECT empleado_id FROM HuellasEmpleados WHERE huella = @huella";
            try
            {
                using (NpgsqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(consulta, conexion))
                    {
                        command.Parameters.AddWithValue("@huella", huellaBase64);
                        empleadoId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID del empleado: " + ex.Message);
            }
            return empleadoId;
        }
    }
}