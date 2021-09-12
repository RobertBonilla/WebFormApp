using System;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;

namespace WebApp.Core.UseCase
{
    public class DetListaUseCase : IDetListaUseCase
    {
        private readonly IDetListaRepository _repository;
        private readonly IListaRepository _repositoryList;

        public DetListaUseCase(IDetListaRepository repository, IListaRepository repositoryList)
        {
            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                throw new ArgumentException(nameof(repository));
            }
            if (repositoryList != null)
            {
                _repositoryList = repositoryList;
            }
            else
            {
                throw new ArgumentException(nameof(repositoryList));
            }
        }
        public DetLista eliminarDetLista(DetLista model)
        {
            if (model != null && model.DetListaId > 0)
            {
                return _repository.eliminarDetLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public ListaItems getListaProductos(Lista model)
        {
            ListaItems listaItems = new ListaItems();
            listaItems.Lista = _repositoryList.GetLista(model);
            listaItems.Items = _repository.getListaProductos(model);
            return listaItems;
        }

        public DetLista insertarDetLista(DetLista model)
        {
            if (model != null && model.ListaId > 0 && model.ProductoId > 0)
            {
                model.SubTotal = model.ValorUnitario * decimal.Parse(model.Cantidad.ToString());
                return _repository.insertarDetLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }

        public DetLista modificarDetLista(DetLista model)
        {
            if (model != null && model.DetListaId > 0)
            {
                model.SubTotal = model.ValorUnitario * decimal.Parse(model.Cantidad.ToString());
                return _repository.modificarDetLista(model);
            }
            throw new ArgumentNullException("datos incompletos");
        }
    }
}
