namespace FactuGes
{
    partial class InicioSesion
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
            this.gbInicioSesion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.gbInicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicioSesion
            // 
            this.gbInicioSesion.Controls.Add(this.txtContrasenia);
            this.gbInicioSesion.Controls.Add(this.txtUsuario);
            this.gbInicioSesion.Controls.Add(this.btnInicioSesion);
            this.gbInicioSesion.Controls.Add(this.label2);
            this.gbInicioSesion.Controls.Add(this.label1);
            this.gbInicioSesion.Location = new System.Drawing.Point(33, 31);
            this.gbInicioSesion.Name = "gbInicioSesion";
            this.gbInicioSesion.Size = new System.Drawing.Size(259, 207);
            this.gbInicioSesion.TabIndex = 1;
            this.gbInicioSesion.TabStop = false;
            this.gbInicioSesion.Text = "Inicio de Sesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Location = new System.Drawing.Point(74, 147);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(104, 37);
            this.btnInicioSesion.TabIndex = 2;
            this.btnInicioSesion.Text = "Iniciar Sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(88, 60);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(88, 101);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(152, 20);
            this.txtContrasenia.TabIndex = 4;
            // 
            // InicioSesion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.gbInicioSesion);
            this.MaximizeBox = false;
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.gbInicioSesion.ResumeLayout(false);
            this.gbInicioSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicioSesion;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}