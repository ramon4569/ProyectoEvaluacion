using System;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Text;
using Microsoft.VisualBasic;
using Microsoft.Identity.Client;
using static CapaNegocio.Proyecto;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        public string connectionString = "Server=.;Database=Evaluaciones;Integrated Security=true" + " ;TrustServerCertificate=True;"; // Aqui abro nuevamente la cadena de conexion, para que el metodo pueda acceder a la base de datos correctamente
        SqlConnection connection = new SqlConnection("Server=.;Database=Evaluaciones;Integrated Security=true" + " ;TrustServerCertificate=True;"); //
        SqlDataAdapter adapt;
        //Nota existen Metodos los cuales son obligatorios colocarlos desde el forms, para que puedan ser trabajados/invocados por el using correspondiente. 
        private void Evaluar() //Este es el metodo para mostrar la informacion de la base de datos en el DataGridView 
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Evaluacion", connection);
            adapt.Fill(dt);
            dgvEvaluaciones.DataSource = dt;
            connection.Close();
        }

        public Form1()
        {
            InitializeComponent();
            if (this.CB != null) // Comando para hacer que el ComboBox no se le pueda escribir encima
            {
                this.CB.DropDownStyle = ComboBoxStyle.DropDownList;
            }


        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {





            Evaluar();//Llamo al metodo para que al darle al boton muestre la info en la base de datos 
        }

        private void dgvEvaluaciones_CellContentClick(object sender, DataGridViewCellEventArgs e) // Esto no se usa
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un tipo de evaluaci�n en el ComboBox  
            if (CB.SelectedItem == null) { MessageBox.Show("Seleccione tipo"); return; }

            // Crear una instancia de la clase Evaluacion seg�n el tipo seleccionado  
            Evaluacion evaluacionParaGuardar = null;
            string tipoSel = CB.SelectedItem.ToString();
            if (tipoSel == "Examen") evaluacionParaGuardar = new Examen();
            else if (tipoSel == "Trabajo") evaluacionParaGuardar = new Trabajo();
            else if (tipoSel == "Proyecto") evaluacionParaGuardar = new Proyecto();
            else { MessageBox.Show("Tipo no v�lido"); return; }

            // Llenar el objeto Evaluacion con los datos ingresados en los TextBoxes y otros controles  
            evaluacionParaGuardar.Estudiante = TXTNOMBRE.Text; // Nombre del estudiante  
            evaluacionParaGuardar.Tipo = tipoSel; // Tipo de evaluaci�n  
            evaluacionParaGuardar.Fecha = FECHA.Value; // Fecha de la evaluaci�n  
            if (!string.IsNullOrWhiteSpace(TXTCALIFICACION.Text) && decimal.TryParse(TXTCALIFICACION.Text, out decimal cal))
                evaluacionParaGuardar.Calificacion = cal; // Calificaci�n si es v�lida  
            else
                evaluacionParaGuardar.Calificacion = null; // Calificaci�n nula si no es v�lida  
            evaluacionParaGuardar.Comentarios = TXTCOMENTARIO.Text; // Comentarios adicionales  

            // Verificar que el objeto Evaluacion no sea nulo antes de proceder  
            if (evaluacionParaGuardar == null)
            {
                MessageBox.Show("No hay datos de evaluaci�n para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usar la cadena de conexi�n definida en el formulario para conectarse a la base de datos  

            EvaluacionNegocio evaluacionNegocio = new EvaluacionNegocio(); // Crear una instancia de la clase EvaluacionNegocio
            evaluacionNegocio.GuardarEvaluacion(evaluacionParaGuardar); // Llamar al m�todo GuardarEvaluacion para guardar la evaluaci�n en la base de datos
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CB.Items.Add("Examen"); //Agregar elementos al ComboBox
            CB.Items.Add("Trabajo"); //
            CB.Items.Add("Proyecto"); //
            CB.SelectedIndex = 0; // Establece el primer elemento como seleccionado por defecto

        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void TXTCALIFICACION_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}

