using WebApp.Front.Models.Domain;
using WebApp.Front.Models.DTO;
using WebApp.Front.Rest.Responses;

namespace WebApp.Front.Rest.Interfaces
{
    public interface IApiRest
    {
        GenericListResponse<Lista> getList();

        GenericResponse<Lista> getListaModel(int idLista);

        GenericResponse<ListaItems> getListaData(int ListaId);

        GenericResponse<Lista> modificarLista(Lista model);

        GenericResponse<DetLista> eliminarDetail(DetLista model);
    }
}