using WebApp.Core.Domain;
using WebApp.Core.Dto;

namespace WebApp.Core.Interfaces
{
    public interface IDetListaUseCase
    {
        DetLista insertarDetLista(DetLista model);
        DetLista modificarDetLista(DetLista model);
        DetLista eliminarDetLista(DetLista model);
        ListaItems getListaProductos(Lista model);
    }
}
