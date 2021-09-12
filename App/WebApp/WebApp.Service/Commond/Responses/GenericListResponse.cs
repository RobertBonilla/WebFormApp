using System;
using System.Collections.Generic;

namespace WebApp.Service.Commond.Responses
{
    [Serializable]
    public class GenericListResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}