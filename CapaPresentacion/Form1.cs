using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using static CapaNegocio.Examen.Proyecto;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Text;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private EvaluacionDAL evaluacionDAL;
        public string connectionString = "Server=.;Database=Evaluaciones;Integrated Security=true" + " ;TrustServerCertificate=True;"; // Reemplaza esto
        SqlConnection connection = new SqlConnection("Server=.;Database=Evaluaciones;Integrated Security=true" + " ;TrustServerCertificate=True;"); // Reemplaza esto
        SqlDataAdapter adapt;

        private void MostrarInfo()
        {

            connection.Open();
            DataTable dataTable = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Evaluacion", connection);
            adapt.Fill(dataTable); 
            dgvEvaluaciones.DataSource = dataTable; 
            connection.Close();



        } 
        public Form1()
        {
            InitializeComponent();
            evaluacionDAL = new EvaluacionDAL();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {

           
            
            try
            {
                // Llamamos al método de la capa de datos para obtener todas las evaluaciones
                Evaluacion[] listaDeEvaluaciones = evaluacionDAL.ObtenerTodasLasEvaluaciones();

                // Asignamos el resultado como el origen de datos del DataGridView
                // Asegúrate de que tu DataGridView se llame 'dgvEvaluaciones' en el diseñador.
                dgvEvaluaciones.DataSource = listaDeEvaluaciones;

                // Opcional: Configurar encabezados de columnas para que se vean mejor
                // (Asegúrate de que las propiedades de tus objetos Evaluacion coincidan con estos nombres)
                if (dgvEvaluaciones.Columns["Id"] != null)
                    dgvEvaluaciones.Columns["Id"].HeaderText = "ID";

                if (dgvEvaluaciones.Columns["Tipo"] != null)
                    dgvEvaluaciones.Columns["Tipo"].HeaderText = "Tipo de Evaluación";

                if (dgvEvaluaciones.Columns["Fecha"] != null)
                    dgvEvaluaciones.Columns["Fecha"].HeaderText = "Fecha";

                if (dgvEvaluaciones.Columns["Calificacion"] != null)
                    dgvEvaluaciones.Columns["Calificacion"].HeaderText = "Calificación";

                if (dgvEvaluaciones.Columns["Comentarios"] != null)
                    dgvEvaluaciones.Columns["Comentarios"].HeaderText = "Comentarios";


                // Opcional: Mostrar un mensaje de éxito
                MessageBox.Show("Datos cargados exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar un mensaje al usuario
                MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            MostrarInfo();
        }

        private void dgvEvaluaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
