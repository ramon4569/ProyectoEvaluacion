using System;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Data;
using CapaDatos;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace CapaNegocio
{
    public class Evaluacion
    {
        public string Estudiante { get; set; }
        public int Id { get; set; }
        public string Tipo { get;  set; } // Protegido para que solo las clases derivadas lo establezcan  
        public DateTime Fecha { get; set; }
        public decimal? Calificacion { get; set; } // Usamos decimal? para permitir nulos si la calificación no se ha asignado  
        public string Comentarios { get; set; }
    }

    public class Examen : Evaluacion
    {
        public Examen()
        {
            Tipo = "Examen"; // Establecemos el valor de Tipo en el constructor  
        }
    }
    public class Trabajo : Evaluacion
    {
        public Trabajo()
        {
            Tipo = "Trabajo"; // Establecemos el valor de Tipo en el constructor  
        }
    }
    public class Proyecto : Evaluacion
    {
        public Proyecto()
        {
            Tipo = "Proyecto"; // Establecemos el valor de Tipo en el constructor  
        }

    }
    public class EvaluacionNegocio
    {
        // Cadena de conexión a la base de datos  
        private string connectionString = "Server=.;Database=Evaluaciones;Integrated Security=true;TrustServerCertificate=True;";

        // Método para guardar una evaluación en la base de datos  
        public string GuardarEvaluacion(Evaluacion evaluacionParaGuardar)
        {
            // Validación inicial: si la evaluación es nula, se retorna un mensaje  
            if (evaluacionParaGuardar == null)
            {
                return "No hay datos de evaluación para guardar.";
            }

            // Uso de conexión a la base de datos  
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión  
                    conn.Open();

                    // Consulta SQL para insertar una evaluación  
                    string query = "INSERT INTO Evaluacion (Estudiante, Tipo, Fecha, Calificacion, Comentario) VALUES (@Estudiante, @Tipo, @Fecha, @Calificacion, @Comentario)";

                    // Configuración del comando SQL  
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Asignación de parámetros con valores de la evaluación  
                        cmd.Parameters.AddWithValue("@Estudiante", string.IsNullOrEmpty(evaluacionParaGuardar.Estudiante) ? (object)DBNull.Value : evaluacionParaGuardar.Estudiante);
                        cmd.Parameters.AddWithValue("@Tipo", evaluacionParaGuardar.Tipo);
                        cmd.Parameters.AddWithValue("@Fecha", evaluacionParaGuardar.Fecha);
                        cmd.Parameters.AddWithValue("@Calificacion", evaluacionParaGuardar.Calificacion.HasValue ? (object)evaluacionParaGuardar.Calificacion.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Comentario", string.IsNullOrEmpty(evaluacionParaGuardar.Comentarios) ? (object)DBNull.Value : evaluacionParaGuardar.Comentarios);

                        // Ejecución del comando y obtención de filas afectadas  
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificación del resultado de la operación  
                        if (filasAfectadas > 0)
                        {
                            return "Evaluación guardada correctamente en la base de datos.";
                        }
                        else
                        {
                            return "La operación de guardado no afectó ninguna fila.";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de errores en caso de excepción SQL  
                    return $"Error al guardar la evaluación: {ex.Message}";
                }
            }
        }
    }




}
