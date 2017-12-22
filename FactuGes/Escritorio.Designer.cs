namespace FactuGes
{
    partial class Escritorio
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
            this.SuspendLayout();
            // 
            // Escritorio
            // 
            

            this.gbFacturas = new System.Windows.Forms.GroupBox();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnListadoFacturas = new System.Windows.Forms.Button();
            this.btnPendientePago = new System.Windows.Forms.Button();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.btnClienteDeudores = new System.Windows.Forms.Button();
            this.gbFacturas.SuspendLayout();
            this.gbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFacturas
            // 
            this.gbFacturas.BackColor = System.Drawing.Color.White;
            this.gbFacturas.Controls.Add(this.btnPendientePago);
            this.gbFacturas.Controls.Add(this.btnListadoFacturas);
            this.gbFacturas.Controls.Add(this.btnCrearFactura);
            this.gbFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFacturas.ForeColor = System.Drawing.Color.Purple;
            this.gbFacturas.Location = new System.Drawing.Point(12, 84);
            this.gbFacturas.Name = "gbFacturas";
            this.gbFacturas.Size = new System.Drawing.Size(658, 180);
            this.gbFacturas.TabIndex = 0;
            this.gbFacturas.TabStop = false;
            this.gbFacturas.Text = "Facturas";
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(76, 39);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(130, 106);
            this.btnCrearFactura.TabIndex = 0;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            // 
            // btnListadoFacturas
            // 
            this.btnListadoFacturas.Location = new System.Drawing.Point(263, 39);
            this.btnListadoFacturas.Name = "btnListadoFacturas";
            this.btnListadoFacturas.Size = new System.Drawing.Size(130, 106);
            this.btnListadoFacturas.TabIndex = 1;
            this.btnListadoFacturas.Text = "Listado Facturas";
            this.btnListadoFacturas.UseVisualStyleBackColor = true;
            // 
            // btnPendientePago
            // 
            this.btnPendientePago.Location = new System.Drawing.Point(449, 39);
            this.btnPendientePago.Name = "btnPendientePago";
            this.btnPendientePago.Size = new System.Drawing.Size(130, 106);
            this.btnPendientePago.TabIndex = 2;
            this.btnPendientePago.Text = "Pedientes Pago";
            this.btnPendientePago.UseVisualStyleBackColor = true;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnClienteDeudores);
            this.gbClientes.Controls.Add(this.btnListadoClientes);
            this.gbClientes.Controls.Add(this.btnNuevoCliente);
            this.gbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.ForeColor = System.Drawing.Color.Teal;
            this.gbClientes.Location = new System.Drawing.Point(12, 288);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(657, 180);
            this.gbClientes.TabIndex = 1;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(76, 45);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(130, 106);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btnListadoClientes
            // 
            this.btnListadoClientes.Location = new System.Drawing.Point(263, 45);
            this.btnListadoClientes.Name = "btnListadoClientes";
            this.btnListadoClientes.Size = new System.Drawing.Size(130, 106);
            this.btnListadoClientes.TabIndex = 1;
            this.btnListadoClientes.Text = "Listado Clientes";
            this.btnListadoClientes.UseVisualStyleBackColor = true;
            // 
            // btnClienteDeudores
            // 
            this.btnClienteDeudores.Location = new System.Drawing.Point(449, 45);
            this.btnClienteDeudores.Name = "btnClienteDeudores";
            this.btnClienteDeudores.Size = new System.Drawing.Size(130, 106);
            this.btnClienteDeudores.TabIndex = 2;
            this.btnClienteDeudores.Text = "Clientes Deudores";
            this.btnClienteDeudores.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(682, 494);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbFacturas);
            this.Name = "Escritorio";
            this.Text = "Escritorio";
            this.gbFacturas.ResumeLayout(false);
            this.gbClientes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbFacturas;
        private System.Windows.Forms.Button btnPendientePago;
        private System.Windows.Forms.Button btnListadoFacturas;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Button btnClienteDeudores;
        private System.Windows.Forms.Button btnListadoClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
    }
}