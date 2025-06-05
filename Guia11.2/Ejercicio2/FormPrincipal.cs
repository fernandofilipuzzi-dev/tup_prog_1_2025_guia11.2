using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            int libreta = Convert.ToInt32(tbLibreta.Text);
            string nombre = tbNombre.Text;
            double nota = Convert.ToDouble(tbNota.Text);

            servicio.RegistrarAlumno(libreta, nombre, nota);

            tbLibreta.Clear();
            tbNombre.Clear();
            tbNota.Clear();
        }

        private void btnMostrarMaximoMinimo_Click(object sender, EventArgs e)
        {
            tbLista.Text = "";
            if (servicio.Cantidad > 0)
            {
                int idxMayorNota = servicio.CalcularAlumnoMayorNota();
                int idxMenorNota = servicio.CalcularAlumnoMenorNota();

                tbLista.Text = $@"Mayor nota:
{servicio.Libretas[idxMayorNota]} - {servicio.Nombres[idxMayorNota]} -  {servicio.Notas[idxMayorNota]}

Menor nota:
{servicio.Libretas[idxMenorNota]} - {servicio.Nombres[idxMenorNota]} -  {servicio.Notas[idxMenorNota]}";
            }
            else
            {
                tbLista.Text = "No hay alumnos registrados";
            }
        }

        private void btnMostrarPromedio_Click(object sender, EventArgs e)
        {
            if (servicio.Cantidad > 0)
            {
                tbLista.Text = $@"Promedio:
{servicio.CalcularPromedio():f2}";
            }
            else
            {
                tbLista.Text = "No hay alumnos registrados";
            }
        }

        private void btnMostrarCantidad_Click(object sender, EventArgs e)
        {
            if (servicio.Cantidad > 0)
            {
                tbLista.Text = $"{servicio.Cantidad}";
            }
            else
            {
                tbLista.Text = $"-";
            }
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            servicio.OrdenadaAlumnosPorLibreta();

            tbLista.Clear();
            for (int n = 0; n < servicio.Cantidad; n++)
            {
                tbLista.Text += @$"{ servicio.Libretas[n]} | { servicio.Nombres[n]} | { servicio.Notas[n]} 
";
            }
        }

        private void btnSuperioresAlPromedio_Click(object sender, EventArgs e)
        {
            int cantidad;
            int[] lista = servicio.ListarAlumnosSuperaronElPromedio(out cantidad);

            tbLista.Clear();
            for (int n = 0; n < cantidad; n++)
            {
                int idx = lista[n];
                tbLista.Text += @$"{servicio.Libretas[idx]} | {servicio.Nombres[idx]} | {servicio.Notas[idx]} 
";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int libreta = Convert.ToInt32(tbLibretaABuscar.Text);

            int idx = servicio.BuscarPorLibreta(libreta);

            if (idx > -1)
            {
                tbLista.Text = $@"Libreta: {servicio.Libretas[idx]} 
Nombres: {servicio.Nombres[idx]} 
Nota: {servicio.Notas[idx]} ";

            }
            else
            {
                tbLista.Text = "No existe";
            }
        }
    }
}
