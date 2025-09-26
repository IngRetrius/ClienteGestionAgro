using System;
using System.Windows.Forms;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Eventos de botones principales
        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormListar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormCrear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormBuscar();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MessageHelper.ShowWarning("Funcionalidad de estadísticas en desarrollo.");
        }

        // Eventos del menú
        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormListar();
        }

        private void crearProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormCrear();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormBuscar();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageHelper.ShowWarning("Funcionalidad de estadísticas en desarrollo.");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormAcercaDe();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirmation("¿Está seguro que desea salir de la aplicación?"))
            {
                Application.Exit();
            }
        }

        // Métodos para abrir formularios
        private void AbrirFormListar()
        {
            try
            {
                var formListar = new FormListarProductos();
                formListar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario: {ex.Message}");
            }
        }

        private void AbrirFormCrear()
        {
            try
            {
                MessageHelper.ShowWarning("Formulario de crear en desarrollo.");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario: {ex.Message}");
            }
        }

        private void AbrirFormBuscar()
        {
            try
            {
                MessageHelper.ShowWarning("Formulario de buscar en desarrollo.");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario: {ex.Message}");
            }
        }

        private void AbrirFormAcercaDe()
        {
            try
            {
                var formAcercaDe = new FormAcercaDe();
                formAcercaDe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al abrir el formulario: {ex.Message}");
            }
        }
    }
}