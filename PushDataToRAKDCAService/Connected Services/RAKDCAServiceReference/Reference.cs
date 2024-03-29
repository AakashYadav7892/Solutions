﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.RAKDCAServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ega.rak.ae/xi/DCA/RevenuePostings", ConfigurationName="RAKDCAServiceReference.SI_DCA_OB")]
    public interface SI_DCA_OB {
        
        // CODEGEN: Generating message contract since the operation SI_DCA_OB is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBResponse SI_DCA_OB(ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBResponse> SI_DCA_OBAsync(ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ega.rak.ae/xi/DCA/RevenuePostings")]
    public partial class DT_DCA_SENDERFIFields : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string documentDateField;
        
        private string fiscalYearField;
        
        private string documentheaderreferenceField;
        
        private string serviceCodeField;
        
        private string serviceDescriptionField;
        
        private string companyCodeField;
        
        private string currencyField;
        
        private string gLNumberField;
        
        private string grossAmountField;
        
        private string netAmountField;
        
        private string taxAmountField;
        
        private string taxCodeField;
        
        private string taxPercentageField;
        
        private string assignmentFieldField;
        
        private string lineItemTextField;
        
        private string uniqueNumbergeneratedfromSharepointsystemField;
        
        private string createdDateField;
        
        private string createdTimeField;
        
        private string createdByUserIdField;
        
        private string customField1Field;
        
        private string customField2Field;
        
        private string customField3Field;
        
        private string customField4Field;
        
        private string customField5Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string DocumentDate {
            get {
                return this.documentDateField;
            }
            set {
                this.documentDateField = value;
                this.RaisePropertyChanged("DocumentDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string FiscalYear {
            get {
                return this.fiscalYearField;
            }
            set {
                this.fiscalYearField = value;
                this.RaisePropertyChanged("FiscalYear");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Documentheaderreference {
            get {
                return this.documentheaderreferenceField;
            }
            set {
                this.documentheaderreferenceField = value;
                this.RaisePropertyChanged("Documentheaderreference");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string ServiceCode {
            get {
                return this.serviceCodeField;
            }
            set {
                this.serviceCodeField = value;
                this.RaisePropertyChanged("ServiceCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ServiceDescription {
            get {
                return this.serviceDescriptionField;
            }
            set {
                this.serviceDescriptionField = value;
                this.RaisePropertyChanged("ServiceDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string CompanyCode {
            get {
                return this.companyCodeField;
            }
            set {
                this.companyCodeField = value;
                this.RaisePropertyChanged("CompanyCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("Currency");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string GLNumber {
            get {
                return this.gLNumberField;
            }
            set {
                this.gLNumberField = value;
                this.RaisePropertyChanged("GLNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string GrossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
                this.RaisePropertyChanged("GrossAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string NetAmount {
            get {
                return this.netAmountField;
            }
            set {
                this.netAmountField = value;
                this.RaisePropertyChanged("NetAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string TaxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
                this.RaisePropertyChanged("TaxAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string TaxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
                this.RaisePropertyChanged("TaxCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string TaxPercentage {
            get {
                return this.taxPercentageField;
            }
            set {
                this.taxPercentageField = value;
                this.RaisePropertyChanged("TaxPercentage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string AssignmentField {
            get {
                return this.assignmentFieldField;
            }
            set {
                this.assignmentFieldField = value;
                this.RaisePropertyChanged("AssignmentField");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string LineItemText {
            get {
                return this.lineItemTextField;
            }
            set {
                this.lineItemTextField = value;
                this.RaisePropertyChanged("LineItemText");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string UniqueNumbergeneratedfromSharepointsystem {
            get {
                return this.uniqueNumbergeneratedfromSharepointsystemField;
            }
            set {
                this.uniqueNumbergeneratedfromSharepointsystemField = value;
                this.RaisePropertyChanged("UniqueNumbergeneratedfromSharepointsystem");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string CreatedDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
                this.RaisePropertyChanged("CreatedDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string CreatedTime {
            get {
                return this.createdTimeField;
            }
            set {
                this.createdTimeField = value;
                this.RaisePropertyChanged("CreatedTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string CreatedByUserId {
            get {
                return this.createdByUserIdField;
            }
            set {
                this.createdByUserIdField = value;
                this.RaisePropertyChanged("CreatedByUserId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public string CustomField1 {
            get {
                return this.customField1Field;
            }
            set {
                this.customField1Field = value;
                this.RaisePropertyChanged("CustomField1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string CustomField2 {
            get {
                return this.customField2Field;
            }
            set {
                this.customField2Field = value;
                this.RaisePropertyChanged("CustomField2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string CustomField3 {
            get {
                return this.customField3Field;
            }
            set {
                this.customField3Field = value;
                this.RaisePropertyChanged("CustomField3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string CustomField4 {
            get {
                return this.customField4Field;
            }
            set {
                this.customField4Field = value;
                this.RaisePropertyChanged("CustomField4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public string CustomField5 {
            get {
                return this.customField5Field;
            }
            set {
                this.customField5Field = value;
                this.RaisePropertyChanged("CustomField5");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ega.rak.ae/xi/DCA/RevenuePostings")]
    public partial class DT_DCA_RECEIVER : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string rEFNUMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string REFNUM {
            get {
                return this.rEFNUMField;
            }
            set {
                this.rEFNUMField = value;
                this.RaisePropertyChanged("REFNUM");
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
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_DCA_OBRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ega.rak.ae/xi/DCA/RevenuePostings", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FIFields", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ConsoleApp1.RAKDCAServiceReference.DT_DCA_SENDERFIFields[] MT_DCA_SENDER;
        
        public SI_DCA_OBRequest() {
        }
        
        public SI_DCA_OBRequest(ConsoleApp1.RAKDCAServiceReference.DT_DCA_SENDERFIFields[] MT_DCA_SENDER) {
            this.MT_DCA_SENDER = MT_DCA_SENDER;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_DCA_OBResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ega.rak.ae/xi/DCA/RevenuePostings", Order=0)]
        public ConsoleApp1.RAKDCAServiceReference.DT_DCA_RECEIVER MT_DCA_RECEIVER;
        
        public SI_DCA_OBResponse() {
        }
        
        public SI_DCA_OBResponse(ConsoleApp1.RAKDCAServiceReference.DT_DCA_RECEIVER MT_DCA_RECEIVER) {
            this.MT_DCA_RECEIVER = MT_DCA_RECEIVER;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SI_DCA_OBChannel : ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SI_DCA_OBClient : System.ServiceModel.ClientBase<ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB>, ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB {
        
        public SI_DCA_OBClient() {
        }
        
        public SI_DCA_OBClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SI_DCA_OBClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SI_DCA_OBClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SI_DCA_OBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBResponse ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB.SI_DCA_OB(ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest request) {
            return base.Channel.SI_DCA_OB(request);
        }
        
        public ConsoleApp1.RAKDCAServiceReference.DT_DCA_RECEIVER SI_DCA_OB(ConsoleApp1.RAKDCAServiceReference.DT_DCA_SENDERFIFields[] MT_DCA_SENDER) {
            ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest inValue = new ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest();
            inValue.MT_DCA_SENDER = MT_DCA_SENDER;
            ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBResponse retVal = ((ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB)(this)).SI_DCA_OB(inValue);
            return retVal.MT_DCA_RECEIVER;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBResponse> ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB.SI_DCA_OBAsync(ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest request) {
            return base.Channel.SI_DCA_OBAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBResponse> SI_DCA_OBAsync(ConsoleApp1.RAKDCAServiceReference.DT_DCA_SENDERFIFields[] MT_DCA_SENDER) {
            ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest inValue = new ConsoleApp1.RAKDCAServiceReference.SI_DCA_OBRequest();
            inValue.MT_DCA_SENDER = MT_DCA_SENDER;
            return ((ConsoleApp1.RAKDCAServiceReference.SI_DCA_OB)(this)).SI_DCA_OBAsync(inValue);
        }
    }
}
