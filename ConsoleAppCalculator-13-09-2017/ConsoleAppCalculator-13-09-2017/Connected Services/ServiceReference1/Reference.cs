﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppCalculator_13_09_2017.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceCalculatorRolf")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        double Add(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Subtract", ReplyAction="http://tempuri.org/IService1/SubtractResponse")]
        double Subtract(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Subtract", ReplyAction="http://tempuri.org/IService1/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiply", ReplyAction="http://tempuri.org/IService1/MultiplyResponse")]
        double Multiply(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiply", ReplyAction="http://tempuri.org/IService1/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        double Divide(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Divide", ReplyAction="http://tempuri.org/IService1/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType GetDataUsingDataContract(ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleAppCalculator_13_09_2017.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleAppCalculator_13_09_2017.ServiceReference1.IService1>, ConsoleAppCalculator_13_09_2017.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public double Add(double a, double b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double a, double b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public double Subtract(double a, double b) {
            return base.Channel.Subtract(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double a, double b) {
            return base.Channel.SubtractAsync(a, b);
        }
        
        public double Multiply(double a, double b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public double Divide(double a, double b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double a, double b) {
            return base.Channel.DivideAsync(a, b);
        }
        
        public ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType GetDataUsingDataContract(ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ConsoleAppCalculator_13_09_2017.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
