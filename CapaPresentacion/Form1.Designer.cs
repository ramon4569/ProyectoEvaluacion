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
            LBLCALIFICACION = new Label();
            LBLNOMBRE = new Label();
            TXTCALIFICACION = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            TXTNOMBRE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AccessibleRole = AccessibleRole.None;
            dgvEvaluaciones.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Enabled = false;
            dgvEvaluaciones.Location = new Point(609, 24);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowHeadersWidth = 51;
            dgvEvaluaciones.Size = new Size(808, 224);
            dgvEvaluaciones.TabIndex = 0;
            dgvEvaluaciones.CellContentClick += dgvEvaluaciones_CellContentClick;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.BackColor = Color.DarkSlateGray;
            btnMostrarDatos.ForeColor = Color.Honeydew;
            btnMostrarDatos.Location = new Point(609, 343);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(808, 86);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.TabStop = false;
            btnMostrarDatos.Text = "Evaluar_Datos_Ingresados";
            btnMostrarDatos.UseVisualStyleBackColor = false;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // CB
            // 
            CB.FormattingEnabled = true;
            CB.Location = new Point(403, 228);
            CB.Name = "CB";
            CB.Size = new Size(125, 28);
            CB.TabIndex = 2;
            CB.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(609, 257);
            button1.Name = "button1";
            button1.Size = new Size(808, 78);
            button1.TabIndex = 3;
            button1.TabStop = false;
            button1.Text = "Agregar_Datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LBLFECHA
            // 
            LBLFECHA.AutoSize = true;
            LBLFECHA.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLFECHA.Location = new Point(38, 393);
            LBLFECHA.Name = "LBLFECHA";
            LBLFECHA.Size = new Size(56, 20);
            LBLFECHA.TabIndex = 4;
            LBLFECHA.Text = "FECHA";
            // 
            // LBLCOMENTARIO
            // 
            LBLCOMENTARIO.AutoSize = true;
            LBLCOMENTARIO.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLCOMENTARIO.Location = new Point(36, 324);
            LBLCOMENTARIO.Name = "LBLCOMENTARIO";
            LBLCOMENTARIO.Size = new Size(111, 20);
            LBLCOMENTARIO.TabIndex = 5;
            LBLCOMENTARIO.Text = "COMENTARIO";
            // 
            // LBLTIPO
            // 
            LBLTIPO.AutoSize = true;
            LBLTIPO.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            LBLTIPO.Location = new Point(338, 231);
            LBLTIPO.Name = "LBLTIPO";
            LBLTIPO.Size = new Size(44, 20);
            LBLTIPO.TabIndex = 6;
            LBLTIPO.Text = "TIPO";
            // 
            // TXTCOMENTARIO
            // 
            TXTCOMENTARIO.Location = new Point(169, 321);
            TXTCOMENTARIO.Name = "TXTCOMENTARIO";
            TXTCOMENTARIO.Size = new Size(125, 27);
            TXTCOMENTARIO.TabIndex = 8;
            TXTCOMENTARIO.TextChanged += TXTCOMENTARIO_TextChanged;
            // 
            // FECHA
            // 
            FECHA.Location = new Point(169, 388);
            FECHA.Name = "FECHA";
            FECHA.Size = new Size(317, 27);
            FECHA.TabIndex = 9;
            // 
            // LBLCALIFICACION
            // 
            LBLCALIFICACION.AutoSize = true;
            LBLCALIFICACION.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            LBLCALIFICACION.Location = new Point(38, 228);
            LBLCALIFICACION.Name = "LBLCALIFICACION";
            LBLCALIFICACION.Size = new Size(116, 20);
            LBLCALIFICACION.TabIndex = 11;
            LBLCALIFICACION.Text = "CALIFICACION";
            // 
            // LBLNOMBRE
            // 
            LBLNOMBRE.AutoSize = true;
            LBLNOMBRE.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            LBLNOMBRE.Location = new Point(38, 141);
            LBLNOMBRE.Name = "LBLNOMBRE";
            LBLNOMBRE.Size = new Size(75, 20);
            LBLNOMBRE.TabIndex = 12;
            LBLNOMBRE.Text = "NOMBRE";
            // 
            // TXTCALIFICACION
            // 
            TXTCALIFICACION.Location = new Point(169, 229);
            TXTCALIFICACION.Mask = "99999";
            TXTCALIFICACION.Name = "TXTCALIFICACION";
            TXTCALIFICACION.Size = new Size(125, 27);
            TXTCALIFICACION.TabIndex = 14;
            TXTCALIFICACION.ValidatingType = typeof(int);
            TXTCALIFICACION.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 24);
            label1.Name = "label1";
            label1.Size = new Size(368, 50);
            label1.TabIndex = 15;
            label1.Text = "EVALUACIONES R.A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(479, 23);
            label2.TabIndex = 16;
            label2.Text = "Donde tus datos Ingresados se venden en la oscuridad";
            // 
            // TXTNOMBRE
            // 
            TXTNOMBRE.AccessibleRole = AccessibleRole.None;
            TXTNOMBRE.Location = new Point(169, 141);
            TXTNOMBRE.Name = "TXTNOMBRE";
            TXTNOMBRE.Size = new Size(125, 27);
            TXTNOMBRE.TabIndex = 13;
            TXTNOMBRE.TextChanged += TXTNOMBRE_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1475, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXTCALIFICACION);
            Controls.Add(TXTNOMBRE);
            Controls.Add(LBLNOMBRE);
            Controls.Add(LBLCALIFICACION);
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
        
        private Label LBLCALIFICACION;
        private Label LBLNOMBRE;
        private MaskedTextBox TXTCALIFICACION;
        private Label label1;
        private Label label2;
        private TextBox TXTNOMBRE;
    }
}
