﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pruebas.ServicioWebGalaxia {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioWebGalaxia.ServicioWebGalaxiaSoap")]
    public interface ServicioWebGalaxiaSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento cadena del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LecturaDeRegistro", ReplyAction="*")]
        Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponse LecturaDeRegistro(Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LecturaDeRegistro", ReplyAction="*")]
        System.Threading.Tasks.Task<Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponse> LecturaDeRegistroAsync(Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LecturaDeRegistroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LecturaDeRegistro", Namespace="http://tempuri.org/", Order=0)]
        public Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequestBody Body;
        
        public LecturaDeRegistroRequest() {
        }
        
        public LecturaDeRegistroRequest(Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LecturaDeRegistroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cadena;
        
        public LecturaDeRegistroRequestBody() {
        }
        
        public LecturaDeRegistroRequestBody(string cadena) {
            this.cadena = cadena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LecturaDeRegistroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LecturaDeRegistroResponse", Namespace="http://tempuri.org/", Order=0)]
        public Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponseBody Body;
        
        public LecturaDeRegistroResponse() {
        }
        
        public LecturaDeRegistroResponse(Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LecturaDeRegistroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LecturaDeRegistroResult;
        
        public LecturaDeRegistroResponseBody() {
        }
        
        public LecturaDeRegistroResponseBody(bool LecturaDeRegistroResult) {
            this.LecturaDeRegistroResult = LecturaDeRegistroResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioWebGalaxiaSoapChannel : Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioWebGalaxiaSoapClient : System.ServiceModel.ClientBase<Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap>, Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap {
        
        public ServicioWebGalaxiaSoapClient() {
        }
        
        public ServicioWebGalaxiaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioWebGalaxiaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWebGalaxiaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWebGalaxiaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponse Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap.LecturaDeRegistro(Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest request) {
            return base.Channel.LecturaDeRegistro(request);
        }
        
        public bool LecturaDeRegistro(string cadena) {
            Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest inValue = new Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest();
            inValue.Body = new Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequestBody();
            inValue.Body.cadena = cadena;
            Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponse retVal = ((Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap)(this)).LecturaDeRegistro(inValue);
            return retVal.Body.LecturaDeRegistroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponse> Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap.LecturaDeRegistroAsync(Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest request) {
            return base.Channel.LecturaDeRegistroAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pruebas.ServicioWebGalaxia.LecturaDeRegistroResponse> LecturaDeRegistroAsync(string cadena) {
            Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest inValue = new Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequest();
            inValue.Body = new Pruebas.ServicioWebGalaxia.LecturaDeRegistroRequestBody();
            inValue.Body.cadena = cadena;
            return ((Pruebas.ServicioWebGalaxia.ServicioWebGalaxiaSoap)(this)).LecturaDeRegistroAsync(inValue);
        }
    }
}
