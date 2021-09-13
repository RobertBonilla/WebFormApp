using System;
using WebApp.Front.Models.Domain;
using WebApp.Front.Models.DTO;
using WebApp.Front.Rest.Interfaces;
using WebApp.Front.Rest.Responses;
using WebApp.Front.WebServiceLista;
using WebApp.Front.WebServiceListaDetail;
using System.Web.Script.Serialization;
using System.Net;

namespace WebApp.Front.Rest
{
    public class ApiRest : IApiRest
    {
        public GenericResponse<WebApp.Front.Models.Domain.DetLista> eliminarDetail(WebApp.Front.Models.Domain.DetLista model)
        {
            GenericResponse<WebApp.Front.Models.Domain.DetLista> response;
            try
            {
                WsListaDetailSoapClient wsListaDetail = new WsListaDetailSoapClient();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                WebApp.Front.WebServiceListaDetail.DetLista newModel = new WebServiceListaDetail.DetLista()
                {
                    DetListaId = model.DetListaId,
                };
                string JSONData = wsListaDetail.DeleteListaItemId(newModel);
                response = ser.Deserialize<GenericResponse<WebApp.Front.Models.Domain.DetLista>>(JSONData);
            }
            catch (Exception ex)
            {
                response = new GenericResponse<WebApp.Front.Models.Domain.DetLista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return response;
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
            GenericResponse<ListaItems> response;
            try
            {
                WsListaDetailSoapClient wsListaDetail = new WsListaDetailSoapClient();
                JavaScriptSerializer ser = new JavaScriptSerializer();
                string JSONData = wsListaDetail.GetListaItemsId(ListaId);
                response = ser.Deserialize<GenericResponse<ListaItems>>(JSONData);
            }
            catch (Exception ex)
            {
                response = new GenericResponse<ListaItems>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            return response;
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