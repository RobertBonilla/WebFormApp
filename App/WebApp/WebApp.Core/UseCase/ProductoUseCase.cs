using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Core.UseCase
{
    public class ProductoUseCase : IProductoUseCase
    {
        private readonly IProductoRepository _repository;

        public ProductoUseCase(IProductoRepository repository)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                throw new ArgumentException(nameof(repository));
            }
        }
        public IEnumerable<Producto> GetProductos()
        {
            return _repository.GetProductos();
        }
    }
}
