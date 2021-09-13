using System.Collections.Generic;
using WebApp.Core.Domain;

namespace WebApp.Core.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetProductos();
    }
}
