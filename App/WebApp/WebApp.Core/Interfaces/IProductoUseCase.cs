using System.Collections.Generic;
using WebApp.Core.Domain;

namespace WebApp.Core.Interfaces
{
    public interface IProductoUseCase
    {
        IEnumerable<Producto> GetProductos();
    }
}
