using System.Collections.Generic;
using WebApp.Core.Domain;

namespace WebApp.Core.Interfaces
{
    public interface IListaUseCase
    {
        Lista GetLista(Lista model);
        IEnumerable<Lista> ObtenerLista();
        Lista ModificarLista(Lista model);
        Lista InsertarLista(Lista model);
    }
}
