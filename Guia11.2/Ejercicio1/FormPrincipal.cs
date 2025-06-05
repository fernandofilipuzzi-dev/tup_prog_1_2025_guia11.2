using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarValor_Click(object sender, EventArgs e)
        {

            int valor = Convert.ToInt32(tbValor.Text);
            servicio.RegistrarValor(valor);

            tbValor.Clear();
        }

        private void btnMostrarMaximoMinimo_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbMaximo.Text = $"{servicio.CalcularMaximo()}";
                lbMinimo.Text = $"{servicio.CalcularMinimo()}";
            }
            else
            {
                lbMaximo.Text = $"-";
                lbMinimo.Text = $"-";
            }
        }

        private void btnMostrarPromedio_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbPromedio.Text = $"{servicio.CalcularPromedio():f2}";
            }
            else
            {
                lbPromedio.Text = $"-";
            }
        }

        private void btnMostrarCantidad_Click(object sender, EventArgs e)
        {
            if (servicio.Contador > 0)
            {
                lbCantidad.Text = $"{servicio.Contador}";
            }
            else
            {
                lbCantidad.Text = $"-";
            }
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            servicio.OrdenarLista();

            tbLista.Clear();
            for (int n = 0; n < servicio.Contador; n++)
            {
                tbLista.Text += $"{servicio.Lista[n],4}\n";
            }
        }

        private void btnSuperioresAlPromedio_Click(object sender, EventArgs e)
        {
            int cantidad;
            int[] lista = servicio.ListaSuperioresAlPromedio(out cantidad);

            tbLista.Clear();
            for (int n = 0; n < cantidad; n++)
            {
                tbLista.Text += $"{lista[n],4}";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbNumeroBuscar.Text);

            int idx = servicio.BuscarValor(valor);

            if (idx > -1)
            {
                lbResultado.Text= $"Existe! posición:{idx}";
            }
            else
            {
                lbResultado.Text = "No existe";
            }
        }
    }
}
