namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>  
        ///  Required designer variable.  
        /// </summary>  
        private System.ComponentModel.IContainer components = null;

        /// <summary>  
        ///  Clean up any resources being used.  
        /// </summary>  
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>  
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code  

        /// <summary>  
        ///  Required method for Designer support - do not modify  
        ///  the contents of this method with the code editor.  
        /// </summary>  
        private void InitializeComponent()
        {
            dgvEvaluaciones = new DataGridView();
            btnMostrarDatos = new Button();
            CB = new ComboBox();
            button1 = new Button();
            LBLFECHA = new Label();
            LBLCOMENTARIO = new Label();
            LBLTIPO = new Label();
            TXTCOMENTARIO = new TextBox();
            FECHA = new DateTimePicker();
            TXTCALIFICACION = new TextBox();
            LBLCALIFICACION = new Label();
            LBLNOMBRE = new Label();
            TXTNOMBRE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AccessibleRole = AccessibleRole.None;
            dgvEvaluaciones.BackgroundColor = Color.Lavender;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Enabled = false;
            dgvEvaluaciones.Location = new Point(297, 12);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowHeadersWidth = 51;
            dgvEvaluaciones.Size = new Size(893, 224);
            dgvEvaluaciones.TabIndex = 0;
            dgvEvaluaciones.CellContentClick += dgvEvaluaciones_CellContentClick;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.BackColor = Color.GhostWhite;
            btnMostrarDatos.ForeColor = Color.DarkSlateGray;
            btnMostrarDatos.Location = new Point(297, 338);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(893, 86);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.Text = "Evaluar_Datos_Ingresados";
            btnMostrarDatos.UseVisualStyleBackColor = false;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // CB
            // 
            CB.FormattingEnabled = true;
            CB.Location = new Point(139, 149);
            CB.Name = "CB";
            CB.Size = new Size(125, 28);
            CB.TabIndex = 2;
            CB.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(297, 254);
            button1.Name = "button1";
            button1.Size = new Size(893, 78);
            button1.TabIndex = 3;
            button1.Text = "Agregar_Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LBLFECHA
            // 
            LBLFECHA.AutoSize = true;
            LBLFECHA.Location = new Point(28, 229);
            LBLFECHA.Name = "LBLFECHA";
            LBLFECHA.Size = new Size(54, 20);
            LBLFECHA.TabIndex = 4;
            LBLFECHA.Text = "FECHA";
            // 
            // LBLCOMENTARIO
            // 
            LBLCOMENTARIO.AutoSize = true;
            LBLCOMENTARIO.Location = new Point(28, 343);
            LBLCOMENTARIO.Name = "LBLCOMENTARIO";
            LBLCOMENTARIO.Size = new Size(102, 20);
            LBLCOMENTARIO.TabIndex = 5;
            LBLCOMENTARIO.Text = "COMENTARIO";
            // 
            // LBLTIPO
            // 
            LBLTIPO.AutoSize = true;
            LBLTIPO.Location = new Point(28, 149);
            LBLTIPO.Name = "LBLTIPO";
            LBLTIPO.Size = new Size(40, 20);
            LBLTIPO.TabIndex = 6;
            LBLTIPO.Text = "TIPO";
            // 
            // TXTCOMENTARIO
            // 
            TXTCOMENTARIO.Location = new Point(139, 340);
            TXTCOMENTARIO.Name = "TXTCOMENTARIO";
            TXTCOMENTARIO.Size = new Size(125, 27);
            TXTCOMENTARIO.TabIndex = 8;
            // 
            // FECHA
            // 
            FECHA.Location = new Point(139, 224);
            FECHA.Name = "FECHA";
            FECHA.Size = new Size(125, 27);
            FECHA.TabIndex = 9;
            // 
            // TXTCALIFICACION
            // 
            TXTCALIFICACION.Location = new Point(139, 276);
            TXTCALIFICACION.Name = "TXTCALIFICACION";
            TXTCALIFICACION.Size = new Size(125, 27);
            TXTCALIFICACION.TabIndex = 10;
            // 
            // LBLCALIFICACION
            // 
            LBLCALIFICACION.AutoSize = true;
            LBLCALIFICACION.Location = new Point(26, 283);
            LBLCALIFICACION.Name = "LBLCALIFICACION";
            LBLCALIFICACION.Size = new Size(104, 20);
            LBLCALIFICACION.TabIndex = 11;
            LBLCALIFICACION.Text = "CALIFICACION";
            // 
            // LBLNOMBRE
            // 
            LBLNOMBRE.AutoSize = true;
            LBLNOMBRE.Location = new Point(28, 81);
            LBLNOMBRE.Name = "LBLNOMBRE";
            LBLNOMBRE.Size = new Size(70, 20);
            LBLNOMBRE.TabIndex = 12;
            LBLNOMBRE.Text = "NOMBRE";
            // 
            // TXTNOMBRE
            // 
            TXTNOMBRE.Location = new Point(139, 81);
            TXTNOMBRE.Name = "TXTNOMBRE";
            TXTNOMBRE.Size = new Size(125, 27);
            TXTNOMBRE.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 450);
            Controls.Add(TXTNOMBRE);
            Controls.Add(LBLNOMBRE);
            Controls.Add(LBLCALIFICACION);
            Controls.Add(TXTCALIFICACION);
            Controls.Add(FECHA);
            Controls.Add(TXTCOMENTARIO);
            Controls.Add(LBLTIPO);
            Controls.Add(LBLCOMENTARIO);
            Controls.Add(LBLFECHA);
            Controls.Add(button1);
            Controls.Add(CB);
            Controls.Add(btnMostrarDatos);
            Controls.Add(dgvEvaluaciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEvaluaciones;
        private Button btnMostrarDatos;
        private ComboBox CB;
        private Button button1;
        private Label LBLFECHA;
        private Label LBLCOMENTARIO;
        private Label LBLTIPO;
        private TextBox TXTCOMENTARIO;
        private DateTimePicker FECHA;
        private TextBox TXTCALIFICACION;
        private Label LBLCALIFICACION;
        private Label LBLNOMBRE;
        private TextBox TXTNOMBRE;
    }
}
