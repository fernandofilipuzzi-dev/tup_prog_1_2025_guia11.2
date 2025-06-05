namespace Ejercicio1
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
            btnRegistrarValor = new Button();
            label1 = new Label();
            tbValor = new TextBox();
            groupBox2 = new GroupBox();
            btnMostrarMaximoMinimo = new Button();
            lbMinimo = new Label();
            lbMaximo = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnMostrarPromedio = new Button();
            lbPromedio = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            btnMostrarCantidad = new Button();
            lbCantidad = new Label();
            label8 = new Label();
            groupBox5 = new GroupBox();
            btnSuperioresAlPromedio = new Button();
            btnListaOrdenada = new Button();
            tbLista = new TextBox();
            tbNumeroBuscar = new TextBox();
            btnBuscar = new Button();
            label5 = new Label();
            groupBox6 = new GroupBox();
            lbResultado = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarValor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbValor);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(438, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar un número";
            // 
            // btnRegistrarValor
            // 
            btnRegistrarValor.Location = new Point(125, 78);
            btnRegistrarValor.Name = "btnRegistrarValor";
            btnRegistrarValor.Size = new Size(172, 40);
            btnRegistrarValor.TabIndex = 5;
            btnRegistrarValor.Text = "Registrar número";
            btnRegistrarValor.UseVisualStyleBackColor = true;
            btnRegistrarValor.Click += btnRegistrarValor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un número";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(208, 37);
            tbValor.Margin = new Padding(4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 29);
            tbValor.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMostrarMaximoMinimo);
            groupBox2.Controls.Add(lbMinimo);
            groupBox2.Controls.Add(lbMaximo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(13, 148);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(438, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procesar máximo y mínimo";
            // 
            // btnMostrarMaximoMinimo
            // 
            btnMostrarMaximoMinimo.Location = new Point(269, 46);
            btnMostrarMaximoMinimo.Name = "btnMostrarMaximoMinimo";
            btnMostrarMaximoMinimo.Size = new Size(125, 40);
            btnMostrarMaximoMinimo.TabIndex = 4;
            btnMostrarMaximoMinimo.Text = "Actualizar";
            btnMostrarMaximoMinimo.UseVisualStyleBackColor = true;
            btnMostrarMaximoMinimo.Click += btnMostrarMaximoMinimo_Click;
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.BackColor = SystemColors.ActiveCaption;
            lbMinimo.Location = new Point(138, 74);
            lbMinimo.Margin = new Padding(4, 0, 4, 0);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(77, 21);
            lbMinimo.TabIndex = 3;
            lbMinimo.Text = "lbMinimo";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.BackColor = SystemColors.ActiveCaption;
            lbMaximo.Location = new Point(138, 35);
            lbMaximo.Margin = new Padding(4, 0, 4, 0);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(79, 21);
            lbMaximo.TabIndex = 2;
            lbMaximo.Text = "lbMaximo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 1;
            label3.Text = "Valor mínimo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 0;
            label2.Text = "Valor máximo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnMostrarPromedio);
            groupBox3.Controls.Add(lbPromedio);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(13, 267);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(438, 79);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesar promedio";
            // 
            // btnMostrarPromedio
            // 
            btnMostrarPromedio.Location = new Point(269, 29);
            btnMostrarPromedio.Name = "btnMostrarPromedio";
            btnMostrarPromedio.Size = new Size(125, 40);
            btnMostrarPromedio.TabIndex = 5;
            btnMostrarPromedio.Text = "Actualizar";
            btnMostrarPromedio.UseVisualStyleBackColor = true;
            btnMostrarPromedio.Click += btnMostrarPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(136, 41);
            lbPromedio.Margin = new Padding(4, 0, 4, 0);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(91, 21);
            lbPromedio.TabIndex = 1;
            lbPromedio.Text = "lbPromedio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 41);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 0;
            label6.Text = "Promedio:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnMostrarCantidad);
            groupBox4.Controls.Add(lbCantidad);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(13, 354);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(438, 93);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar Cantidad de ingresados";
            // 
            // btnMostrarCantidad
            // 
            btnMostrarCantidad.Location = new Point(269, 33);
            btnMostrarCantidad.Name = "btnMostrarCantidad";
            btnMostrarCantidad.Size = new Size(125, 40);
            btnMostrarCantidad.TabIndex = 6;
            btnMostrarCantidad.Text = "Actualizar";
            btnMostrarCantidad.UseVisualStyleBackColor = true;
            btnMostrarCantidad.Click += btnMostrarCantidad_Click;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(138, 43);
            lbCantidad.Margin = new Padding(4, 0, 4, 0);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(85, 21);
            lbCantidad.TabIndex = 6;
            lbCantidad.Text = "lbCantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 43);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 1;
            label8.Text = "Cantidad:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnSuperioresAlPromedio);
            groupBox5.Controls.Add(btnListaOrdenada);
            groupBox5.Controls.Add(tbLista);
            groupBox5.Location = new Point(467, 148);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(266, 299);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Mostrar Cantidad de ingresados";
            // 
            // btnSuperioresAlPromedio
            // 
            btnSuperioresAlPromedio.Location = new Point(148, 119);
            btnSuperioresAlPromedio.Name = "btnSuperioresAlPromedio";
            btnSuperioresAlPromedio.Size = new Size(108, 109);
            btnSuperioresAlPromedio.TabIndex = 9;
            btnSuperioresAlPromedio.Text = "Mostrar Lista Superior al promedio";
            btnSuperioresAlPromedio.UseVisualStyleBackColor = true;
            btnSuperioresAlPromedio.Click += btnSuperioresAlPromedio_Click;
            // 
            // btnListaOrdenada
            // 
            btnListaOrdenada.Location = new Point(148, 29);
            btnListaOrdenada.Name = "btnListaOrdenada";
            btnListaOrdenada.Size = new Size(108, 84);
            btnListaOrdenada.TabIndex = 8;
            btnListaOrdenada.Text = "Mostrar Lista Ordenada";
            btnListaOrdenada.UseVisualStyleBackColor = true;
            btnListaOrdenada.Click += btnListaOrdenada_Click;
            // 
            // tbLista
            // 
            tbLista.Location = new Point(7, 29);
            tbLista.Margin = new Padding(4);
            tbLista.Multiline = true;
            tbLista.Name = "tbLista";
            tbLista.Size = new Size(134, 257);
            tbLista.TabIndex = 7;
            // 
            // tbNumeroBuscar
            // 
            tbNumeroBuscar.Location = new Point(83, 58);
            tbNumeroBuscar.Margin = new Padding(4);
            tbNumeroBuscar.Name = "tbNumeroBuscar";
            tbNumeroBuscar.Size = new Size(51, 29);
            tbNumeroBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(148, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 40);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 33);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 1;
            label5.Text = "Valor a buscar:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbResultado);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(tbNumeroBuscar);
            groupBox6.Controls.Add(btnBuscar);
            groupBox6.Location = new Point(467, 13);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(266, 127);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.BackColor = SystemColors.ActiveCaption;
            lbResultado.Location = new Point(83, 91);
            lbResultado.Margin = new Padding(4, 0, 4, 0);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(111, 21);
            lbResultado.TabIndex = 7;
            lbResultado.Text = "Valor a buscar:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 451);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Ejercicio 1. Introducción";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbValor;
        private GroupBox groupBox2;
        private Label lbMinimo;
        private Label lbMaximo;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label lbPromedio;
        private Label label6;
        private GroupBox groupBox4;
        private Button btnMostrarMaximoMinimo;
        private Button btnMostrarPromedio;
        private Label lbCantidad;
        private Label label8;
        private Button btnRegistrarValor;
        private Button btnMostrarCantidad;
        private GroupBox groupBox5;
        private Button btnListaOrdenada;
        private TextBox tbLista;
        private TextBox tbNumeroBuscar;
        private Button btnBuscar;
        private Label label5;
        private Button btnSuperioresAlPromedio;
        private GroupBox groupBox6;
        private Label lbResultado;
    }
}
