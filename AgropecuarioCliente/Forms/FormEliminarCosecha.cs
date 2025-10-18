using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormEliminarCosecha : Form
    {
        private readonly ApiService _apiService;
        private string _cosechaId;

        public FormEliminarCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        public void SetCosechaId(string id)
        {
            _cosechaId = id;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_cosechaId))
            {
                MessageHelper.ShowWarning("No hay cosecha seleccionada.");
                return;
            }

            try
            {
                bool ok = await _apiService.EliminarCosechaAsync(_cosechaId);
                if (ok)
                {
                    MessageHelper.ShowSuccess("Cosecha eliminada correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageHelper.ShowError("No se pudo eliminar la cosecha.");
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al eliminar cosecha:");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
