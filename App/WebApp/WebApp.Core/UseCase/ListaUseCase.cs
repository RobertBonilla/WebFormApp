using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Core.UseCase
{
    public class ListaUseCase : IListaUseCase
    {
        private readonly IListaRepository _repository;

        public ListaUseCase(IListaRepository repository)
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

        public Lista GetLista(Lista model)
        {
            return _repository.GetLista(model);
        }

        public Lista InsertarLista(Lista model)
        {
            if (model != null && model.Descripcion != null)
            {
                return _repository.InsertarLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public Lista ModificarLista(Lista model)
        {
            if (model != null && model.ListaId > 0 && model.Descripcion != null)
            {
                return _repository.ModificarLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public IEnumerable<Lista> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }
    }
}
