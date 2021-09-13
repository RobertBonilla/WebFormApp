using System.Collections.Generic;
using WebApp.Core.Domain;
using WebApp.Core.Dto;

namespace WebApp.Core.Interfaces
{
    public interface IDetListaRepository
    {
        DetLista insertarDetLista(DetLista model);
        DetLista modificarDetLista(DetLista model);
        DetLista eliminarDetLista(DetLista model);
        IEnumerable<DetListaProducto> getListaProductos(Lista model);
    }
}
