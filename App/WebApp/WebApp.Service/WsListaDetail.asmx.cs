using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using WebApp.Core.Domain;
using WebApp.Core.Dto;
using WebApp.Core.Interfaces;
using WebApp.Core.UseCase;
using WebApp.Infraestructure.Repository;
using WebApp.Service.Commond.Responses;

namespace WebApp.Service
{
    /// <summary>
    /// Summary description for WsListaDetail
    /// </summary>
    [WebService(Namespace = "http://webService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WsListaDetail : System.Web.Services.WebService
    {
        private readonly IDetListaUseCase _useCase;
        public WsListaDetail()
        {
            _useCase = new DetListaUseCase(new DetListaRepository(),new ListaRepository());
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetListaItemsId(int ListaId)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            GenericResponse<ListaItems> response;
            try
            {
                response = new GenericResponse<ListaItems>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _useCase.getListaProductos(new Lista() { ListaId = ListaId })
                };
            }
            catch (Exception ex)
            {
                response = new GenericResponse<ListaItems>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return ser.Serialize(response);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string DeleteListaItemId(DetLista detLista)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            GenericResponse<DetLista> response;
            try
            {
                response = new GenericResponse<DetLista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Item = _useCase.eliminarDetLista(detLista)
                };
            }
            catch (Exception ex)
            {
                response = new GenericResponse<DetLista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return ser.Serialize(response);
        }
    }
}
