using System;

namespace WebApp.Service.Commond.Responses
{
    [Serializable]
    public class GenericResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public T Item { get; set; }
    }
}