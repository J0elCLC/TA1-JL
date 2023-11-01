using B_E;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductoBL
    {
        private readonly ProductoDA objProductoDA;

        public ProductoBL()
        {
            objProductoDA = new ProductoDA();
        }
        public List<ProductoE> ListarActivas()
        {
            try
            {
                return objProductoDA.ListarActivas();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
