using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormListarProductos : Form
    {
        private readonly ApiService _apiService;
        private List<ProductoAgricola> _todosLosProductos;
        private List<ProductoAgricola> _productosFiltrados;

        public FormListarProductos()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _todosLosProductos = new List<ProductoAgricola>();
            _productosFiltrados = new List<ProductoAgricola>();
        }

        private async void FormListarProductos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarComboBoxes();
            await CargarProductos();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TipoCultivo",
                HeaderText = "Tipo de Cultivo",
                DataPropertyName = "TipoCultivo",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HectareasCultivadas",
                HeaderText = "Hectáreas",
                DataPropertyName = "HectareasCultivadas",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadProducida",
                HeaderText = "Cantidad Producida",
                DataPropertyName = "CantidadProducida",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioVenta",
                HeaderText = "Precio Venta",
                DataPropertyName = "PrecioVenta",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Temporada",
                HeaderText = "Temporada",
                DataPropertyName = "Temporada",
                Width = 150
            });
        }

        private void CargarComboBoxes()
        {
            cmbTipoCultivo.Items.Clear();
            cmbTipoCultivo.Items.Add("-- Todos --");
            cmbTipoCultivo.Items.AddRange(new string[]
            {
                "Café", "Arroz", "Cacao", "Mango", "Aguacate",
                "Cítricos", "Maracuyá", "Sorgo", "Algodón", "Plátano"
            });
            cmbTipoCultivo.SelectedIndex = 0;

            cmbTemporada.Items.Clear();
            cmbTemporada.Items.Add("-- Todas --");
            cmbTemporada.Items.AddRange(new string[]
            {
                "Todo el año", "Temporada seca", "Temporada lluviosa",
                "Cosecha principal", "Cosecha mitaca", "Temporada alta", "Temporada baja"
            });
            cmbTemporada.SelectedIndex = 0;
        }

        private async System.Threading.Tasks.Task CargarProductos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _todosLosProductos = await _apiService.ObtenerTodosAsync();
                _productosFiltrados = new List<ProductoAgricola>(_todosLosProductos);

                ActualizarDataGridView();
                ActualizarContadorRegistros();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al cargar los productos:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _productosFiltrados;
            dataGridView1.Refresh();
        }

        private void ActualizarContadorRegistros()
        {
            lblTotalRegistros.Text = $"Total de registros: {_productosFiltrados.Count}";
        }

        private void AplicarFiltros()
        {
            _productosFiltrados = new List<ProductoAgricola>(_todosLosProductos);

            // Filtrar por tipo de cultivo
            if (cmbTipoCultivo.SelectedIndex > 0)
            {
                string tipoSeleccionado = cmbTipoCultivo.SelectedItem.ToString().ToLower();
                _productosFiltrados = _productosFiltrados
                    .Where(p => p.TipoCultivo.ToLower().Contains(tipoSeleccionado))
                    .ToList();
            }

            // Filtrar por nombre
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                string nombreFiltro = txtNombre.Text.Trim().ToLower();
                _productosFiltrados = _productosFiltrados
                    .Where(p => p.Nombre.ToLower().Contains(nombreFiltro))
                    .ToList();
            }

            // Filtrar por temporada
            if (cmbTemporada.SelectedIndex > 0)
            {
                string temporadaSeleccionada = cmbTemporada.SelectedItem.ToString().ToLower();
                _productosFiltrados = _productosFiltrados
                    .Where(p => !string.IsNullOrEmpty(p.Temporada) &&
                               p.Temporada.ToLower().Contains(temporadaSeleccionada))
                    .ToList();
            }

            ActualizarDataGridView();
            ActualizarContadorRegistros();
        }

        // Eventos
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoCultivo.SelectedIndex = 0;
            txtNombre.Clear();
            cmbTemporada.SelectedIndex = 0;

            _productosFiltrados = new List<ProductoAgricola>(_todosLosProductos);
            ActualizarDataGridView();
            ActualizarContadorRegistros();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarProductos();
            MessageHelper.ShowSuccess("Lista de productos actualizada correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}