﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleFactura.RecepcionComprobantesOffline {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ec.gob.sri.ws.recepcion", ConfigurationName="RecepcionComprobantesOffline.RecepcionComprobantesOffline")]
    public interface RecepcionComprobantesOffline {
        
        // CODEGEN: Parameter 'RespuestaRecepcionComprobante' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(mensaje[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(comprobante[]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RespuestaRecepcionComprobante")]
        ConsoleFactura.RecepcionComprobantesOffline.validarComprobanteResponse validarComprobante(ConsoleFactura.RecepcionComprobantesOffline.validarComprobante request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleFactura.RecepcionComprobantesOffline.validarComprobanteResponse> validarComprobanteAsync(ConsoleFactura.RecepcionComprobantesOffline.validarComprobante request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.recepcion")]
    public partial class respuestaSolicitud : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string estadoField;
        
        private comprobante[] comprobantesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public comprobante[] comprobantes {
            get {
                return this.comprobantesField;
            }
            set {
                this.comprobantesField = value;
                this.RaisePropertyChanged("comprobantes");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.recepcion")]
    public partial class comprobante : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string claveAccesoField;
        
        private mensaje[] mensajesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string claveAcceso {
            get {
                return this.claveAccesoField;
            }
            set {
                this.claveAccesoField = value;
                this.RaisePropertyChanged("claveAcceso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public mensaje[] mensajes {
            get {
                return this.mensajesField;
            }
            set {
                this.mensajesField = value;
                this.RaisePropertyChanged("mensajes");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ec.gob.sri.ws.recepcion")]
    public partial class mensaje : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string identificadorField;
        
        private string mensaje1Field;
        
        private string informacionAdicionalField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string identificador {
            get {
                return this.identificadorField;
            }
            set {
                this.identificadorField = value;
                this.RaisePropertyChanged("identificador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mensaje", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string mensaje1 {
            get {
                return this.mensaje1Field;
            }
            set {
                this.mensaje1Field = value;
                this.RaisePropertyChanged("mensaje1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string informacionAdicional {
            get {
                return this.informacionAdicionalField;
            }
            set {
                this.informacionAdicionalField = value;
                this.RaisePropertyChanged("informacionAdicional");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
                this.RaisePropertyChanged("tipo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarComprobante", WrapperNamespace="http://ec.gob.sri.ws.recepcion", IsWrapped=true)]
    public partial class validarComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ec.gob.sri.ws.recepcion", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] xml;
        
        public validarComprobante() {
        }
        
        public validarComprobante(byte[] xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarComprobanteResponse", WrapperNamespace="http://ec.gob.sri.ws.recepcion", IsWrapped=true)]
    public partial class validarComprobanteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ec.gob.sri.ws.recepcion", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConsoleFactura.RecepcionComprobantesOffline.respuestaSolicitud RespuestaRecepcionComprobante;
        
        public validarComprobanteResponse() {
        }
        
        public validarComprobanteResponse(ConsoleFactura.RecepcionComprobantesOffline.respuestaSolicitud RespuestaRecepcionComprobante) {
            this.RespuestaRecepcionComprobante = RespuestaRecepcionComprobante;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RecepcionComprobantesOfflineChannel : ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecepcionComprobantesOfflineClient : System.ServiceModel.ClientBase<ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline>, ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline {
        
        public RecepcionComprobantesOfflineClient() {
        }
        
        public RecepcionComprobantesOfflineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecepcionComprobantesOfflineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcionComprobantesOfflineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcionComprobantesOfflineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleFactura.RecepcionComprobantesOffline.validarComprobanteResponse ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline.validarComprobante(ConsoleFactura.RecepcionComprobantesOffline.validarComprobante request) {
            return base.Channel.validarComprobante(request);
        }
        
        public ConsoleFactura.RecepcionComprobantesOffline.respuestaSolicitud validarComprobante(byte[] xml) {
            ConsoleFactura.RecepcionComprobantesOffline.validarComprobante inValue = new ConsoleFactura.RecepcionComprobantesOffline.validarComprobante();
            inValue.xml = xml;
            ConsoleFactura.RecepcionComprobantesOffline.validarComprobanteResponse retVal = ((ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline)(this)).validarComprobante(inValue);
            return retVal.RespuestaRecepcionComprobante;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleFactura.RecepcionComprobantesOffline.validarComprobanteResponse> ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline.validarComprobanteAsync(ConsoleFactura.RecepcionComprobantesOffline.validarComprobante request) {
            return base.Channel.validarComprobanteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleFactura.RecepcionComprobantesOffline.validarComprobanteResponse> validarComprobanteAsync(byte[] xml) {
            ConsoleFactura.RecepcionComprobantesOffline.validarComprobante inValue = new ConsoleFactura.RecepcionComprobantesOffline.validarComprobante();
            inValue.xml = xml;
            return ((ConsoleFactura.RecepcionComprobantesOffline.RecepcionComprobantesOffline)(this)).validarComprobanteAsync(inValue);
        }
    }
}
