using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApp.Service.Commond.Responses;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace WebApp.Service
{
    [WebService(Namespace = "http://webService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WsLista : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json,UseHttpGet = true)]
        public void HelloWorld()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            GenericListResponse<string> response = new GenericListResponse<string>();
            List<string> myList = new List<string>();
            myList.Add("Hola mundo");
            response.Items = myList;
            HttpContext.Current.Response.Write(ser.Serialize(response));
        }
    }
}
