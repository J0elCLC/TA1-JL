using B_F;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_E;
using DATA;
using BL;

namespace TA1_JL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargaPedido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objPedidoBE = new pedidod
            {

                fecha = dateTimePicker1.Value,
                activo = true

            };
        }

        void CargaPedido()
        {
            var objproductobl = new ProductoBL();
            var productos = objproductobl.ListarActivas();
            comboBox1.Items.AddRange(productos.ToArray());
            comboBox1.ValueMember = "id_producto";
            comboBox1.DisplayMember = "nombre";
        }
    }
}
