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
    public partial class Detail : System.Web.UI.Page
    {
        private ApiRest myApi;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                try
                {
                    myApi = new ApiRest();
                    int ListaId = int.Parse(Session["prmDetEdit"].ToString());
                    GenericResponse<ListaItems> response = myApi.getListaData(ListaId);
                    if (response != null && response.Item != null)
                    {
                        txtCodigo.Text = response.Item.Lista.ListaId.ToString();
                        txtFechaCreacion.Text = response.Item.Lista.FechaCreacion;
                        txtFechaUpdate.Text = response.Item.Lista.FechaUpdate;
                        txtDescripcion.Text = response.Item.Lista.Descripcion;
                        if (response.Item.Items != null)
                        {
                            tblListaDetail.DataSource = response.Item.Items;
                            tblListaDetail.DataBind();
                        }
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

        protected void Eliminar(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                DetLista model = new DetLista()
                {
                    DetListaId = int.Parse(btn.CommandArgument.ToString())
                };
                if (myApi == null) myApi = new ApiRest();
                GenericResponse<DetLista> response = myApi.eliminarDetail(model);
                if (response != null && response.Status != null && response.Status.HttpCode == HttpStatusCode.OK)
                {                    
                    Session["prmDetEdit"] = txtCodigo.Text;
                    txtCodigo.Text = "";
                    Response.Redirect("Detail.aspx", true);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Detail.aspx", true);
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