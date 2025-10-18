using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormActualizarCosecha : Form
    {
        private readonly ApiService _apiService;
        private Cosecha _cosechaSeleccionada;

        public FormActualizarCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        public void CargarCosecha(Cosecha c)
        {
            _cosechaSeleccionada = c;
            if (c != null)
            {
                dtpFecha.Value = c.FechaCosecha;
                numCantidad.Value = c.CantidadRecolectada;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_cosechaSeleccionada == null)
            {
                MessageHelper.ShowWarning("No hay cosecha seleccionada.");
                return;
            }

            try
            {
                _cosechaSeleccionada.FechaCosecha = dtpFecha.Value;
                _cosechaSeleccionada.CantidadRecolectada = (int)numCantidad.Value;

                var actualizado = await _apiService.ActualizarCosechaAsync(_cosechaSeleccionada.Id, _cosechaSeleccionada);
                if (actualizado != null)
                {
                    MessageHelper.ShowSuccess("Cosecha actualizada correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al actualizar cosecha:");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormActualizarCosecha_Load(object sender, EventArgs e)
        {
            // opcional: inicializaciones
        }
    }
}
