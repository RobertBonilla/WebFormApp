//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Front.WebServiceListaDetail {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetLista", Namespace="http://webService.org/")]
    [System.SerializableAttribute()]
    public partial class DetLista : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int DetListaIdField;
        
        private int ListaIdField;
        
        private int ProductoIdField;
        
        private decimal ValorUnitarioField;
        
        private int CantidadField;
        
        private decimal SubTotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int DetListaId {
            get {
                return this.DetListaIdField;
            }
            set {
                if ((this.DetListaIdField.Equals(value) != true)) {
                    this.DetListaIdField = value;
                    this.RaisePropertyChanged("DetListaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ListaId {
            get {
                return this.ListaIdField;
            }
            set {
                if ((this.ListaIdField.Equals(value) != true)) {
                    this.ListaIdField = value;
                    this.RaisePropertyChanged("ListaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ProductoId {
            get {
                return this.ProductoIdField;
            }
            set {
                if ((this.ProductoIdField.Equals(value) != true)) {
                    this.ProductoIdField = value;
                    this.RaisePropertyChanged("ProductoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal ValorUnitario {
            get {
                return this.ValorUnitarioField;
            }
            set {
                if ((this.ValorUnitarioField.Equals(value) != true)) {
                    this.ValorUnitarioField = value;
                    this.RaisePropertyChanged("ValorUnitario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public decimal SubTotal {
            get {
                return this.SubTotalField;
            }
            set {
                if ((this.SubTotalField.Equals(value) != true)) {
                    this.SubTotalField = value;
                    this.RaisePropertyChanged("SubTotal");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webService.org/", ConfigurationName="WebServiceListaDetail.WsListaDetailSoap")]
    public interface WsListaDetailSoap {
        
        // CODEGEN: Generating message contract since element name GetListaItemsIdResult from namespace http://webService.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webService.org/GetListaItemsId", ReplyAction="*")]
        WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponse GetListaItemsId(WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webService.org/GetListaItemsId", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponse> GetListaItemsIdAsync(WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest request);
        
        // CODEGEN: Generating message contract since element name detLista from namespace http://webService.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webService.org/DeleteListaItemId", ReplyAction="*")]
        WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponse DeleteListaItemId(WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webService.org/DeleteListaItemId", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponse> DeleteListaItemIdAsync(WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListaItemsIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListaItemsId", Namespace="http://webService.org/", Order=0)]
        public WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequestBody Body;
        
        public GetListaItemsIdRequest() {
        }
        
        public GetListaItemsIdRequest(WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://webService.org/")]
    public partial class GetListaItemsIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ListaId;
        
        public GetListaItemsIdRequestBody() {
        }
        
        public GetListaItemsIdRequestBody(int ListaId) {
            this.ListaId = ListaId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetListaItemsIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetListaItemsIdResponse", Namespace="http://webService.org/", Order=0)]
        public WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponseBody Body;
        
        public GetListaItemsIdResponse() {
        }
        
        public GetListaItemsIdResponse(WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://webService.org/")]
    public partial class GetListaItemsIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetListaItemsIdResult;
        
        public GetListaItemsIdResponseBody() {
        }
        
        public GetListaItemsIdResponseBody(string GetListaItemsIdResult) {
            this.GetListaItemsIdResult = GetListaItemsIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteListaItemIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteListaItemId", Namespace="http://webService.org/", Order=0)]
        public WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequestBody Body;
        
        public DeleteListaItemIdRequest() {
        }
        
        public DeleteListaItemIdRequest(WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://webService.org/")]
    public partial class DeleteListaItemIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApp.Front.WebServiceListaDetail.DetLista detLista;
        
        public DeleteListaItemIdRequestBody() {
        }
        
        public DeleteListaItemIdRequestBody(WebApp.Front.WebServiceListaDetail.DetLista detLista) {
            this.detLista = detLista;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteListaItemIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteListaItemIdResponse", Namespace="http://webService.org/", Order=0)]
        public WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponseBody Body;
        
        public DeleteListaItemIdResponse() {
        }
        
        public DeleteListaItemIdResponse(WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://webService.org/")]
    public partial class DeleteListaItemIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DeleteListaItemIdResult;
        
        public DeleteListaItemIdResponseBody() {
        }
        
        public DeleteListaItemIdResponseBody(string DeleteListaItemIdResult) {
            this.DeleteListaItemIdResult = DeleteListaItemIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WsListaDetailSoapChannel : WebApp.Front.WebServiceListaDetail.WsListaDetailSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsListaDetailSoapClient : System.ServiceModel.ClientBase<WebApp.Front.WebServiceListaDetail.WsListaDetailSoap>, WebApp.Front.WebServiceListaDetail.WsListaDetailSoap {
        
        public WsListaDetailSoapClient() {
        }
        
        public WsListaDetailSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsListaDetailSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsListaDetailSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsListaDetailSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponse WebApp.Front.WebServiceListaDetail.WsListaDetailSoap.GetListaItemsId(WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest request) {
            return base.Channel.GetListaItemsId(request);
        }
        
        public string GetListaItemsId(int ListaId) {
            WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest inValue = new WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest();
            inValue.Body = new WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequestBody();
            inValue.Body.ListaId = ListaId;
            WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponse retVal = ((WebApp.Front.WebServiceListaDetail.WsListaDetailSoap)(this)).GetListaItemsId(inValue);
            return retVal.Body.GetListaItemsIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponse> WebApp.Front.WebServiceListaDetail.WsListaDetailSoap.GetListaItemsIdAsync(WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest request) {
            return base.Channel.GetListaItemsIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.Front.WebServiceListaDetail.GetListaItemsIdResponse> GetListaItemsIdAsync(int ListaId) {
            WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest inValue = new WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequest();
            inValue.Body = new WebApp.Front.WebServiceListaDetail.GetListaItemsIdRequestBody();
            inValue.Body.ListaId = ListaId;
            return ((WebApp.Front.WebServiceListaDetail.WsListaDetailSoap)(this)).GetListaItemsIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponse WebApp.Front.WebServiceListaDetail.WsListaDetailSoap.DeleteListaItemId(WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest request) {
            return base.Channel.DeleteListaItemId(request);
        }
        
        public string DeleteListaItemId(WebApp.Front.WebServiceListaDetail.DetLista detLista) {
            WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest inValue = new WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest();
            inValue.Body = new WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequestBody();
            inValue.Body.detLista = detLista;
            WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponse retVal = ((WebApp.Front.WebServiceListaDetail.WsListaDetailSoap)(this)).DeleteListaItemId(inValue);
            return retVal.Body.DeleteListaItemIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponse> WebApp.Front.WebServiceListaDetail.WsListaDetailSoap.DeleteListaItemIdAsync(WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest request) {
            return base.Channel.DeleteListaItemIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.Front.WebServiceListaDetail.DeleteListaItemIdResponse> DeleteListaItemIdAsync(WebApp.Front.WebServiceListaDetail.DetLista detLista) {
            WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest inValue = new WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequest();
            inValue.Body = new WebApp.Front.WebServiceListaDetail.DeleteListaItemIdRequestBody();
            inValue.Body.detLista = detLista;
            return ((WebApp.Front.WebServiceListaDetail.WsListaDetailSoap)(this)).DeleteListaItemIdAsync(inValue);
        }
    }
}
