﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMTop.Common.SmsServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusDO", Namespace="http://entity.send.sms.liming.com")]
    [System.SerializableAttribute()]
    public partial class StatusDO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int falseCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EMTop.Common.SmsServiceReference.ArrayOfString falseIDsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int successCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EMTop.Common.SmsServiceReference.ArrayOfString successIDsField;
        
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
        public int falseCount {
            get {
                return this.falseCountField;
            }
            set {
                if ((this.falseCountField.Equals(value) != true)) {
                    this.falseCountField = value;
                    this.RaisePropertyChanged("falseCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EMTop.Common.SmsServiceReference.ArrayOfString falseIDs {
            get {
                return this.falseIDsField;
            }
            set {
                if ((object.ReferenceEquals(this.falseIDsField, value) != true)) {
                    this.falseIDsField = value;
                    this.RaisePropertyChanged("falseIDs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int successCount {
            get {
                return this.successCountField;
            }
            set {
                if ((this.successCountField.Equals(value) != true)) {
                    this.successCountField = value;
                    this.RaisePropertyChanged("successCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EMTop.Common.SmsServiceReference.ArrayOfString successIDs {
            get {
                return this.successIDsField;
            }
            set {
                if ((object.ReferenceEquals(this.successIDsField, value) != true)) {
                    this.successIDsField = value;
                    this.RaisePropertyChanged("successIDs");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://send.sms.liming.com", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageDO", Namespace="http://entity.send.sms.liming.com")]
    [System.SerializableAttribute()]
    public partial class MessageDO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string batchIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string remoteIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string subUserIDField;
        
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
        public string batchID {
            get {
                return this.batchIDField;
            }
            set {
                if ((object.ReferenceEquals(this.batchIDField, value) != true)) {
                    this.batchIDField = value;
                    this.RaisePropertyChanged("batchID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile {
            get {
                return this.mobileField;
            }
            set {
                if ((object.ReferenceEquals(this.mobileField, value) != true)) {
                    this.mobileField = value;
                    this.RaisePropertyChanged("mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string remoteID {
            get {
                return this.remoteIDField;
            }
            set {
                if ((object.ReferenceEquals(this.remoteIDField, value) != true)) {
                    this.remoteIDField = value;
                    this.RaisePropertyChanged("remoteID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string subUserID {
            get {
                return this.subUserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.subUserIDField, value) != true)) {
                    this.subUserIDField = value;
                    this.RaisePropertyChanged("subUserID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageUcDO", Namespace="http://entity.send.sms.liming.com")]
    [System.SerializableAttribute()]
    public partial class MessageUcDO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string batchIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string remoteIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string subUserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ucCodeField;
        
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
        public string batchID {
            get {
                return this.batchIDField;
            }
            set {
                if ((object.ReferenceEquals(this.batchIDField, value) != true)) {
                    this.batchIDField = value;
                    this.RaisePropertyChanged("batchID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mobile {
            get {
                return this.mobileField;
            }
            set {
                if ((object.ReferenceEquals(this.mobileField, value) != true)) {
                    this.mobileField = value;
                    this.RaisePropertyChanged("mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string remoteID {
            get {
                return this.remoteIDField;
            }
            set {
                if ((object.ReferenceEquals(this.remoteIDField, value) != true)) {
                    this.remoteIDField = value;
                    this.RaisePropertyChanged("remoteID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string subUserID {
            get {
                return this.subUserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.subUserIDField, value) != true)) {
                    this.subUserIDField = value;
                    this.RaisePropertyChanged("subUserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ucCode {
            get {
                return this.ucCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ucCodeField, value) != true)) {
                    this.ucCodeField = value;
                    this.RaisePropertyChanged("ucCode");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://send.sms.liming.com", ConfigurationName="SmsServiceReference.SmsServicePortType")]
    public interface SmsServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        EMTop.Common.SmsServiceReference.StatusDO getStatus(string in0, string in1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<EMTop.Common.SmsServiceReference.StatusDO> getStatusAsync(string in0, string in1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string getBalance(string in0, string in1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> getBalanceAsync(string in0, string in1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string send(string in0, string in1, string in2, string in3, string in4, string in5);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> sendAsync(string in0, string in1, string in2, string in3, string in4, string in5);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string getPackageFormat(string in0, string in1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> getPackageFormatAsync(string in0, string in1);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string send3(string in0, string in1, string in2, EMTop.Common.SmsServiceReference.MessageDO[] in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> send3Async(string in0, string in1, string in2, EMTop.Common.SmsServiceReference.MessageDO[] in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string send2(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> send2Async(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string sendSmsByUC(string in0, string in1, EMTop.Common.SmsServiceReference.MessageUcDO[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> sendSmsByUCAsync(string in0, string in1, EMTop.Common.SmsServiceReference.MessageUcDO[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        string send4(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="out")]
        System.Threading.Tasks.Task<string> send4Async(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SmsServicePortTypeChannel : EMTop.Common.SmsServiceReference.SmsServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SmsServicePortTypeClient : System.ServiceModel.ClientBase<EMTop.Common.SmsServiceReference.SmsServicePortType>, EMTop.Common.SmsServiceReference.SmsServicePortType {
        
        public SmsServicePortTypeClient() {
        }
        
        public SmsServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SmsServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmsServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SmsServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EMTop.Common.SmsServiceReference.StatusDO getStatus(string in0, string in1) {
            return base.Channel.getStatus(in0, in1);
        }
        
        public System.Threading.Tasks.Task<EMTop.Common.SmsServiceReference.StatusDO> getStatusAsync(string in0, string in1) {
            return base.Channel.getStatusAsync(in0, in1);
        }
        
        public string getBalance(string in0, string in1) {
            return base.Channel.getBalance(in0, in1);
        }
        
        public System.Threading.Tasks.Task<string> getBalanceAsync(string in0, string in1) {
            return base.Channel.getBalanceAsync(in0, in1);
        }
        
        public string send(string in0, string in1, string in2, string in3, string in4, string in5) {
            return base.Channel.send(in0, in1, in2, in3, in4, in5);
        }
        
        public System.Threading.Tasks.Task<string> sendAsync(string in0, string in1, string in2, string in3, string in4, string in5) {
            return base.Channel.sendAsync(in0, in1, in2, in3, in4, in5);
        }
        
        public string getPackageFormat(string in0, string in1) {
            return base.Channel.getPackageFormat(in0, in1);
        }
        
        public System.Threading.Tasks.Task<string> getPackageFormatAsync(string in0, string in1) {
            return base.Channel.getPackageFormatAsync(in0, in1);
        }
        
        public string send3(string in0, string in1, string in2, EMTop.Common.SmsServiceReference.MessageDO[] in3) {
            return base.Channel.send3(in0, in1, in2, in3);
        }
        
        public System.Threading.Tasks.Task<string> send3Async(string in0, string in1, string in2, EMTop.Common.SmsServiceReference.MessageDO[] in3) {
            return base.Channel.send3Async(in0, in1, in2, in3);
        }
        
        public string send2(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2) {
            return base.Channel.send2(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<string> send2Async(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2) {
            return base.Channel.send2Async(in0, in1, in2);
        }
        
        public string sendSmsByUC(string in0, string in1, EMTop.Common.SmsServiceReference.MessageUcDO[] in2) {
            return base.Channel.sendSmsByUC(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<string> sendSmsByUCAsync(string in0, string in1, EMTop.Common.SmsServiceReference.MessageUcDO[] in2) {
            return base.Channel.sendSmsByUCAsync(in0, in1, in2);
        }
        
        public string send4(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2) {
            return base.Channel.send4(in0, in1, in2);
        }
        
        public System.Threading.Tasks.Task<string> send4Async(string in0, string in1, EMTop.Common.SmsServiceReference.MessageDO[] in2) {
            return base.Channel.send4Async(in0, in1, in2);
        }
    }
}
