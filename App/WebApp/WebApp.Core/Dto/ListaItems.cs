using System.Collections.Generic;
using WebApp.Core.Domain;

namespace WebApp.Core.Dto
{
    public class ListaItems
    {
        public Lista Lista { get; set; }
        public IEnumerable<DetListaProducto> Items { get; set; }
    }
}
