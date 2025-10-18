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
    public partial class FormBuscarCosecha : Form
    {
        private readonly ApiService _apiService;
        private List<Cosecha> _resultados;

        public FormBuscarCosecha()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _resultados = new List<Cosecha>();
        }

        private void FormBuscarCosecha_Load(object sender, EventArgs e)
        {
            // inicial
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var term = txtBusqueda.Text.Trim();
                if (string.IsNullOrEmpty(term))
                {
                    _resultados = await _apiService.ObtenerTodasCosechasAsync();
                }
                else
                {
                    // intentar por id o productoId
                    var byId = await _apiService.ObtenerCosechaPorIdAsync(term);
                    if (byId != null)
                    {
                        _resultados = new List<Cosecha> { byId };
                    }
                    else
                    {
                        // buscar por productoId
                        var porProducto = await _apiService.ObtenerCosechasPorProductoAsync(term);
                        _resultados = porProducto ?? new List<Cosecha>();
                    }
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _resultados;
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError(ex, "Error al buscar cosechas:");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            dataGridView1.DataSource = null;
            _resultados.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
