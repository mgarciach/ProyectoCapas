﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoCapas.Web.TiendaProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaginationOfArticuloDto6X_P_SBETV", Namespace="http://schemas.datacontract.org/2004/07/ProyectoCapas.Host.Core")]
    [System.SerializableAttribute()]
    public partial class PaginationOfArticuloDto6X_P_SBETV : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoCapas.Web.TiendaProxy.ArticuloDto[] itemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int totalField;
        
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
        public ProyectoCapas.Web.TiendaProxy.ArticuloDto[] items {
            get {
                return this.itemsField;
            }
            set {
                if ((object.ReferenceEquals(this.itemsField, value) != true)) {
                    this.itemsField = value;
                    this.RaisePropertyChanged("items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int page {
            get {
                return this.pageField;
            }
            set {
                if ((this.pageField.Equals(value) != true)) {
                    this.pageField = value;
                    this.RaisePropertyChanged("page");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                if ((this.pageSizeField.Equals(value) != true)) {
                    this.pageSizeField = value;
                    this.RaisePropertyChanged("pageSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ArticuloDto", Namespace="http://schemas.datacontract.org/2004/07/ProyectoCapas.Host.TransferObjects")]
    [System.SerializableAttribute()]
    public partial class ArticuloDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cod_artField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal prec_unicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public string cod_art {
            get {
                return this.cod_artField;
            }
            set {
                if ((object.ReferenceEquals(this.cod_artField, value) != true)) {
                    this.cod_artField = value;
                    this.RaisePropertyChanged("cod_art");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descrip {
            get {
                return this.descripField;
            }
            set {
                if ((object.ReferenceEquals(this.descripField, value) != true)) {
                    this.descripField = value;
                    this.RaisePropertyChanged("descrip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal prec_unic {
            get {
                return this.prec_unicField;
            }
            set {
                if ((this.prec_unicField.Equals(value) != true)) {
                    this.prec_unicField = value;
                    this.RaisePropertyChanged("prec_unic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PaginationOfClienteDto6X_P_SBETV", Namespace="http://schemas.datacontract.org/2004/07/ProyectoCapas.Host.Core")]
    [System.SerializableAttribute()]
    public partial class PaginationOfClienteDto6X_P_SBETV : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoCapas.Web.TiendaProxy.ClienteDto[] itemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int pageSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int totalField;
        
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
        public ProyectoCapas.Web.TiendaProxy.ClienteDto[] items {
            get {
                return this.itemsField;
            }
            set {
                if ((object.ReferenceEquals(this.itemsField, value) != true)) {
                    this.itemsField = value;
                    this.RaisePropertyChanged("items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int page {
            get {
                return this.pageField;
            }
            set {
                if ((this.pageField.Equals(value) != true)) {
                    this.pageField = value;
                    this.RaisePropertyChanged("page");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                if ((this.pageSizeField.Equals(value) != true)) {
                    this.pageSizeField = value;
                    this.RaisePropertyChanged("pageSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDto", Namespace="http://schemas.datacontract.org/2004/07/ProyectoCapas.Host.TransferObjects")]
    [System.SerializableAttribute()]
    public partial class ClienteDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cod_clieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mon_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefField;
        
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
        public string cod_clie {
            get {
                return this.cod_clieField;
            }
            set {
                if ((object.ReferenceEquals(this.cod_clieField, value) != true)) {
                    this.cod_clieField = value;
                    this.RaisePropertyChanged("cod_clie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dir {
            get {
                return this.dirField;
            }
            set {
                if ((object.ReferenceEquals(this.dirField, value) != true)) {
                    this.dirField = value;
                    this.RaisePropertyChanged("dir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                if ((object.ReferenceEquals(this.dniField, value) != true)) {
                    this.dniField = value;
                    this.RaisePropertyChanged("dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mon_ape {
            get {
                return this.mon_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.mon_apeField, value) != true)) {
                    this.mon_apeField = value;
                    this.RaisePropertyChanged("mon_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telef {
            get {
                return this.telefField;
            }
            set {
                if ((object.ReferenceEquals(this.telefField, value) != true)) {
                    this.telefField = value;
                    this.RaisePropertyChanged("telef");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TiendaProxy.ITiendaService")]
    public interface ITiendaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetPageArticulos", ReplyAction="http://tempuri.org/ITiendaService/GetPageArticulosResponse")]
        ProyectoCapas.Web.TiendaProxy.PaginationOfArticuloDto6X_P_SBETV GetPageArticulos(int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetPageArticulos", ReplyAction="http://tempuri.org/ITiendaService/GetPageArticulosResponse")]
        System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.PaginationOfArticuloDto6X_P_SBETV> GetPageArticulosAsync(int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetArticulo", ReplyAction="http://tempuri.org/ITiendaService/GetArticuloResponse")]
        ProyectoCapas.Web.TiendaProxy.ArticuloDto GetArticulo(string cod_art);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetArticulo", ReplyAction="http://tempuri.org/ITiendaService/GetArticuloResponse")]
        System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ArticuloDto> GetArticuloAsync(string cod_art);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/SaveArticulo", ReplyAction="http://tempuri.org/ITiendaService/SaveArticuloResponse")]
        void SaveArticulo(ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/SaveArticulo", ReplyAction="http://tempuri.org/ITiendaService/SaveArticuloResponse")]
        System.Threading.Tasks.Task SaveArticuloAsync(ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/UpdateArticulo", ReplyAction="http://tempuri.org/ITiendaService/UpdateArticuloResponse")]
        void UpdateArticulo(string cod_art, ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/UpdateArticulo", ReplyAction="http://tempuri.org/ITiendaService/UpdateArticuloResponse")]
        System.Threading.Tasks.Task UpdateArticuloAsync(string cod_art, ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/DeleteArticulo", ReplyAction="http://tempuri.org/ITiendaService/DeleteArticuloResponse")]
        void DeleteArticulo(string cod_art);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/DeleteArticulo", ReplyAction="http://tempuri.org/ITiendaService/DeleteArticuloResponse")]
        System.Threading.Tasks.Task DeleteArticuloAsync(string cod_art);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/ListArticulosByFilter", ReplyAction="http://tempuri.org/ITiendaService/ListArticulosByFilterResponse")]
        ProyectoCapas.Web.TiendaProxy.ArticuloDto[] ListArticulosByFilter(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/ListArticulosByFilter", ReplyAction="http://tempuri.org/ITiendaService/ListArticulosByFilterResponse")]
        System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ArticuloDto[]> ListArticulosByFilterAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetPageClientes", ReplyAction="http://tempuri.org/ITiendaService/GetPageClientesResponse")]
        ProyectoCapas.Web.TiendaProxy.PaginationOfClienteDto6X_P_SBETV GetPageClientes(int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetPageClientes", ReplyAction="http://tempuri.org/ITiendaService/GetPageClientesResponse")]
        System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.PaginationOfClienteDto6X_P_SBETV> GetPageClientesAsync(int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetCliente", ReplyAction="http://tempuri.org/ITiendaService/GetClienteResponse")]
        ProyectoCapas.Web.TiendaProxy.ClienteDto GetCliente(string cod_clie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/GetCliente", ReplyAction="http://tempuri.org/ITiendaService/GetClienteResponse")]
        System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ClienteDto> GetClienteAsync(string cod_clie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/SaveCliente", ReplyAction="http://tempuri.org/ITiendaService/SaveClienteResponse")]
        void SaveCliente(ProyectoCapas.Web.TiendaProxy.ClienteDto cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/SaveCliente", ReplyAction="http://tempuri.org/ITiendaService/SaveClienteResponse")]
        System.Threading.Tasks.Task SaveClienteAsync(ProyectoCapas.Web.TiendaProxy.ClienteDto cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/UpdateCliente", ReplyAction="http://tempuri.org/ITiendaService/UpdateClienteResponse")]
        void UpdateCliente(string cod_clie, ProyectoCapas.Web.TiendaProxy.ClienteDto cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/UpdateCliente", ReplyAction="http://tempuri.org/ITiendaService/UpdateClienteResponse")]
        System.Threading.Tasks.Task UpdateClienteAsync(string cod_clie, ProyectoCapas.Web.TiendaProxy.ClienteDto cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/DeleteCliente", ReplyAction="http://tempuri.org/ITiendaService/DeleteClienteResponse")]
        void DeleteCliente(string cod_clie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/DeleteCliente", ReplyAction="http://tempuri.org/ITiendaService/DeleteClienteResponse")]
        System.Threading.Tasks.Task DeleteClienteAsync(string cod_clie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/ListClientesByFilter", ReplyAction="http://tempuri.org/ITiendaService/ListClientesByFilterResponse")]
        ProyectoCapas.Web.TiendaProxy.ClienteDto[] ListClientesByFilter(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITiendaService/ListClientesByFilter", ReplyAction="http://tempuri.org/ITiendaService/ListClientesByFilterResponse")]
        System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ClienteDto[]> ListClientesByFilterAsync(string filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITiendaServiceChannel : ProyectoCapas.Web.TiendaProxy.ITiendaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TiendaServiceClient : System.ServiceModel.ClientBase<ProyectoCapas.Web.TiendaProxy.ITiendaService>, ProyectoCapas.Web.TiendaProxy.ITiendaService {
        
        public TiendaServiceClient() {
        }
        
        public TiendaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TiendaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TiendaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TiendaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProyectoCapas.Web.TiendaProxy.PaginationOfArticuloDto6X_P_SBETV GetPageArticulos(int page, int pageSize) {
            return base.Channel.GetPageArticulos(page, pageSize);
        }
        
        public System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.PaginationOfArticuloDto6X_P_SBETV> GetPageArticulosAsync(int page, int pageSize) {
            return base.Channel.GetPageArticulosAsync(page, pageSize);
        }
        
        public ProyectoCapas.Web.TiendaProxy.ArticuloDto GetArticulo(string cod_art) {
            return base.Channel.GetArticulo(cod_art);
        }
        
        public System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ArticuloDto> GetArticuloAsync(string cod_art) {
            return base.Channel.GetArticuloAsync(cod_art);
        }
        
        public void SaveArticulo(ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo) {
            base.Channel.SaveArticulo(articulo);
        }
        
        public System.Threading.Tasks.Task SaveArticuloAsync(ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo) {
            return base.Channel.SaveArticuloAsync(articulo);
        }
        
        public void UpdateArticulo(string cod_art, ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo) {
            base.Channel.UpdateArticulo(cod_art, articulo);
        }
        
        public System.Threading.Tasks.Task UpdateArticuloAsync(string cod_art, ProyectoCapas.Web.TiendaProxy.ArticuloDto articulo) {
            return base.Channel.UpdateArticuloAsync(cod_art, articulo);
        }
        
        public void DeleteArticulo(string cod_art) {
            base.Channel.DeleteArticulo(cod_art);
        }
        
        public System.Threading.Tasks.Task DeleteArticuloAsync(string cod_art) {
            return base.Channel.DeleteArticuloAsync(cod_art);
        }
        
        public ProyectoCapas.Web.TiendaProxy.ArticuloDto[] ListArticulosByFilter(string filter) {
            return base.Channel.ListArticulosByFilter(filter);
        }
        
        public System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ArticuloDto[]> ListArticulosByFilterAsync(string filter) {
            return base.Channel.ListArticulosByFilterAsync(filter);
        }
        
        public ProyectoCapas.Web.TiendaProxy.PaginationOfClienteDto6X_P_SBETV GetPageClientes(int page, int pageSize) {
            return base.Channel.GetPageClientes(page, pageSize);
        }
        
        public System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.PaginationOfClienteDto6X_P_SBETV> GetPageClientesAsync(int page, int pageSize) {
            return base.Channel.GetPageClientesAsync(page, pageSize);
        }
        
        public ProyectoCapas.Web.TiendaProxy.ClienteDto GetCliente(string cod_clie) {
            return base.Channel.GetCliente(cod_clie);
        }
        
        public System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ClienteDto> GetClienteAsync(string cod_clie) {
            return base.Channel.GetClienteAsync(cod_clie);
        }
        
        public void SaveCliente(ProyectoCapas.Web.TiendaProxy.ClienteDto cliente) {
            base.Channel.SaveCliente(cliente);
        }
        
        public System.Threading.Tasks.Task SaveClienteAsync(ProyectoCapas.Web.TiendaProxy.ClienteDto cliente) {
            return base.Channel.SaveClienteAsync(cliente);
        }
        
        public void UpdateCliente(string cod_clie, ProyectoCapas.Web.TiendaProxy.ClienteDto cliente) {
            base.Channel.UpdateCliente(cod_clie, cliente);
        }
        
        public System.Threading.Tasks.Task UpdateClienteAsync(string cod_clie, ProyectoCapas.Web.TiendaProxy.ClienteDto cliente) {
            return base.Channel.UpdateClienteAsync(cod_clie, cliente);
        }
        
        public void DeleteCliente(string cod_clie) {
            base.Channel.DeleteCliente(cod_clie);
        }
        
        public System.Threading.Tasks.Task DeleteClienteAsync(string cod_clie) {
            return base.Channel.DeleteClienteAsync(cod_clie);
        }
        
        public ProyectoCapas.Web.TiendaProxy.ClienteDto[] ListClientesByFilter(string filter) {
            return base.Channel.ListClientesByFilter(filter);
        }
        
        public System.Threading.Tasks.Task<ProyectoCapas.Web.TiendaProxy.ClienteDto[]> ListClientesByFilterAsync(string filter) {
            return base.Channel.ListClientesByFilterAsync(filter);
        }
    }
}
