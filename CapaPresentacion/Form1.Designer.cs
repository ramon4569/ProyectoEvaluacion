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
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(62, 36);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowHeadersWidth = 51;
            dgvEvaluaciones.Size = new Size(697, 240);
            dgvEvaluaciones.TabIndex = 0;
            dgvEvaluaciones.CellContentClick += dgvEvaluaciones_CellContentClick;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.ForeColor = Color.CornflowerBlue;
            btnMostrarDatos.Location = new Point(303, 304);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(225, 86);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.Text = "Mostrar";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarDatos);
            Controls.Add(dgvEvaluaciones);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEvaluaciones;
        private Button btnMostrarDatos;
    }
}
