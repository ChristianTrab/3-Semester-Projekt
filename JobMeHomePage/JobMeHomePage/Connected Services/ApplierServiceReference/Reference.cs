﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobMeHomePage.ApplierServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Applier", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Applier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BannerURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurrentJobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomePageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxRadiusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JobMeHomePage.ApplierServiceReference.JobCategory[] jobCategoryListField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BannerURL {
            get {
                return this.BannerURLField;
            }
            set {
                if ((object.ReferenceEquals(this.BannerURLField, value) != true)) {
                    this.BannerURLField = value;
                    this.RaisePropertyChanged("BannerURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Birthdate {
            get {
                return this.BirthdateField;
            }
            set {
                if ((this.BirthdateField.Equals(value) != true)) {
                    this.BirthdateField = value;
                    this.RaisePropertyChanged("Birthdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrentJob {
            get {
                return this.CurrentJobField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentJobField, value) != true)) {
                    this.CurrentJobField = value;
                    this.RaisePropertyChanged("CurrentJob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FName {
            get {
                return this.FNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FNameField, value) != true)) {
                    this.FNameField = value;
                    this.RaisePropertyChanged("FName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePage {
            get {
                return this.HomePageField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePageField, value) != true)) {
                    this.HomePageField = value;
                    this.RaisePropertyChanged("HomePage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageURL {
            get {
                return this.ImageURLField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageURLField, value) != true)) {
                    this.ImageURLField = value;
                    this.RaisePropertyChanged("ImageURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LName {
            get {
                return this.LNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LNameField, value) != true)) {
                    this.LNameField = value;
                    this.RaisePropertyChanged("LName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxRadius {
            get {
                return this.MaxRadiusField;
            }
            set {
                if ((this.MaxRadiusField.Equals(value) != true)) {
                    this.MaxRadiusField = value;
                    this.RaisePropertyChanged("MaxRadius");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JobMeHomePage.ApplierServiceReference.JobCategory[] jobCategoryList {
            get {
                return this.jobCategoryListField;
            }
            set {
                if ((object.ReferenceEquals(this.jobCategoryListField, value) != true)) {
                    this.jobCategoryListField = value;
                    this.RaisePropertyChanged("jobCategoryList");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="JobCategory", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class JobCategory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApplierServiceReference.IApplierService")]
    public interface IApplierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplierService/Create", ReplyAction="http://tempuri.org/IApplierService/CreateResponse")]
        void Create(JobMeHomePage.ApplierServiceReference.Applier applier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplierService/Create", ReplyAction="http://tempuri.org/IApplierService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(JobMeHomePage.ApplierServiceReference.Applier applier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplierService/GetAllAppliers", ReplyAction="http://tempuri.org/IApplierService/GetAllAppliersResponse")]
        JobMeHomePage.ApplierServiceReference.Applier[] GetAllAppliers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplierService/GetAllAppliers", ReplyAction="http://tempuri.org/IApplierService/GetAllAppliersResponse")]
        System.Threading.Tasks.Task<JobMeHomePage.ApplierServiceReference.Applier[]> GetAllAppliersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplierService/GetApplier", ReplyAction="http://tempuri.org/IApplierService/GetApplierResponse")]
        JobMeHomePage.ApplierServiceReference.Applier GetApplier(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplierService/GetApplier", ReplyAction="http://tempuri.org/IApplierService/GetApplierResponse")]
        System.Threading.Tasks.Task<JobMeHomePage.ApplierServiceReference.Applier> GetApplierAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplierServiceChannel : JobMeHomePage.ApplierServiceReference.IApplierService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplierServiceClient : System.ServiceModel.ClientBase<JobMeHomePage.ApplierServiceReference.IApplierService>, JobMeHomePage.ApplierServiceReference.IApplierService {
        
        public ApplierServiceClient() {
        }
        
        public ApplierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(JobMeHomePage.ApplierServiceReference.Applier applier) {
            base.Channel.Create(applier);
        }
        
        public System.Threading.Tasks.Task CreateAsync(JobMeHomePage.ApplierServiceReference.Applier applier) {
            return base.Channel.CreateAsync(applier);
        }
        
        public JobMeHomePage.ApplierServiceReference.Applier[] GetAllAppliers() {
            return base.Channel.GetAllAppliers();
        }
        
        public System.Threading.Tasks.Task<JobMeHomePage.ApplierServiceReference.Applier[]> GetAllAppliersAsync() {
            return base.Channel.GetAllAppliersAsync();
        }
        
        public JobMeHomePage.ApplierServiceReference.Applier GetApplier(int id) {
            return base.Channel.GetApplier(id);
        }
        
        public System.Threading.Tasks.Task<JobMeHomePage.ApplierServiceReference.Applier> GetApplierAsync(int id) {
            return base.Channel.GetApplierAsync(id);
        }
    }
}
