using System;
using Microsoft.Data.SqlClient;
using System.Collections;


namespace CapaNegocio
{
    public class Evaluacion
    {
        public int Id { get; set; }
        public string Tipo { get; protected set; } // Protegido para que solo las clases derivadas lo establezcan
        public DateTime Fecha { get; set; }
        public decimal? Calificacion { get; set; } // Usamos decimal? para permitir nulos si la calificación no se ha asignado
        public string Comentarios { get; set; }

        // Constructor base
        protected Evaluacion(string tipo)
        {
            Tipo = tipo;
            Fecha = DateTime.Today; // Valor por defecto, se puede cambiar
        }

        // Método virtual que las clases derivadas pueden sobrescribir
        public virtual string Evaluar()
        {
            return $"Evaluación base para {Tipo}. Calificación: {Calificacion?.ToString() ?? "N/A"}";
        }

        // Podríamos añadir más métodos comunes aquí
    }

    public class Examen : Evaluacion
    {
        // Podría tener propiedades específicas del examen, si las hubiera
        // public int NumeroDePreguntas { get; set; }

        public Examen() : base("Examen") { }

        // Sobrescritura del método Evaluar
        public override string Evaluar()
        {
            // Lógica específica para evaluar un examen
            return $"Evaluación de Examen. Fecha: {Fecha.ToShortDateString()}, Calificación: {Calificacion?.ToString() ?? "Pendiente"}. Comentarios: {Comentarios}";
        }
        public class Trabajo : Evaluacion
        {
            // Podría tener propiedades específicas del trabajo
            // public string Tema { get; set; }
            // public DateTime FechaEntregaEsperada { get; set; }

            public Trabajo() : base("Trabajo") { }

            public override string Evaluar()
            {
                return $"Evaluación de Trabajo. Fecha: {Fecha.ToShortDateString()}, Calificación: {Calificacion?.ToString() ?? "Pendiente"}. Comentarios: {Comentarios}";
            }
        }
        public class Proyecto : Evaluacion
        {
            // Podría tener propiedades específicas del proyecto
            // public string FasesDelProyecto { get; set; }

            public Proyecto() : base("Proyecto") { }

            public override string Evaluar()
            {
                return $"Evaluación de Proyecto. Fecha: {Fecha.ToShortDateString()}, Calificación: {Calificacion?.ToString() ?? "Pendiente"}. Comentarios: {Comentarios}";
            }


            public class EvaluacionDAL
            {
                // Reemplaza con tu cadena de conexión correcta.
                // Asegúrate de que esta variable esté definida en tu clase.
                private string connectionString = "Server=NOMBRE_DE_TU_SERVIDOR;Database=Evaluaciones;Integrated Security=True;";
                // Ejemplo: private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Evaluaciones;Integrated Security=True;";


                // Constructor (opcional, pero bueno para inicializar si es necesario)

                public Evaluacion[] ObtenerTodasLasEvaluaciones()
                {
                    ArrayList evaluacionesTemp = new ArrayList();

                    // Usar 'using' asegura que la conexión se cierre incluso si hay errores
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT id, Tipo, Fecha, Calificacion, Comentario FROM Evaluacion";
                        SqlCommand command = new SqlCommand(query, connection);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string tipo = reader["Tipo"].ToString();
                                Evaluacion evaluacion = null;

                                // Creamos la instancia correcta según el tipo
                                switch (tipo)
                                {
                                    case "Examen":
                                        evaluacion = new Examen();
                                        break;
                                    case "Trabajo":
                                        evaluacion = new Trabajo();
                                        break;
                                    case "Proyecto":
                                        evaluacion = new Proyecto();
                                        break;
                                    default:
                                        Console.WriteLine($"Tipo de evaluación desconocido: {tipo}");
                                        continue; // Saltar este registro y continuar con el siguiente
                                }

                                evaluacion.Id = Convert.ToInt32(reader["id"]);
                                // 'Tipo' ya está establecido por el constructor de la clase derivada (Examen, Trabajo, Proyecto)
                                evaluacion.Fecha = Convert.ToDateTime(reader["Fecha"]);

                                // Manejar Calificacion que puede ser DBNull
                                if (reader["Calificacion"] != DBNull.Value)
                                {
                                    evaluacion.Calificacion = Convert.ToDecimal(reader["Calificacion"]);
                                }
                                else
                                {
                                    evaluacion.Calificacion = null;
                                }

                                // Manejar Comentario que puede ser DBNull
                                if (reader["Comentario"] != DBNull.Value)
                                {
                                    evaluacion.Comentarios = reader["Comentario"].ToString();
                                }
                                else
                                {
                                    evaluacion.Comentarios = string.Empty; // O null, según prefieras
                                }

                                evaluacionesTemp.Add(evaluacion);
                            }
                            reader.Close();
                        }
                        catch (SqlException ex) // Es buena práctica capturar excepciones específicas
                        {
                            // Manejar la excepción específica de SQL (ej. loguearla, mostrar un mensaje amigable)
                            Console.WriteLine("Error de SQL al obtener evaluaciones: " + ex.Message);
                            // Podrías lanzar la excepción de nuevo si quieres que la capa superior la maneje:
                            // throw;
                        }
                        catch (Exception ex) // Capturar otras excepciones generales
                        {
                            // Manejar otras excepciones (ej. loguearla, mostrar un mensaje)
                            Console.WriteLine("Error general al obtener evaluaciones: " + ex.Message);
                            // throw;
                        }
                    }

                    // Convertir el ArrayList a un array de Evaluacion[]
                    Evaluacion[] resultado = new Evaluacion[evaluacionesTemp.Count];
                    if (evaluacionesTemp.Count > 0) // Asegurarse de que hay elementos antes de copiar
                    {
                        evaluacionesTemp.CopyTo(resultado);
                    }

                    return resultado;
                }

                // ... (Aquí irían los otros métodos como AgregarEvaluacion, etc.)
            }
        }
    }

}
