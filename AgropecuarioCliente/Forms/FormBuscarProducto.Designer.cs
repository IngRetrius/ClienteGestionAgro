namespace AgropecuarioCliente.Forms
{
    partial class FormBuscarProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.rbPorId = new System.Windows.Forms.RadioButton();
            this.rbPorNombre = new System.Windows.Forms.RadioButton();
            this.rbPorTipo = new System.Windows.Forms.RadioButton();
            this.rbPorRangoHectareas = new System.Windows.Forms.RadioButton();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbTipoCultivo = new System.Windows.Forms.ComboBox();
            this.lblHectareasMin = new System.Windows.Forms.Label();
            this.numHectareasMin = new System.Windows.Forms.NumericUpDown();
            this.lblHectareasMax = new System.Windows.Forms.Label();
            this.numHectareasMax = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareasMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareasMax)).BeginInit();
            this.groupBoxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(300, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Buscar Productos Agrícolas";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.btnLimpiar);
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.numHectareasMax);
            this.groupBoxBusqueda.Controls.Add(this.lblHectareasMax);
            this.groupBoxBusqueda.Controls.Add(this.numHectareasMin);
            this.groupBoxBusqueda.Controls.Add(this.lblHectareasMin);
            this.groupBoxBusqueda.Controls.Add(this.cmbTipoCultivo);
            this.groupBoxBusqueda.Controls.Add(this.txtBusqueda);
            this.groupBoxBusqueda.Controls.Add(this.lblCriterio);
            this.groupBoxBusqueda.Controls.Add(this.rbPorRangoHectareas);
            this.groupBoxBusqueda.Controls.Add(this.rbPorTipo);
            this.groupBoxBusqueda.Controls.Add(this.rbPorNombre);
            this.groupBoxBusqueda.Controls.Add(this.rbPorId);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(30, 70);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(840, 180);
            this.groupBoxBusqueda.TabIndex = 1;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Criterios de Búsqueda";
            // 
            // rbPorId
            // 
            this.rbPorId.AutoSize = true;
            this.rbPorId.Checked = true;
            this.rbPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorId.Location = new System.Drawing.Point(30, 30);
            this.rbPorId.Name = "rbPorId";
            this.rbPorId.Size = new System.Drawing.Size(71, 22);
            this.rbPorId.TabIndex = 0;
            this.rbPorId.TabStop = true;
            this.rbPorId.Text = "Por ID";
            this.rbPorId.UseVisualStyleBackColor = true;
            this.rbPorId.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbPorNombre
            // 
            this.rbPorNombre.AutoSize = true;
            this.rbPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorNombre.Location = new System.Drawing.Point(130, 30);
            this.rbPorNombre.Name = "rbPorNombre";
            this.rbPorNombre.Size = new System.Drawing.Size(107, 22);
            this.rbPorNombre.TabIndex = 1;
            this.rbPorNombre.Text = "Por Nombre";
            this.rbPorNombre.UseVisualStyleBackColor = true;
            this.rbPorNombre.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbPorTipo
            // 
            this.rbPorTipo.AutoSize = true;
            this.rbPorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorTipo.Location = new System.Drawing.Point(270, 30);
            this.rbPorTipo.Name = "rbPorTipo";
            this.rbPorTipo.Size = new System.Drawing.Size(145, 22);
            this.rbPorTipo.TabIndex = 2;
            this.rbPorTipo.Text = "Por Tipo Cultivo";
            this.rbPorTipo.UseVisualStyleBackColor = true;
            this.rbPorTipo.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbPorRangoHectareas
            // 
            this.rbPorRangoHectareas.AutoSize = true;
            this.rbPorRangoHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPorRangoHectareas.Location = new System.Drawing.Point(450, 30);
            this.rbPorRangoHectareas.Name = "rbPorRangoHectareas";
            this.rbPorRangoHectareas.Size = new System.Drawing.Size(169, 22);
            this.rbPorRangoHectareas.TabIndex = 3;
            this.rbPorRangoHectareas.Text = "Por Rango Hectáreas";
            this.rbPorRangoHectareas.UseVisualStyleBackColor = true;
            this.rbPorRangoHectareas.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCriterio.Location = new System.Drawing.Point(30, 70);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(127, 18);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Ingrese el valor:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBusqueda.Location = new System.Drawing.Point(30, 90);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(250, 24);
            this.txtBusqueda.TabIndex = 5;
            // 
            // cmbTipoCultivo
            // 
            this.cmbTipoCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoCultivo.FormattingEnabled = true;
            this.cmbTipoCultivo.Location = new System.Drawing.Point(30, 90);
            this.cmbTipoCultivo.Name = "cmbTipoCultivo";
            this.cmbTipoCultivo.Size = new System.Drawing.Size(200, 26);
            this.cmbTipoCultivo.TabIndex = 6;
            this.cmbTipoCultivo.Visible = false;
            // 
            // lblHectareasMin
            // 
            this.lblHectareasMin.AutoSize = true;
            this.lblHectareasMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareasMin.Location = new System.Drawing.Point(30, 70);
            this.lblHectareasMin.Name = "lblHectareasMin";
            this.lblHectareasMin.Size = new System.Drawing.Size(124, 18);
            this.lblHectareasMin.TabIndex = 7;
            this.lblHectareasMin.Text = "Hectáreas mínimas:";
            this.lblHectareasMin.Visible = false;
            // 
            // numHectareasMin
            // 
            this.numHectareasMin.DecimalPlaces = 2;
            this.numHectareasMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numHectareasMin.Location = new System.Drawing.Point(30, 90);
            this.numHectareasMin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHectareasMin.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numHectareasMin.Name = "numHectareasMin";
            this.numHectareasMin.Size = new System.Drawing.Size(120, 24);
            this.numHectareasMin.TabIndex = 8;
            this.numHectareasMin.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numHectareasMin.Visible = false;
            // 
            // lblHectareasMax
            // 
            this.lblHectareasMax.AutoSize = true;
            this.lblHectareasMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareasMax.Location = new System.Drawing.Point(180, 70);
            this.lblHectareasMax.Name = "lblHectareasMax";
            this.lblHectareasMax.Size = new System.Drawing.Size(126, 18);
            this.lblHectareasMax.TabIndex = 9;
            this.lblHectareasMax.Text = "Hectáreas máximas:";
            this.lblHectareasMax.Visible = false;
            // 
            // numHectareasMax
            // 
            this.numHectareasMax.DecimalPlaces = 2;
            this.numHectareasMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numHectareasMax.Location = new System.Drawing.Point(180, 90);
            this.numHectareasMax.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHectareasMax.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numHectareasMax.Name = "numHectareasMax";
            this.numHectareasMax.Size = new System.Drawing.Size(120, 24);
            this.numHectareasMax.TabIndex = 10;
            this.numHectareasMax.Value = new decimal(new int[] { 100, 0, 0, 0 });
            this.numHectareasMax.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(550, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 40);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(690, 80);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.lblResultados);
            this.groupBoxResultados.Controls.Add(this.dataGridView1);
            this.groupBoxResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxResultados.Location = new System.Drawing.Point(30, 270);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(840, 300);
            this.groupBoxResultados.TabIndex = 2;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados de la Búsqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResultados.Location = new System.Drawing.Point(20, 270);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(150, 18);
            this.lblResultados.TabIndex = 1;
            this.lblResultados.Text = "Registros encontrados: 0";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(750, 590);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Producto - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareasMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareasMax)).EndInit();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.RadioButton rbPorId;
        private System.Windows.Forms.RadioButton rbPorNombre;
        private System.Windows.Forms.RadioButton rbPorTipo;
        private System.Windows.Forms.RadioButton rbPorRangoHectareas;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbTipoCultivo;
        private System.Windows.Forms.Label lblHectareasMin;
        private System.Windows.Forms.NumericUpDown numHectareasMin;
        private System.Windows.Forms.Label lblHectareasMax;
        private System.Windows.Forms.NumericUpDown numHectareasMax;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnCerrar;
    }
}