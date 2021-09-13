using System.Collections.Generic;
using WebApp.Front.Models.Domain;

namespace WebApp.Front.Models.DTO
{
    public class ListaItems
    {
        public Lista Lista { get; set; }
        public IEnumerable<DetListaProducto> Items { get; set; }
    }
}