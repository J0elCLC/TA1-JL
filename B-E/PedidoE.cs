using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E
{
    internal class PedidoE
    {

        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int id_usuario { get; set; }
        public int monto { get; set; }
        public DateTime fecha { get; set; }
        public int hora { get; set; }
        public bool activo { get; set; }
        public string usuario {  get; set; }
    }
}
