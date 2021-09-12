﻿using System;
using System.Web.UI;
using WebApp.Front.Models.Domain;
using WebApp.Front.Rest;
using WebApp.Front.Rest.Responses;

namespace WebApp.Front
{
    public partial class _Default : Page
    {
        ApiRest myApi;
        protected void Page_Load(object sender, EventArgs e)
        {
            myApi = new ApiRest();
        }

        protected void ConsultarLista(object sender, EventArgs e)
        {
            GenericListResponse<Lista> response = myApi.getList();
            if (response != null && response.Items != null)
            {
                tblLista.DataSource = response.Items;
                tblLista.DataBind();
            }
        }
    }
}