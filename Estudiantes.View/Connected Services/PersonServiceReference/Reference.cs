﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estudiantes.View.PersonServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WCF_BD_CRUD")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonServiceReference.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        int AddPerson(Estudiantes.View.PersonServiceReference.Person[] people);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        System.Threading.Tasks.Task<int> AddPersonAsync(Estudiantes.View.PersonServiceReference.Person[] people);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        void UpdatePerson(Estudiantes.View.PersonServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(Estudiantes.View.PersonServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        void DeletePerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        Estudiantes.View.PersonServiceReference.Person GetPerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        System.Threading.Tasks.Task<Estudiantes.View.PersonServiceReference.Person> GetPersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        Estudiantes.View.PersonServiceReference.Person[] GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        System.Threading.Tasks.Task<Estudiantes.View.PersonServiceReference.Person[]> GetPeopleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : Estudiantes.View.PersonServiceReference.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<Estudiantes.View.PersonServiceReference.IPersonService>, Estudiantes.View.PersonServiceReference.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddPerson(Estudiantes.View.PersonServiceReference.Person[] people) {
            return base.Channel.AddPerson(people);
        }
        
        public System.Threading.Tasks.Task<int> AddPersonAsync(Estudiantes.View.PersonServiceReference.Person[] people) {
            return base.Channel.AddPersonAsync(people);
        }
        
        public void UpdatePerson(Estudiantes.View.PersonServiceReference.Person person) {
            base.Channel.UpdatePerson(person);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(Estudiantes.View.PersonServiceReference.Person person) {
            return base.Channel.UpdatePersonAsync(person);
        }
        
        public void DeletePerson(int id) {
            base.Channel.DeletePerson(id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int id) {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public Estudiantes.View.PersonServiceReference.Person GetPerson(int id) {
            return base.Channel.GetPerson(id);
        }
        
        public System.Threading.Tasks.Task<Estudiantes.View.PersonServiceReference.Person> GetPersonAsync(int id) {
            return base.Channel.GetPersonAsync(id);
        }
        
        public Estudiantes.View.PersonServiceReference.Person[] GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<Estudiantes.View.PersonServiceReference.Person[]> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
    }
}
