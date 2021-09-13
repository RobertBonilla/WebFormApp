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

        public GenericListResponse<WebApp.Front.Models.Domain.Lista> getList()
        {
            GenericListResponse<WebApp.Front.Models.Domain.Lista> response;
            try
            {
                WsListaSoapClient wsLista = new WsListaSoapClient();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string JSONData = wsLista.GetLista();
                response = ser.Deserialize<GenericListResponse<WebApp.Front.Models.Domain.Lista>>(JSONData);
            }
            catch (Exception ex)
            {
                response = new GenericListResponse<WebApp.Front.Models.Domain.Lista>()
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

        public GenericResponse<WebApp.Front.Models.Domain.Lista> getListaModel(int idLista)
        {
            GenericResponse<WebApp.Front.Models.Domain.Lista> response;
            try
            {
                WsListaSoapClient wsLista = new WsListaSoapClient();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string JSONData = wsLista.GetListaId(idLista);
                response = ser.Deserialize<GenericResponse<WebApp.Front.Models.Domain.Lista>>(JSONData);
            }
            catch (Exception ex)
            {
                response = new GenericResponse<WebApp.Front.Models.Domain.Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return response;
        }

        public GenericResponse<WebApp.Front.Models.Domain.Lista> modificarLista(WebApp.Front.Models.Domain.Lista model)
        {
            GenericResponse<WebApp.Front.Models.Domain.Lista> response;
            try
            {
                WsListaSoapClient wsLista = new WsListaSoapClient();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                WebApp.Front.WebServiceLista.Lista newModel = new WebServiceLista.Lista() {
                    ListaId = model.ListaId,
                    FechaCreacion = model.FechaCreacion,
                    FechaUpdate = model.FechaUpdate,
                    Descripcion = model.Descripcion
                };
                string JSONData = wsLista.EditLista(newModel);
                response = ser.Deserialize<GenericResponse<WebApp.Front.Models.Domain.Lista>>(JSONData);
            }
            catch (Exception ex)
            {
                response = new GenericResponse<WebApp.Front.Models.Domain.Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return response;
        }
    }
}