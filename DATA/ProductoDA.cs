using B_F;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_E;

namespace DATA
{
    public class ProductoDA
    {
        private readonly db_taeraEntities context;

        public ProductoDA()
        {
            context = new db_taeraEntities();
        }

        public List<ProductoE> ListarActivas()
        {

         
            var Lista = (from can in context.productoes
                         where can.activo.Equals(true)
                         select new ProductoE
                         {
                             id_producto = can.id_producto,
                             nombre_producto = can.nombre_producto
                         }).ToList();


            return Lista;
        }
    }
}
