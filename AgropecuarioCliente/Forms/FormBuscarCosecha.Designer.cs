namespace AgropecuarioCliente.Forms
{
    partial class FormBuscarCosecha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(260, 10);
            this.lblTitulo.Text = "Buscar Cosechas";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.lblCriterio);
            this.groupBoxBusqueda.Controls.Add(this.txtBusqueda);
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.btnLimpiar);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(12, 40);
            this.groupBoxBusqueda.Size = new System.Drawing.Size(760, 80);
            this.groupBoxBusqueda.Text = "Criterios de Búsqueda";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Location = new System.Drawing.Point(16, 28);
            this.lblCriterio.Size = new System.Drawing.Size(100, 23);
            this.lblCriterio.Text = "Ingrese valor:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(120, 26);
            this.txtBusqueda.Size = new System.Drawing.Size(300, 22);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(440, 20);
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(580, 20);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.dataGridView1);
            this.groupBoxResultados.Location = new System.Drawing.Point(12, 130);
            this.groupBoxResultados.Size = new System.Drawing.Size(760, 280);
            this.groupBoxResultados.Text = "Resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(16, 22);
            this.dataGridView1.Size = new System.Drawing.Size(728, 240);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(652, 420);
            this.btnCerrar.Size = new System.Drawing.Size(120, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBuscarCosecha
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormBuscarCosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Cosechas - Sistema Agropecuario";
            this.Load += new System.EventHandler(this.FormBuscarCosecha_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Designer fields
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrar;
    }
}