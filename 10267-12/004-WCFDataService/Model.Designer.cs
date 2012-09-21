﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model", "FK_CustomerAddress_Customer_CustomerID", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(_004_WCFDataService.Cliente), "CustomerAddress", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(_004_WCFDataService.Endereco), true)]

#endregion

namespace _004_WCFDataService
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdventureWorksLT2008Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AdventureWorksLT2008Entities object using the connection string found in the 'AdventureWorksLT2008Entities' section of the application configuration file.
        /// </summary>
        public AdventureWorksLT2008Entities() : base("name=AdventureWorksLT2008Entities", "AdventureWorksLT2008Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorksLT2008Entities object.
        /// </summary>
        public AdventureWorksLT2008Entities(string connectionString) : base(connectionString, "AdventureWorksLT2008Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorksLT2008Entities object.
        /// </summary>
        public AdventureWorksLT2008Entities(EntityConnection connection) : base(connection, "AdventureWorksLT2008Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cliente> Clientes
        {
            get
            {
                if ((_Clientes == null))
                {
                    _Clientes = base.CreateObjectSet<Cliente>("Clientes");
                }
                return _Clientes;
            }
        }
        private ObjectSet<Cliente> _Clientes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Endereco> Enderecos
        {
            get
            {
                if ((_Enderecos == null))
                {
                    _Enderecos = base.CreateObjectSet<Endereco>("Enderecos");
                }
                return _Enderecos;
            }
        }
        private ObjectSet<Endereco> _Enderecos;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Clientes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClientes(Cliente cliente)
        {
            base.AddObject("Clientes", cliente);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Enderecos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEnderecos(Endereco endereco)
        {
            base.AddObject("Enderecos", endereco);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Cliente")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cliente : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cliente object.
        /// </summary>
        /// <param name="customerID">Initial value of the CustomerID property.</param>
        /// <param name="nameStyle">Initial value of the NameStyle property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="passwordHash">Initial value of the PasswordHash property.</param>
        /// <param name="passwordSalt">Initial value of the PasswordSalt property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Cliente CreateCliente(global::System.Int32 customerID, global::System.Boolean nameStyle, global::System.String firstName, global::System.String lastName, global::System.String passwordHash, global::System.String passwordSalt, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Cliente cliente = new Cliente();
            cliente.CustomerID = customerID;
            cliente.NameStyle = nameStyle;
            cliente.FirstName = firstName;
            cliente.LastName = lastName;
            cliente.PasswordHash = passwordHash;
            cliente.PasswordSalt = passwordSalt;
            cliente.rowguid = rowguid;
            cliente.ModifiedDate = modifiedDate;
            return cliente;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.Int32 _CustomerID;
        partial void OnCustomerIDChanging(global::System.Int32 value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean NameStyle
        {
            get
            {
                return _NameStyle;
            }
            set
            {
                OnNameStyleChanging(value);
                ReportPropertyChanging("NameStyle");
                _NameStyle = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NameStyle");
                OnNameStyleChanged();
            }
        }
        private global::System.Boolean _NameStyle;
        partial void OnNameStyleChanging(global::System.Boolean value);
        partial void OnNameStyleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Suffix
        {
            get
            {
                return _Suffix;
            }
            set
            {
                OnSuffixChanging(value);
                ReportPropertyChanging("Suffix");
                _Suffix = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Suffix");
                OnSuffixChanged();
            }
        }
        private global::System.String _Suffix;
        partial void OnSuffixChanging(global::System.String value);
        partial void OnSuffixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SalesPerson
        {
            get
            {
                return _SalesPerson;
            }
            set
            {
                OnSalesPersonChanging(value);
                ReportPropertyChanging("SalesPerson");
                _SalesPerson = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SalesPerson");
                OnSalesPersonChanged();
            }
        }
        private global::System.String _SalesPerson;
        partial void OnSalesPersonChanging(global::System.String value);
        partial void OnSalesPersonChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordHash
        {
            get
            {
                return _PasswordHash;
            }
            set
            {
                OnPasswordHashChanging(value);
                ReportPropertyChanging("PasswordHash");
                _PasswordHash = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PasswordHash");
                OnPasswordHashChanged();
            }
        }
        private global::System.String _PasswordHash;
        partial void OnPasswordHashChanging(global::System.String value);
        partial void OnPasswordHashChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordSalt
        {
            get
            {
                return _PasswordSalt;
            }
            set
            {
                OnPasswordSaltChanging(value);
                ReportPropertyChanging("PasswordSalt");
                _PasswordSalt = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PasswordSalt");
                OnPasswordSaltChanged();
            }
        }
        private global::System.String _PasswordSalt;
        partial void OnPasswordSaltChanging(global::System.String value);
        partial void OnPasswordSaltChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_CustomerAddress_Customer_CustomerID", "CustomerAddress")]
        public EntityCollection<Endereco> Endereco
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Endereco>("Model.FK_CustomerAddress_Customer_CustomerID", "CustomerAddress");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Endereco>("Model.FK_CustomerAddress_Customer_CustomerID", "CustomerAddress", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Endereco")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Endereco : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Endereco object.
        /// </summary>
        /// <param name="customerID">Initial value of the CustomerID property.</param>
        /// <param name="addressID">Initial value of the AddressID property.</param>
        /// <param name="addressType">Initial value of the AddressType property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Endereco CreateEndereco(global::System.Int32 customerID, global::System.Int32 addressID, global::System.String addressType, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Endereco endereco = new Endereco();
            endereco.CustomerID = customerID;
            endereco.AddressID = addressID;
            endereco.AddressType = addressType;
            endereco.rowguid = rowguid;
            endereco.ModifiedDate = modifiedDate;
            return endereco;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.Int32 _CustomerID;
        partial void OnCustomerIDChanging(global::System.Int32 value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AddressID
        {
            get
            {
                return _AddressID;
            }
            set
            {
                if (_AddressID != value)
                {
                    OnAddressIDChanging(value);
                    ReportPropertyChanging("AddressID");
                    _AddressID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AddressID");
                    OnAddressIDChanged();
                }
            }
        }
        private global::System.Int32 _AddressID;
        partial void OnAddressIDChanging(global::System.Int32 value);
        partial void OnAddressIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AddressType
        {
            get
            {
                return _AddressType;
            }
            set
            {
                OnAddressTypeChanging(value);
                ReportPropertyChanging("AddressType");
                _AddressType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AddressType");
                OnAddressTypeChanged();
            }
        }
        private global::System.String _AddressType;
        partial void OnAddressTypeChanging(global::System.String value);
        partial void OnAddressTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_CustomerAddress_Customer_CustomerID", "Customer")]
        public Cliente Cliente
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cliente>("Model.FK_CustomerAddress_Customer_CustomerID", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cliente>("Model.FK_CustomerAddress_Customer_CustomerID", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Cliente> ClienteReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Cliente>("Model.FK_CustomerAddress_Customer_CustomerID", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Cliente>("Model.FK_CustomerAddress_Customer_CustomerID", "Customer", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}