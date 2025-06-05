namespace Ejercicio2
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            tbNota = new TextBox();
            tbNombre = new TextBox();
            btnRegistrarAlumno = new Button();
            label1 = new Label();
            tbLibreta = new TextBox();
            groupBox2 = new GroupBox();
            btnSuperioresAlPromedio = new Button();
            label5 = new Label();
            btnMostrarPromedio = new Button();
            btnBuscar = new Button();
            tbLibretaABuscar = new TextBox();
            btnListaOrdenada = new Button();
            btnMostrarCantidad = new Button();
            btnMostrarMaximoMinimo = new Button();
            tbLista = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbNota);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(btnRegistrarAlumno);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbLibreta);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(438, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de alumno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 102);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 9;
            label7.Text = "Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 66);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // tbNota
            // 
            tbNota.Location = new Point(96, 99);
            tbNota.Margin = new Padding(4);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(92, 29);
            tbNota.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(96, 62);
            tbNombre.Margin = new Padding(4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(224, 29);
            tbNombre.TabIndex = 6;
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.Location = new Point(327, 44);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.Size = new Size(99, 65);
            btnRegistrarAlumno.TabIndex = 5;
            btnRegistrarAlumno.Text = "Registrar";
            btnRegistrarAlumno.UseVisualStyleBackColor = true;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "Libreta";
            // 
            // tbLibreta
            // 
            tbLibreta.Location = new Point(96, 25);
            tbLibreta.Margin = new Padding(4);
            tbLibreta.Name = "tbLibreta";
            tbLibreta.Size = new Size(127, 29);
            tbLibreta.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSuperioresAlPromedio);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnMostrarPromedio);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(tbLibretaABuscar);
            groupBox2.Controls.Add(btnListaOrdenada);
            groupBox2.Controls.Add(btnMostrarCantidad);
            groupBox2.Controls.Add(btnMostrarMaximoMinimo);
            groupBox2.Controls.Add(tbLista);
            groupBox2.Location = new Point(13, 162);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(438, 448);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procesos";
            // 
            // btnSuperioresAlPromedio
            // 
            btnSuperioresAlPromedio.Location = new Point(274, 341);
            btnSuperioresAlPromedio.Name = "btnSuperioresAlPromedio";
            btnSuperioresAlPromedio.Size = new Size(139, 86);
            btnSuperioresAlPromedio.TabIndex = 9;
            btnSuperioresAlPromedio.Text = "Mostrar Lista Superior al promedio";
            btnSuperioresAlPromedio.UseVisualStyleBackColor = true;
            btnSuperioresAlPromedio.Click += btnSuperioresAlPromedio_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 1;
            label5.Text = "Libreta";
            // 
            // btnMostrarPromedio
            // 
            btnMostrarPromedio.Location = new Point(274, 213);
            btnMostrarPromedio.Name = "btnMostrarPromedio";
            btnMostrarPromedio.Size = new Size(139, 57);
            btnMostrarPromedio.TabIndex = 5;
            btnMostrarPromedio.Text = "Promedio";
            btnMostrarPromedio.UseVisualStyleBackColor = true;
            btnMostrarPromedio.Click += btnMostrarPromedio_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(234, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbLibretaABuscar
            // 
            tbLibretaABuscar.Location = new Point(109, 34);
            tbLibretaABuscar.Margin = new Padding(4);
            tbLibretaABuscar.Name = "tbLibretaABuscar";
            tbLibretaABuscar.Size = new Size(106, 29);
            tbLibretaABuscar.TabIndex = 6;
            // 
            // btnListaOrdenada
            // 
            btnListaOrdenada.Location = new Point(274, 276);
            btnListaOrdenada.Name = "btnListaOrdenada";
            btnListaOrdenada.Size = new Size(139, 59);
            btnListaOrdenada.TabIndex = 8;
            btnListaOrdenada.Text = "Mostrar Lista Ordenada";
            btnListaOrdenada.UseVisualStyleBackColor = true;
            btnListaOrdenada.Click += btnListaOrdenada_Click;
            // 
            // btnMostrarCantidad
            // 
            btnMostrarCantidad.Location = new Point(274, 149);
            btnMostrarCantidad.Name = "btnMostrarCantidad";
            btnMostrarCantidad.Size = new Size(139, 58);
            btnMostrarCantidad.TabIndex = 6;
            btnMostrarCantidad.Text = "Cantidad de Alumnos";
            btnMostrarCantidad.UseVisualStyleBackColor = true;
            btnMostrarCantidad.Click += btnMostrarCantidad_Click;
            // 
            // btnMostrarMaximoMinimo
            // 
            btnMostrarMaximoMinimo.Location = new Point(274, 80);
            btnMostrarMaximoMinimo.Name = "btnMostrarMaximoMinimo";
            btnMostrarMaximoMinimo.Size = new Size(139, 63);
            btnMostrarMaximoMinimo.TabIndex = 4;
            btnMostrarMaximoMinimo.Text = "Alumno mayor y menor nota";
            btnMostrarMaximoMinimo.UseVisualStyleBackColor = true;
            btnMostrarMaximoMinimo.Click += btnMostrarMaximoMinimo_Click;
            // 
            // tbLista
            // 
            tbLista.Location = new Point(21, 80);
            tbLista.Margin = new Padding(4);
            tbLista.Multiline = true;
            tbLista.Name = "tbLista";
            tbLista.Size = new Size(246, 357);
            tbLista.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 612);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Ejercicio 2. Arreglos con índice compartido";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbLibreta;
        private GroupBox groupBox2;
        private Button btnMostrarMaximoMinimo;
        private Button btnMostrarPromedio;
        private Button btnRegistrarAlumno;
        private Button btnMostrarCantidad;
        private Button btnListaOrdenada;
        private TextBox tbLista;
        private TextBox tbLibretaABuscar;
        private Button btnBuscar;
        private Label label5;
        private Button btnSuperioresAlPromedio;
        private TextBox tbNota;
        private TextBox tbNombre;
        private Label label7;
        private Label label4;
    }
}
