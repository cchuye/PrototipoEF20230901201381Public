using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaComprasCXP.Mantenimientos
{
    public partial class Clientes : Form
    {
        Controlador cn = new Controlador();
        public Clientes()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "8001";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtid, txtnombre, txtdomicilio, txtnit, txttelefono,txtcodvendedor,txtestado };
            TextBox[] Idtextbox = { txtid, txtcodvendedor };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }
    }
}
