using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2.Controllers
{
    public class ProductosBL
    {
        ProductosDAL d = new ProductosDAL();
        public int AgregarProducto(ProductosEN p)
        {
            return d.AgregarProducto(p);
        }
        public List<ProductosEN> ConsultarProductos()
        {
            return d.ConsultarProductos();
        }
    }
}