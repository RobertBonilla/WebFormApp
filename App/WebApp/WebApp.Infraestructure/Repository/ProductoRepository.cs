using System;
using System.Collections.Generic;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        public IEnumerable<Producto> GetProductos()
        {
            throw new NotImplementedException();
        }
    }
}
