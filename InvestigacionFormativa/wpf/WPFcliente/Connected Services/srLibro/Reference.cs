//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFcliente.srLibro {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srLibro.LibroSoap")]
    public interface LibroSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Agregar(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AgregarAsync(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Eliminar(string codLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string> EliminarAsync(string codLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Actualizar(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ActualizarAsync(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string parametro, string texto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string parametro, string texto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LibroSoapChannel : WPFcliente.srLibro.LibroSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibroSoapClient : System.ServiceModel.ClientBase<WPFcliente.srLibro.LibroSoap>, WPFcliente.srLibro.LibroSoap {
        
        public LibroSoapClient() {
        }
        
        public LibroSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibroSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibroSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibroSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string Agregar(string codLibro, string titulo, string editorial) {
            return base.Channel.Agregar(codLibro, titulo, editorial);
        }
        
        public System.Threading.Tasks.Task<string> AgregarAsync(string codLibro, string titulo, string editorial) {
            return base.Channel.AgregarAsync(codLibro, titulo, editorial);
        }
        
        public string Eliminar(string codLibro) {
            return base.Channel.Eliminar(codLibro);
        }
        
        public System.Threading.Tasks.Task<string> EliminarAsync(string codLibro) {
            return base.Channel.EliminarAsync(codLibro);
        }
        
        public string Actualizar(string codLibro, string titulo, string editorial) {
            return base.Channel.Actualizar(codLibro, titulo, editorial);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarAsync(string codLibro, string titulo, string editorial) {
            return base.Channel.ActualizarAsync(codLibro, titulo, editorial);
        }
        
        public System.Data.DataSet Buscar(string parametro, string texto) {
            return base.Channel.Buscar(parametro, texto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string parametro, string texto) {
            return base.Channel.BuscarAsync(parametro, texto);
        }
    }
}
