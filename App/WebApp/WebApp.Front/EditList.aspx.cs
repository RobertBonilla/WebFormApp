using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Front.Models.Domain;
using WebApp.Front.Models.DTO;
using WebApp.Front.Rest;
using WebApp.Front.Rest.Responses;

namespace WebApp.Front
{
    public partial class EditList : System.Web.UI.Page
    {
        private ApiRest myApi;
        private Lista item;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                try
                {
                    myApi = new ApiRest();
                    int ListaId = int.Parse(Session["prmEdit"].ToString());
                    GenericResponse<Lista> response = myApi.getListaModel(ListaId);
                    if(response!=null && response.Item != null)
                    {
                        txtCodigo.Text = response.Item.ListaId.ToString();
                        txtFechaCreacion.Text = response.Item.FechaCreacion;
                        txtFechaUpdate.Text = response.Item.FechaUpdate;
                        txtDescripcion.Text = response.Item.Descripcion;
                        item = response.Item;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Default.aspx", true);
                }
            }
        }

        protected void Modificar(object sender, EventArgs e)
        {
            try
            {                
                item = new Lista()
                {
                    ListaId = int.Parse(txtCodigo.Text.ToString()),
                    FechaCreacion = txtFechaCreacion.Text,
                    FechaUpdate = txtFechaUpdate.Text,
                    Descripcion = txtDescripcion.Text
                };
                if (myApi == null) myApi = new ApiRest();
                GenericResponse<Lista> response = myApi.modificarLista(item);
                if (response != null && response.Status != null && response.Status.HttpCode == HttpStatusCode.OK)
                {                    
                    showMessage("Datos Actualizados con Exito!");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Default.aspx", true);
            }
        }

        protected void Regresar(object sender, EventArgs e)
        {            
            Response.Redirect("Default.aspx", true);
        }

        private void showMessage(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
        }
    }
}