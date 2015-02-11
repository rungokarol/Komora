﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Komora.Classes.DataBase
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Projekt_Inzynierski")]
	public partial class LinqDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHardwareConfiguration(HardwareConfiguration instance);
    partial void UpdateHardwareConfiguration(HardwareConfiguration instance);
    partial void DeleteHardwareConfiguration(HardwareConfiguration instance);
    partial void InsertMeasurementTable(MeasurementTable instance);
    partial void UpdateMeasurementTable(MeasurementTable instance);
    partial void DeleteMeasurementTable(MeasurementTable instance);
    partial void InsertMeasurment(Measurment instance);
    partial void UpdateMeasurment(Measurment instance);
    partial void DeleteMeasurment(Measurment instance);
    partial void InsertMeasurmentResult(MeasurmentResult instance);
    partial void UpdateMeasurmentResult(MeasurmentResult instance);
    partial void DeleteMeasurmentResult(MeasurmentResult instance);
    partial void InsertPt100_Poly(Pt100_Poly instance);
    partial void UpdatePt100_Poly(Pt100_Poly instance);
    partial void DeletePt100_Poly(Pt100_Poly instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public LinqDatabaseDataContext() : 
				base(global::Komora.Properties.Settings.Default.Projekt_InzynierskiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HardwareConfiguration> HardwareConfigurations
		{
			get
			{
				return this.GetTable<HardwareConfiguration>();
			}
		}
		
		public System.Data.Linq.Table<MeasurementTable> MeasurementTables
		{
			get
			{
				return this.GetTable<MeasurementTable>();
			}
		}
		
		public System.Data.Linq.Table<Measurment> Measurments
		{
			get
			{
				return this.GetTable<Measurment>();
			}
		}
		
		public System.Data.Linq.Table<MeasurmentResult> MeasurmentResults
		{
			get
			{
				return this.GetTable<MeasurmentResult>();
			}
		}
		
		public System.Data.Linq.Table<Pt100_Poly> Pt100_Polies
		{
			get
			{
				return this.GetTable<Pt100_Poly>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HardwareConfiguration")]
	public partial class HardwareConfiguration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _chamberName;
		
		private System.Nullable<int> _chamberNumber;
		
		private string _serialPort;
		
		private EntitySet<Pt100_Poly> _Pt100_Polies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnchamberNameChanging(string value);
    partial void OnchamberNameChanged();
    partial void OnchamberNumberChanging(System.Nullable<int> value);
    partial void OnchamberNumberChanged();
    partial void OnserialPortChanging(string value);
    partial void OnserialPortChanged();
    #endregion
		
		public HardwareConfiguration()
		{
			this._Pt100_Polies = new EntitySet<Pt100_Poly>(new Action<Pt100_Poly>(this.attach_Pt100_Polies), new Action<Pt100_Poly>(this.detach_Pt100_Polies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chamberName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string chamberName
		{
			get
			{
				return this._chamberName;
			}
			set
			{
				if ((this._chamberName != value))
				{
					this.OnchamberNameChanging(value);
					this.SendPropertyChanging();
					this._chamberName = value;
					this.SendPropertyChanged("chamberName");
					this.OnchamberNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chamberNumber", DbType="Int")]
		public System.Nullable<int> chamberNumber
		{
			get
			{
				return this._chamberNumber;
			}
			set
			{
				if ((this._chamberNumber != value))
				{
					this.OnchamberNumberChanging(value);
					this.SendPropertyChanging();
					this._chamberNumber = value;
					this.SendPropertyChanged("chamberNumber");
					this.OnchamberNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serialPort", DbType="NVarChar(50)")]
		public string serialPort
		{
			get
			{
				return this._serialPort;
			}
			set
			{
				if ((this._serialPort != value))
				{
					this.OnserialPortChanging(value);
					this.SendPropertyChanging();
					this._serialPort = value;
					this.SendPropertyChanged("serialPort");
					this.OnserialPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HardwareConfiguration_Pt100_Poly", Storage="_Pt100_Polies", ThisKey="ID", OtherKey="chamberID")]
		public EntitySet<Pt100_Poly> Pt100_Polies
		{
			get
			{
				return this._Pt100_Polies;
			}
			set
			{
				this._Pt100_Polies.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Pt100_Polies(Pt100_Poly entity)
		{
			this.SendPropertyChanging();
			entity.HardwareConfiguration = this;
		}
		
		private void detach_Pt100_Polies(Pt100_Poly entity)
		{
			this.SendPropertyChanging();
			entity.HardwareConfiguration = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MeasurementTable")]
	public partial class MeasurementTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Filename;
		
		private double _Weight;
		
		private string _Material;
		
		private string _Basic_AddInfo;
		
		private string _Synthesis_Laboratory;
		
		private string _Synthesis_Date;
		
		private string _Synthesis_Operator;
		
		private bool _Rejuvenation_After;
		
		private string _Rejuvenation_Date;
		
		private string _Rejuvenation_DarkAged;
		
		private string _RejuvenationSpecialAged;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFilenameChanging(string value);
    partial void OnFilenameChanged();
    partial void OnWeightChanging(double value);
    partial void OnWeightChanged();
    partial void OnMaterialChanging(string value);
    partial void OnMaterialChanged();
    partial void OnBasic_AddInfoChanging(string value);
    partial void OnBasic_AddInfoChanged();
    partial void OnSynthesis_LaboratoryChanging(string value);
    partial void OnSynthesis_LaboratoryChanged();
    partial void OnSynthesis_DateChanging(string value);
    partial void OnSynthesis_DateChanged();
    partial void OnSynthesis_OperatorChanging(string value);
    partial void OnSynthesis_OperatorChanged();
    partial void OnRejuvenation_AfterChanging(bool value);
    partial void OnRejuvenation_AfterChanged();
    partial void OnRejuvenation_DateChanging(string value);
    partial void OnRejuvenation_DateChanged();
    partial void OnRejuvenation_DarkAgedChanging(string value);
    partial void OnRejuvenation_DarkAgedChanged();
    partial void OnRejuvenationSpecialAgedChanging(string value);
    partial void OnRejuvenationSpecialAgedChanged();
    #endregion
		
		public MeasurementTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Filename", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			set
			{
				if ((this._Filename != value))
				{
					this.OnFilenameChanging(value);
					this.SendPropertyChanging();
					this._Filename = value;
					this.SendPropertyChanged("Filename");
					this.OnFilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Float NOT NULL")]
		public double Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Material", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Material
		{
			get
			{
				return this._Material;
			}
			set
			{
				if ((this._Material != value))
				{
					this.OnMaterialChanging(value);
					this.SendPropertyChanging();
					this._Material = value;
					this.SendPropertyChanged("Material");
					this.OnMaterialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Basic_AddInfo", DbType="NVarChar(100)")]
		public string Basic_AddInfo
		{
			get
			{
				return this._Basic_AddInfo;
			}
			set
			{
				if ((this._Basic_AddInfo != value))
				{
					this.OnBasic_AddInfoChanging(value);
					this.SendPropertyChanging();
					this._Basic_AddInfo = value;
					this.SendPropertyChanged("Basic_AddInfo");
					this.OnBasic_AddInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Synthesis_Laboratory", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Synthesis_Laboratory
		{
			get
			{
				return this._Synthesis_Laboratory;
			}
			set
			{
				if ((this._Synthesis_Laboratory != value))
				{
					this.OnSynthesis_LaboratoryChanging(value);
					this.SendPropertyChanging();
					this._Synthesis_Laboratory = value;
					this.SendPropertyChanged("Synthesis_Laboratory");
					this.OnSynthesis_LaboratoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Synthesis_Date", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Synthesis_Date
		{
			get
			{
				return this._Synthesis_Date;
			}
			set
			{
				if ((this._Synthesis_Date != value))
				{
					this.OnSynthesis_DateChanging(value);
					this.SendPropertyChanging();
					this._Synthesis_Date = value;
					this.SendPropertyChanged("Synthesis_Date");
					this.OnSynthesis_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Synthesis_Operator", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Synthesis_Operator
		{
			get
			{
				return this._Synthesis_Operator;
			}
			set
			{
				if ((this._Synthesis_Operator != value))
				{
					this.OnSynthesis_OperatorChanging(value);
					this.SendPropertyChanging();
					this._Synthesis_Operator = value;
					this.SendPropertyChanged("Synthesis_Operator");
					this.OnSynthesis_OperatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rejuvenation_After", DbType="Bit NOT NULL")]
		public bool Rejuvenation_After
		{
			get
			{
				return this._Rejuvenation_After;
			}
			set
			{
				if ((this._Rejuvenation_After != value))
				{
					this.OnRejuvenation_AfterChanging(value);
					this.SendPropertyChanging();
					this._Rejuvenation_After = value;
					this.SendPropertyChanged("Rejuvenation_After");
					this.OnRejuvenation_AfterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rejuvenation_Date", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Rejuvenation_Date
		{
			get
			{
				return this._Rejuvenation_Date;
			}
			set
			{
				if ((this._Rejuvenation_Date != value))
				{
					this.OnRejuvenation_DateChanging(value);
					this.SendPropertyChanging();
					this._Rejuvenation_Date = value;
					this.SendPropertyChanged("Rejuvenation_Date");
					this.OnRejuvenation_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rejuvenation_DarkAged", DbType="NVarChar(50)")]
		public string Rejuvenation_DarkAged
		{
			get
			{
				return this._Rejuvenation_DarkAged;
			}
			set
			{
				if ((this._Rejuvenation_DarkAged != value))
				{
					this.OnRejuvenation_DarkAgedChanging(value);
					this.SendPropertyChanging();
					this._Rejuvenation_DarkAged = value;
					this.SendPropertyChanged("Rejuvenation_DarkAged");
					this.OnRejuvenation_DarkAgedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RejuvenationSpecialAged", DbType="NVarChar(50)")]
		public string RejuvenationSpecialAged
		{
			get
			{
				return this._RejuvenationSpecialAged;
			}
			set
			{
				if ((this._RejuvenationSpecialAged != value))
				{
					this.OnRejuvenationSpecialAgedChanging(value);
					this.SendPropertyChanging();
					this._RejuvenationSpecialAged = value;
					this.SendPropertyChanged("RejuvenationSpecialAged");
					this.OnRejuvenationSpecialAgedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Measurment")]
	public partial class Measurment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _name;
		
		private string _filename;
		
		private EntitySet<MeasurmentResult> _MeasurmentResults;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnfilenameChanging(string value);
    partial void OnfilenameChanged();
    #endregion
		
		public Measurment()
		{
			this._MeasurmentResults = new EntitySet<MeasurmentResult>(new Action<MeasurmentResult>(this.attach_MeasurmentResults), new Action<MeasurmentResult>(this.detach_MeasurmentResults));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_filename", DbType="NVarChar(50)")]
		public string filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				if ((this._filename != value))
				{
					this.OnfilenameChanging(value);
					this.SendPropertyChanging();
					this._filename = value;
					this.SendPropertyChanged("filename");
					this.OnfilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Measurment_MeasurmentResult", Storage="_MeasurmentResults", ThisKey="ID", OtherKey="measurmentID")]
		public EntitySet<MeasurmentResult> MeasurmentResults
		{
			get
			{
				return this._MeasurmentResults;
			}
			set
			{
				this._MeasurmentResults.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_MeasurmentResults(MeasurmentResult entity)
		{
			this.SendPropertyChanging();
			entity.Measurment = this;
		}
		
		private void detach_MeasurmentResults(MeasurmentResult entity)
		{
			this.SendPropertyChanging();
			entity.Measurment = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MeasurmentResults")]
	public partial class MeasurmentResult : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private double _result;
		
		private string _date;
		
		private int _measurmentID;
		
		private EntityRef<Measurment> _Measurment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnresultChanging(double value);
    partial void OnresultChanged();
    partial void OndateChanging(string value);
    partial void OndateChanged();
    partial void OnmeasurmentIDChanging(int value);
    partial void OnmeasurmentIDChanged();
    #endregion
		
		public MeasurmentResult()
		{
			this._Measurment = default(EntityRef<Measurment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_result", DbType="Float NOT NULL")]
		public double result
		{
			get
			{
				return this._result;
			}
			set
			{
				if ((this._result != value))
				{
					this.OnresultChanging(value);
					this.SendPropertyChanging();
					this._result = value;
					this.SendPropertyChanged("result");
					this.OnresultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_measurmentID", DbType="Int NOT NULL")]
		public int measurmentID
		{
			get
			{
				return this._measurmentID;
			}
			set
			{
				if ((this._measurmentID != value))
				{
					if (this._Measurment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmeasurmentIDChanging(value);
					this.SendPropertyChanging();
					this._measurmentID = value;
					this.SendPropertyChanged("measurmentID");
					this.OnmeasurmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Measurment_MeasurmentResult", Storage="_Measurment", ThisKey="measurmentID", OtherKey="ID", IsForeignKey=true)]
		public Measurment Measurment
		{
			get
			{
				return this._Measurment.Entity;
			}
			set
			{
				Measurment previousValue = this._Measurment.Entity;
				if (((previousValue != value) 
							|| (this._Measurment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Measurment.Entity = null;
						previousValue.MeasurmentResults.Remove(this);
					}
					this._Measurment.Entity = value;
					if ((value != null))
					{
						value.MeasurmentResults.Add(this);
						this._measurmentID = value.ID;
					}
					else
					{
						this._measurmentID = default(int);
					}
					this.SendPropertyChanged("Measurment");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pt100_Poly")]
	public partial class Pt100_Poly : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Coefficients;
		
		private System.Nullable<int> _chamberID;
		
		private EntityRef<HardwareConfiguration> _HardwareConfiguration;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCoefficientsChanging(string value);
    partial void OnCoefficientsChanged();
    partial void OnchamberIDChanging(System.Nullable<int> value);
    partial void OnchamberIDChanged();
    #endregion
		
		public Pt100_Poly()
		{
			this._HardwareConfiguration = default(EntityRef<HardwareConfiguration>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coefficients", DbType="NVarChar(50)")]
		public string Coefficients
		{
			get
			{
				return this._Coefficients;
			}
			set
			{
				if ((this._Coefficients != value))
				{
					this.OnCoefficientsChanging(value);
					this.SendPropertyChanging();
					this._Coefficients = value;
					this.SendPropertyChanged("Coefficients");
					this.OnCoefficientsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chamberID", DbType="Int")]
		public System.Nullable<int> chamberID
		{
			get
			{
				return this._chamberID;
			}
			set
			{
				if ((this._chamberID != value))
				{
					if (this._HardwareConfiguration.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnchamberIDChanging(value);
					this.SendPropertyChanging();
					this._chamberID = value;
					this.SendPropertyChanged("chamberID");
					this.OnchamberIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HardwareConfiguration_Pt100_Poly", Storage="_HardwareConfiguration", ThisKey="chamberID", OtherKey="ID", IsForeignKey=true)]
		public HardwareConfiguration HardwareConfiguration
		{
			get
			{
				return this._HardwareConfiguration.Entity;
			}
			set
			{
				HardwareConfiguration previousValue = this._HardwareConfiguration.Entity;
				if (((previousValue != value) 
							|| (this._HardwareConfiguration.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HardwareConfiguration.Entity = null;
						previousValue.Pt100_Polies.Remove(this);
					}
					this._HardwareConfiguration.Entity = value;
					if ((value != null))
					{
						value.Pt100_Polies.Add(this);
						this._chamberID = value.ID;
					}
					else
					{
						this._chamberID = default(Nullable<int>);
					}
					this.SendPropertyChanged("HardwareConfiguration");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _username;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591