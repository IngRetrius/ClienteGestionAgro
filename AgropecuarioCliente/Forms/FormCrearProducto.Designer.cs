namespace AgropecuarioCliente.Forms
{
    partial class FormCrearProducto
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoCultivo = new System.Windows.Forms.Label();
            this.cmbTipoCultivo = new System.Windows.Forms.ComboBox();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.numHectareas = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblCosto = new System.Windows.Forms.Label();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.cmbTemporada = new System.Windows.Forms.ComboBox();
            this.lblTipoSuelo = new System.Windows.Forms.Label();
            this.cmbTipoSuelo = new System.Windows.Forms.ComboBox();
            this.lblCodigoFinca = new System.Windows.Forms.Label();
            this.txtCodigoFinca = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Location = new System.Drawing.Point(200, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Nuevo Producto Agrícola";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtCodigoFinca);
            this.groupBoxDatos.Controls.Add(this.lblCodigoFinca);
            this.groupBoxDatos.Controls.Add(this.cmbTipoSuelo);
            this.groupBoxDatos.Controls.Add(this.lblTipoSuelo);
            this.groupBoxDatos.Controls.Add(this.cmbTemporada);
            this.groupBoxDatos.Controls.Add(this.lblTemporada);
            this.groupBoxDatos.Controls.Add(this.numCosto);
            this.groupBoxDatos.Controls.Add(this.lblCosto);
            this.groupBoxDatos.Controls.Add(this.numPrecio);
            this.groupBoxDatos.Controls.Add(this.lblPrecio);
            this.groupBoxDatos.Controls.Add(this.numCantidad);
            this.groupBoxDatos.Controls.Add(this.lblCantidad);
            this.groupBoxDatos.Controls.Add(this.numHectareas);
            this.groupBoxDatos.Controls.Add(this.lblHectareas);
            this.groupBoxDatos.Controls.Add(this.cmbTipoCultivo);
            this.groupBoxDatos.Controls.Add(this.lblTipoCultivo);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatos.Location = new System.Drawing.Point(30, 70);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(640, 400);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombre.Location = new System.Drawing.Point(30, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNombre.Location = new System.Drawing.Point(30, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipoCultivo
            // 
            this.lblTipoCultivo.AutoSize = true;
            this.lblTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoCultivo.Location = new System.Drawing.Point(330, 40);
            this.lblTipoCultivo.Name = "lblTipoCultivo";
            this.lblTipoCultivo.Size = new System.Drawing.Size(104, 18);
            this.lblTipoCultivo.TabIndex = 2;
            this.lblTipoCultivo.Text = "Tipo de Cultivo:";
            // 
            // cmbTipoCultivo
            // 
            this.cmbTipoCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoCultivo.FormattingEnabled = true;
            this.cmbTipoCultivo.Location = new System.Drawing.Point(330, 60);
            this.cmbTipoCultivo.Name = "cmbTipoCultivo";
            this.cmbTipoCultivo.Size = new System.Drawing.Size(180, 26);
            this.cmbTipoCultivo.TabIndex = 3;
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHectareas.Location = new System.Drawing.Point(30, 110);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(151, 18);
            this.lblHectareas.TabIndex = 4;
            this.lblHectareas.Text = "Hectáreas Cultivadas:";
            // 
            // numHectareas
            // 
            this.numHectareas.DecimalPlaces = 2;
            this.numHectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numHectareas.Location = new System.Drawing.Point(30, 130);
            this.numHectareas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHectareas.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numHectareas.Name = "numHectareas";
            this.numHectareas.Size = new System.Drawing.Size(120, 24);
            this.numHectareas.TabIndex = 5;
            this.numHectareas.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(200, 110);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(148, 18);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad Producida:";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCantidad.Location = new System.Drawing.Point(200, 130);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 24);
            this.numCantidad.TabIndex = 7;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrecio.Location = new System.Drawing.Point(390, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(120, 18);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio de Venta:";
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numPrecio.Location = new System.Drawing.Point(390, 130);
            this.numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numPrecio.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 24);
            this.numPrecio.TabIndex = 9;
            this.numPrecio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCosto.Location = new System.Drawing.Point(30, 180);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(145, 18);
            this.lblCosto.TabIndex = 10;
            this.lblCosto.Text = "Costo de Producción:";
            // 
            // numCosto
            // 
            this.numCosto.DecimalPlaces = 2;
            this.numCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numCosto.Location = new System.Drawing.Point(30, 200);
            this.numCosto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numCosto.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(150, 24);
            this.numCosto.TabIndex = 11;
            this.numCosto.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTemporada.Location = new System.Drawing.Point(230, 180);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(85, 18);
            this.lblTemporada.TabIndex = 12;
            this.lblTemporada.Text = "Temporada:";
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Location = new System.Drawing.Point(230, 200);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(180, 26);
            this.cmbTemporada.TabIndex = 13;
            // 
            // lblTipoSuelo
            // 
            this.lblTipoSuelo.AutoSize = true;
            this.lblTipoSuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTipoSuelo.Location = new System.Drawing.Point(450, 180);
            this.lblTipoSuelo.Name = "lblTipoSuelo";
            this.lblTipoSuelo.Size = new System.Drawing.Size(102, 18);
            this.lblTipoSuelo.TabIndex = 14;
            this.lblTipoSuelo.Text = "Tipo de Suelo:";
            // 
            // cmbTipoSuelo
            // 
            this.cmbTipoSuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoSuelo.FormattingEnabled = true;
            this.cmbTipoSuelo.Location = new System.Drawing.Point(450, 200);
            this.cmbTipoSuelo.Name = "cmbTipoSuelo";
            this.cmbTipoSuelo.Size = new System.Drawing.Size(150, 26);
            this.cmbTipoSuelo.TabIndex = 15;
            // 
            // lblCodigoFinca
            // 
            this.lblCodigoFinca.AutoSize = true;
            this.lblCodigoFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCodigoFinca.Location = new System.Drawing.Point(30, 250);
            this.lblCodigoFinca.Name = "lblCodigoFinca";
            this.lblCodigoFinca.Size = new System.Drawing.Size(130, 18);
            this.lblCodigoFinca.TabIndex = 16;
            this.lblCodigoFinca.Text = "Código de Finca:";
            // 
            // txtCodigoFinca
            // 
            this.txtCodigoFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCodigoFinca.Location = new System.Drawing.Point(30, 270);
            this.txtCodigoFinca.Name = "txtCodigoFinca";
            this.txtCodigoFinca.Size = new System.Drawing.Size(150, 24);
            this.txtCodigoFinca.TabIndex = 17;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightGreen;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(350, 490);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 40);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Producto";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(490, 490);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(210, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Producto - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormCrearProducto_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHectareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoCultivo;
        private System.Windows.Forms.ComboBox cmbTipoCultivo;
        private System.Windows.Forms.Label lblHectareas;
        private System.Windows.Forms.NumericUpDown numHectareas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox cmbTemporada;
        private System.Windows.Forms.Label lblTipoSuelo;
        private System.Windows.Forms.ComboBox cmbTipoSuelo;
        private System.Windows.Forms.Label lblCodigoFinca;
        private System.Windows.Forms.TextBox txtCodigoFinca;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}