﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFConsole.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WindowsFormsWcfToDb1.ServiceReference1.CompositeType GetDataUsingDataContract(WindowsFormsWcfToDb1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WindowsFormsWcfToDb1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WindowsFormsWcfToDb1.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        int InsertPerson(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        System.Threading.Tasks.Task<int> InsertPersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        int UpdatePerson(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        System.Threading.Tasks.Task<int> UpdatePersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        int DeletePerson(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        System.Threading.Tasks.Task<int> DeletePersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPerson", ReplyAction="http://tempuri.org/IService1/GetPersonResponse")]
        WindowsFormsWcfToDb1.ServiceReference1.Person GetPerson(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPerson", ReplyAction="http://tempuri.org/IService1/GetPersonResponse")]
        System.Threading.Tasks.Task<WindowsFormsWcfToDb1.ServiceReference1.Person> GetPersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        WindowsFormsWcfToDb1.ServiceReference1.Person[] GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<WindowsFormsWcfToDb1.ServiceReference1.Person[]> GetAllPersonsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFConsole.ServiceReference1.IService1>, WCFConsole.ServiceReference1.IService1 {
        
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
        
        public WindowsFormsWcfToDb1.ServiceReference1.CompositeType GetDataUsingDataContract(WindowsFormsWcfToDb1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsWcfToDb1.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WindowsFormsWcfToDb1.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertPerson(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.InsertPerson(p);
        }
        
        public System.Threading.Tasks.Task<int> InsertPersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.InsertPersonAsync(p);
        }
        
        public int UpdatePerson(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.UpdatePerson(p);
        }
        
        public System.Threading.Tasks.Task<int> UpdatePersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.UpdatePersonAsync(p);
        }
        
        public int DeletePerson(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.DeletePerson(p);
        }
        
        public System.Threading.Tasks.Task<int> DeletePersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.DeletePersonAsync(p);
        }
        
        public WindowsFormsWcfToDb1.ServiceReference1.Person GetPerson(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.GetPerson(p);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsWcfToDb1.ServiceReference1.Person> GetPersonAsync(WindowsFormsWcfToDb1.ServiceReference1.Person p) {
            return base.Channel.GetPersonAsync(p);
        }
        
        public WindowsFormsWcfToDb1.ServiceReference1.Person[] GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsWcfToDb1.ServiceReference1.Person[]> GetAllPersonsAsync() {
            return base.Channel.GetAllPersonsAsync();
        }
    }
}