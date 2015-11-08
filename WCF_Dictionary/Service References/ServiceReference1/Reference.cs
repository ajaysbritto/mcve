﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Dictionary.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        // CODEGEN: Parameter 'GetDataResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WCF_Dictionary.ServiceReference1.GetDataResponse GetData(WCF_Dictionary.ServiceReference1.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<WCF_Dictionary.ServiceReference1.GetDataResponse> GetDataAsync(WCF_Dictionary.ServiceReference1.GetDataRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/BusinessObjects")]
    public partial class StringConfigItem : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string moduleNameField;
        
        private System.Data.DataSet stringValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string ModuleName {
            get {
                return this.moduleNameField;
            }
            set {
                this.moduleNameField = value;
                this.RaisePropertyChanged("ModuleName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Data.DataSet StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
                this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int value;
        
        public GetDataRequest() {
        }
        
        public GetDataRequest(int value) {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WCF_Dictionary.ServiceReference1.StringConfigItem GetDataResult;
        
        public GetDataResponse() {
        }
        
        public GetDataResponse(WCF_Dictionary.ServiceReference1.StringConfigItem GetDataResult) {
            this.GetDataResult = GetDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCF_Dictionary.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCF_Dictionary.ServiceReference1.IService1>, WCF_Dictionary.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF_Dictionary.ServiceReference1.GetDataResponse WCF_Dictionary.ServiceReference1.IService1.GetData(WCF_Dictionary.ServiceReference1.GetDataRequest request) {
            return base.Channel.GetData(request);
        }
        
        public WCF_Dictionary.ServiceReference1.StringConfigItem GetData(int value) {
            WCF_Dictionary.ServiceReference1.GetDataRequest inValue = new WCF_Dictionary.ServiceReference1.GetDataRequest();
            inValue.value = value;
            WCF_Dictionary.ServiceReference1.GetDataResponse retVal = ((WCF_Dictionary.ServiceReference1.IService1)(this)).GetData(inValue);
            return retVal.GetDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCF_Dictionary.ServiceReference1.GetDataResponse> WCF_Dictionary.ServiceReference1.IService1.GetDataAsync(WCF_Dictionary.ServiceReference1.GetDataRequest request) {
            return base.Channel.GetDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCF_Dictionary.ServiceReference1.GetDataResponse> GetDataAsync(int value) {
            WCF_Dictionary.ServiceReference1.GetDataRequest inValue = new WCF_Dictionary.ServiceReference1.GetDataRequest();
            inValue.value = value;
            return ((WCF_Dictionary.ServiceReference1.IService1)(this)).GetDataAsync(inValue);
        }
    }
}
