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
    public partial class FormCrearCosecha : Form
    {
        private readonly ApiService _apiService;
        private string _productoId;

        public FormCrearCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        public FormCrearCosecha(string productoId) : this()
        {
            _productoId = productoId;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var cosecha = new Cosecha
                {
                    ProductoId = _productoId,
                    FechaCosecha = dtpFecha.Value,
                    CantidadRecolectada = (int)numCantidad.Value,
                    CalidadProducto = txtCalidad.Text
                };

                var creado = await _apiService.CrearCosechaAsync(cosecha);
                if (creado != null)
                {
                    MessageHelper.ShowSuccess("Cosecha creada correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al crear cosecha:");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormCrearCosecha_Load(object sender, EventArgs e)
        {

        }
    }
}
