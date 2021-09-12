using System;
using System.Collections.Generic;
using WebApp.Front.Models.Domain;
using WebApp.Front.Models.DTO;
using WebApp.Front.Rest.Interfaces;
using WebApp.Front.Rest.Responses;

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
            GenericListResponse<Lista> response = new GenericListResponse<Lista>();
            List<Lista> myList = new List<Lista>();
            myList.Add(new Lista()
            {
                FechaCreacion = "10/10/2021",
                FechaUpdate = "10/10/2021",
                Descripcion = "Prueba"
            });
            response.Items = myList;
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