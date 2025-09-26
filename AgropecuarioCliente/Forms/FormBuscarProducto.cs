using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AgropecuarioCliente.Models;
using AgropecuarioCliente.Services;
using AgropecuarioCliente.Utils;

namespace AgropecuarioCliente.Forms
{
    public partial class FormBuscarProducto : Form
    {
        private readonly ApiService _apiService;
        private List<ProductoAgricola> _resultados;

        public FormBuscarProducto()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _resultados = new List<ProductoAgricola>();
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarComboBoxes();
            ConfigurarControlesBusqueda();
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
                HeaderText = "Cantidad",
                DataPropertyName = "CantidadProducida",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioVenta",
                HeaderText = "Precio",
                DataPropertyName = "PrecioVenta",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });
        }

        private void CargarComboBoxes()
        {
            cmbTipoCultivo.Items.Clear();
            cmbTipoCultivo.Items.AddRange(new string[]
            {
                "Café", "Arroz", "Cacao", "Mango", "Aguacate",
                "Cítricos", "Maracuyá", "Sorgo", "Algodón", "Plátano"
            });
        }

        private void ConfigurarControlesBusqueda()
        {
            // Ocultar todos los controles inicialmente
            txtBusqueda.Visible = true;
            cmbTipoCultivo.Visible = false;
            lblHectareasMin.Visible = false;
            numHectareasMin.Visible = false;
            lblHectareasMax.Visible = false;
            numHectareasMax.Visible = false;

            // Configurar según el radio button seleccionado
            RadioButton_CheckedChanged(rbPorId, EventArgs.Empty);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Ocultar todos los controles
            txtBusqueda.Visible = false;
            cmbTipoCultivo.Visible = false;
            lblHectareasMin.Visible = false;
            numHectareasMin.Visible = false;
            lblHectareasMax.Visible = false;
            numHectareasMax.Visible = false;

            if (rbPorId.Checked)
            {
                lblCriterio.Text = "Ingrese el ID del producto:";
                txtBusqueda.Visible = true;
                txtBusqueda.Clear();
                txtBusqueda.Focus();
            }
            else if (rbPorNombre.Checked)
            {
                lblCriterio.Text = "Ingrese parte del nombre:";
                txtBusqueda.Visible = true;
                txtBusqueda.Clear();
                txtBusqueda.Focus();
            }
            else if (rbPorTipo.Checked)
            {
                lblCriterio.Text = "Seleccione el tipo de cultivo:";
                cmbTipoCultivo.Visible = true;
                if (cmbTipoCultivo.Items.Count > 0)
                    cmbTipoCultivo.SelectedIndex = 0;
                cmbTipoCultivo.Focus();
            }
            else if (rbPorRangoHectareas.Checked)
            {
                lblCriterio.Visible = false;
                lblHectareasMin.Visible = true;
                numHectareasMin.Visible = true;
                lblHectareasMax.Visible = true;
                numHectareasMax.Visible = true;
                numHectareasMin.Focus();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarBusqueda())
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnBuscar.Enabled = false;

                _resultados.Clear();

                if (rbPorId.Checked)
                {
                    await BuscarPorId();
                }
                else if (rbPorNombre.Checked)
                {
                    await BuscarPorNombre();
                }
                else if (rbPorTipo.Checked)
                {
                    await BuscarPorTipo();
                }
                else if (rbPorRangoHectareas.Checked)
                {
                    await BuscarPorRangoHectareas();
                }

                ActualizarResultados();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError($"Error al realizar la búsqueda:\n{ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnBuscar.Enabled = true;
            }
        }

        private bool ValidarBusqueda()
        {
            if (rbPorId.Checked || rbPorNombre.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    MessageHelper.ShowWarning("Debe ingresar un valor para buscar.");
                    txtBusqueda.Focus();
                    return false;
                }
            }
            else if (rbPorTipo.Checked)
            {
                if (cmbTipoCultivo.SelectedIndex < 0)
                {
                    MessageHelper.ShowWarning("Debe seleccionar un tipo de cultivo.");
                    cmbTipoCultivo.Focus();
                    return false;
                }
            }
            else if (rbPorRangoHectareas.Checked)
            {
                if (numHectareasMin.Value > numHectareasMax.Value)
                {
                    MessageHelper.ShowWarning("El valor mínimo no puede ser mayor al máximo.");
                    numHectareasMin.Focus();
                    return false;
                }
            }

            return true;
        }

        private async System.Threading.Tasks.Task BuscarPorId()
        {
            string id = txtBusqueda.Text.Trim();
            var producto = await _apiService.ObtenerPorIdAsync(id);
            if (producto != null)
            {
                _resultados.Add(producto);
            }
        }

        private async System.Threading.Tasks.Task BuscarPorNombre()
        {
            string nombre = txtBusqueda.Text.Trim();
            _resultados = await _apiService.BuscarPorNombreAsync(nombre);
        }

        private async System.Threading.Tasks.Task BuscarPorTipo()
        {
            string tipo = cmbTipoCultivo.SelectedItem.ToString();
            _resultados = await _apiService.BuscarPorTipoAsync(tipo);
        }

        private async System.Threading.Tasks.Task BuscarPorRangoHectareas()
        {
            double min = (double)numHectareasMin.Value;
            double max = (double)numHectareasMax.Value;
            _resultados = await _apiService.BuscarPorRangoHectareasAsync(min, max);
        }

        private void ActualizarResultados()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _resultados;
            dataGridView1.Refresh();

            lblResultados.Text = $"Registros encontrados: {_resultados.Count}";

            if (_resultados.Count == 0)
            {
                MessageHelper.ShowInfo("No se encontraron productos que coincidan con los criterios de búsqueda.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            if (cmbTipoCultivo.Items.Count > 0)
                cmbTipoCultivo.SelectedIndex = 0;
            numHectareasMin.Value = numHectareasMin.Minimum;
            numHectareasMax.Value = 100;

            _resultados.Clear();
            dataGridView1.DataSource = null;
            lblResultados.Text = "Registros encontrados: 0";

            rbPorId.Checked = true;
            RadioButton_CheckedChanged(rbPorId, EventArgs.Empty);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}