
namespace CapaVistaComprasCXP.Mantenimientos
{
    partial class Clientes
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodvendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(100, 37);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(490, 295);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(230, 20);
            this.txtestado.TabIndex = 85;
            this.txtestado.Tag = "estatus_cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Codigo Vendedor";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(154, 228);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(159, 20);
            this.txtid.TabIndex = 83;
            this.txtid.Tag = "codigo_cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Id Cliente";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(154, 294);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(159, 20);
            this.txtdomicilio.TabIndex = 74;
            this.txtdomicilio.Tag = "direccion_cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Domicilio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(358, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 81;
            this.label16.Text = "Estado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(154, 263);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(159, 20);
            this.txtnombre.TabIndex = 72;
            this.txtnombre.Tag = "nombre_cliente";
            // 
            // txtcodvendedor
            // 
            this.txtcodvendedor.Location = new System.Drawing.Point(490, 259);
            this.txtcodvendedor.Name = "txtcodvendedor";
            this.txtcodvendedor.Size = new System.Drawing.Size(230, 20);
            this.txtcodvendedor.TabIndex = 80;
            this.txtcodvendedor.Tag = "codigo_vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Telefono";
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(154, 326);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(159, 20);
            this.txtnit.TabIndex = 79;
            this.txtnit.Tag = "nit_cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 78;
            this.label8.Text = "Nombre";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(490, 222);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(230, 20);
            this.txttelefono.TabIndex = 76;
            this.txttelefono.Tag = "telefono_cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "NIT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 205);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.Tag = "clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodvendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.navegador1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodvendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}