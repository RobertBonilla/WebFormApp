using System;
using System.Collections.Generic;
using WebApp.Front.Models.Domain;
using WebApp.Front.Models.DTO;
using WebApp.Front.Rest.Interfaces;
using WebApp.Front.Rest.Responses;
using WebApp.Front.WebServiceLista;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Net;

namespace WebApp.Front.Rest
{
    public class ApiRest : IApiRest
    {
        public GenericResponse<DetLista> eliminarDetail(DetLista model)
        {
            throw new NotImplementedException();
        }

        public GenericListResponse<Lista> getList()
        {
            GenericListResponse<Lista> response;
            try
            {
                WsListaSoapClient wsLista = new WsListaSoapClient();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string JSONData = wsLista.GetLista();
                response = ser.Deserialize<GenericListResponse<Lista>>(JSONData);
            }
            catch (Exception ex)
            {
                response = new GenericListResponse<Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }            
            return response;
        }

        public GenericResponse<ListaItems> getListaData(int ListaId)
        {
            throw new NotImplementedException();
        }

        public GenericResponse<Lista> getListaModel(int idLista)
        {
            throw new NotImplementedException();
        }

        public GenericResponse<Lista> modificarLista(Lista model)
        {
            throw new NotImplementedException();
        }
    }
}