using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApp.Service.Commond.Responses;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using WebApp.Core.Interfaces;
using WebApp.Core.UseCase;
using WebApp.Infraestructure.Repository;
using WebApp.Core.Domain;
using System.Net;

namespace WebApp.Service
{
    [WebService(Namespace = "http://webService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WsLista : System.Web.Services.WebService
    {
        private readonly IListaUseCase _userCase;
        public WsLista()
        {
            _userCase = new ListaUseCase(new ListaRepository());
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetLista()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            GenericListResponse<Lista> response;
            try
            {
                response = new GenericListResponse<Lista>()
                {
                    Status = new ResponseStatus() { HttpCode = HttpStatusCode.OK },
                    Items = _userCase.ObtenerLista()
                };
            }
            catch (Exception ex)
            {
                response = new GenericListResponse<Lista>()
                {
                    Status = new ResponseStatus()
                    { HttpCode = HttpStatusCode.InternalServerError, Message = ex.ToString() }
                };
            }
            string JSONReturn = ser.Serialize(response);
            //HttpContext.Current.Response.Write(JSONReturn);
            return JSONReturn;
        }
    }
}
