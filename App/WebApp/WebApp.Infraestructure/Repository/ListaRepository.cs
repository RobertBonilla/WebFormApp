using System;
using System.Collections.Generic;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ListaRepository : IListaRepository
    {
        public Lista GetLista(Lista model)
        {
            throw new NotImplementedException();
        }

        public Lista InsertarLista(Lista model)
        {
            throw new NotImplementedException();
        }

        public Lista ModificarLista(Lista model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lista> ObtenerLista()
        {
            List<Lista> list = new List<Lista>();
            list.Add(new Lista()
            {
                FechaCreacion = "01/09/2021",
                FechaUpdate = "02/09/2021",
                Descripcion = "Prueba"
            });
            return list;
        }
    }
}
