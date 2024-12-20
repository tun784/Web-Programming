﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Bai1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_BaiHat")]
	public partial class DBBaiHatDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Album(tbl_Album instance);
    partial void Updatetbl_Album(tbl_Album instance);
    partial void Deletetbl_Album(tbl_Album instance);
    partial void Inserttbl_TheLoai(tbl_TheLoai instance);
    partial void Updatetbl_TheLoai(tbl_TheLoai instance);
    partial void Deletetbl_TheLoai(tbl_TheLoai instance);
    partial void Inserttbl_BaiHat(tbl_BaiHat instance);
    partial void Updatetbl_BaiHat(tbl_BaiHat instance);
    partial void Deletetbl_BaiHat(tbl_BaiHat instance);
    partial void Inserttbl_ChiTietAlbum(tbl_ChiTietAlbum instance);
    partial void Updatetbl_ChiTietAlbum(tbl_ChiTietAlbum instance);
    partial void Deletetbl_ChiTietAlbum(tbl_ChiTietAlbum instance);
    partial void Inserttbl_NhacSi(tbl_NhacSi instance);
    partial void Updatetbl_NhacSi(tbl_NhacSi instance);
    partial void Deletetbl_NhacSi(tbl_NhacSi instance);
        #endregion
        public DBBaiHatDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_BaiHatConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
        public DBBaiHatDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBBaiHatDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBBaiHatDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBBaiHatDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Album> tbl_Albums
		{
			get
			{
				return this.GetTable<tbl_Album>();
			}
		}
		
		public System.Data.Linq.Table<tbl_TheLoai> tbl_TheLoais
		{
			get
			{
				return this.GetTable<tbl_TheLoai>();
			}
		}
		
		public System.Data.Linq.Table<tbl_BaiHat> tbl_BaiHats
		{
			get
			{
				return this.GetTable<tbl_BaiHat>();
			}
		}
		
		public System.Data.Linq.Table<tbl_ChiTietAlbum> tbl_ChiTietAlbums
		{
			get
			{
				return this.GetTable<tbl_ChiTietAlbum>();
			}
		}
		
		public System.Data.Linq.Table<tbl_NhacSi> tbl_NhacSis
		{
			get
			{
				return this.GetTable<tbl_NhacSi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Album")]
	public partial class tbl_Album : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaAlbum;
		
		private string _TenAlbum;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private string _AnhBia;
		
		private EntitySet<tbl_ChiTietAlbum> _tbl_ChiTietAlbums;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaAlbumChanging(int value);
    partial void OnMaAlbumChanged();
    partial void OnTenAlbumChanging(string value);
    partial void OnTenAlbumChanged();
    partial void OnNgayTaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTaoChanged();
    partial void OnAnhBiaChanging(string value);
    partial void OnAnhBiaChanged();
    #endregion
		
		public tbl_Album()
		{
			this._tbl_ChiTietAlbums = new EntitySet<tbl_ChiTietAlbum>(new Action<tbl_ChiTietAlbum>(this.attach_tbl_ChiTietAlbums), new Action<tbl_ChiTietAlbum>(this.detach_tbl_ChiTietAlbums));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAlbum", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaAlbum
		{
			get
			{
				return this._MaAlbum;
			}
			set
			{
				if ((this._MaAlbum != value))
				{
					this.OnMaAlbumChanging(value);
					this.SendPropertyChanging();
					this._MaAlbum = value;
					this.SendPropertyChanged("MaAlbum");
					this.OnMaAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenAlbum", DbType="NVarChar(50)")]
		public string TenAlbum
		{
			get
			{
				return this._TenAlbum;
			}
			set
			{
				if ((this._TenAlbum != value))
				{
					this.OnTenAlbumChanging(value);
					this.SendPropertyChanging();
					this._TenAlbum = value;
					this.SendPropertyChanged("TenAlbum");
					this.OnTenAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="Date")]
		public System.Nullable<System.DateTime> NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhBia", DbType="VarChar(50)")]
		public string AnhBia
		{
			get
			{
				return this._AnhBia;
			}
			set
			{
				if ((this._AnhBia != value))
				{
					this.OnAnhBiaChanging(value);
					this.SendPropertyChanging();
					this._AnhBia = value;
					this.SendPropertyChanged("AnhBia");
					this.OnAnhBiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Album_tbl_ChiTietAlbum", Storage="_tbl_ChiTietAlbums", ThisKey="MaAlbum", OtherKey="MaAB")]
		public EntitySet<tbl_ChiTietAlbum> tbl_ChiTietAlbums
		{
			get
			{
				return this._tbl_ChiTietAlbums;
			}
			set
			{
				this._tbl_ChiTietAlbums.Assign(value);
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
		
		private void attach_tbl_ChiTietAlbums(tbl_ChiTietAlbum entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Album = this;
		}
		
		private void detach_tbl_ChiTietAlbums(tbl_ChiTietAlbum entity)
		{
			this.SendPropertyChanging();
			entity.tbl_Album = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_TheLoai")]
	public partial class tbl_TheLoai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTheLoai;
		
		private string _TenTheLoai;
		
		private EntitySet<tbl_BaiHat> _tbl_BaiHats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTheLoaiChanging(int value);
    partial void OnMaTheLoaiChanged();
    partial void OnTenTheLoaiChanging(string value);
    partial void OnTenTheLoaiChanged();
    #endregion
		
		public tbl_TheLoai()
		{
			this._tbl_BaiHats = new EntitySet<tbl_BaiHat>(new Action<tbl_BaiHat>(this.attach_tbl_BaiHats), new Action<tbl_BaiHat>(this.detach_tbl_BaiHats));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTheLoai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTheLoai
		{
			get
			{
				return this._MaTheLoai;
			}
			set
			{
				if ((this._MaTheLoai != value))
				{
					this.OnMaTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaTheLoai = value;
					this.SendPropertyChanged("MaTheLoai");
					this.OnMaTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTheLoai", DbType="NVarChar(50)")]
		public string TenTheLoai
		{
			get
			{
				return this._TenTheLoai;
			}
			set
			{
				if ((this._TenTheLoai != value))
				{
					this.OnTenTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenTheLoai = value;
					this.SendPropertyChanged("TenTheLoai");
					this.OnTenTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_TheLoai_tbl_BaiHat", Storage="_tbl_BaiHats", ThisKey="MaTheLoai", OtherKey="MaTL")]
		public EntitySet<tbl_BaiHat> tbl_BaiHats
		{
			get
			{
				return this._tbl_BaiHats;
			}
			set
			{
				this._tbl_BaiHats.Assign(value);
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
		
		private void attach_tbl_BaiHats(tbl_BaiHat entity)
		{
			this.SendPropertyChanging();
			entity.tbl_TheLoai = this;
		}
		
		private void detach_tbl_BaiHats(tbl_BaiHat entity)
		{
			this.SendPropertyChanging();
			entity.tbl_TheLoai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_BaiHat")]
	public partial class tbl_BaiHat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaBH;
		
		private string _TenBH;
		
		private int _MaTL;
		
		private int _MaNS;
		
		private EntitySet<tbl_ChiTietAlbum> _tbl_ChiTietAlbums;
		
		private EntityRef<tbl_TheLoai> _tbl_TheLoai;
		
		private EntityRef<tbl_NhacSi> _tbl_NhacSi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBHChanging(int value);
    partial void OnMaBHChanged();
    partial void OnTenBHChanging(string value);
    partial void OnTenBHChanged();
    partial void OnMaTLChanging(int value);
    partial void OnMaTLChanged();
    partial void OnMaNSChanging(int value);
    partial void OnMaNSChanged();
    #endregion
		
		public tbl_BaiHat()
		{
			this._tbl_ChiTietAlbums = new EntitySet<tbl_ChiTietAlbum>(new Action<tbl_ChiTietAlbum>(this.attach_tbl_ChiTietAlbums), new Action<tbl_ChiTietAlbum>(this.detach_tbl_ChiTietAlbums));
			this._tbl_TheLoai = default(EntityRef<tbl_TheLoai>);
			this._tbl_NhacSi = default(EntityRef<tbl_NhacSi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaBH
		{
			get
			{
				return this._MaBH;
			}
			set
			{
				if ((this._MaBH != value))
				{
					this.OnMaBHChanging(value);
					this.SendPropertyChanging();
					this._MaBH = value;
					this.SendPropertyChanged("MaBH");
					this.OnMaBHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBH", DbType="NVarChar(50)")]
		public string TenBH
		{
			get
			{
				return this._TenBH;
			}
			set
			{
				if ((this._TenBH != value))
				{
					this.OnTenBHChanging(value);
					this.SendPropertyChanging();
					this._TenBH = value;
					this.SendPropertyChanged("TenBH");
					this.OnTenBHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTL", DbType="Int NOT NULL")]
		public int MaTL
		{
			get
			{
				return this._MaTL;
			}
			set
			{
				if ((this._MaTL != value))
				{
					if (this._tbl_TheLoai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTLChanging(value);
					this.SendPropertyChanging();
					this._MaTL = value;
					this.SendPropertyChanged("MaTL");
					this.OnMaTLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNS", DbType="Int NOT NULL")]
		public int MaNS
		{
			get
			{
				return this._MaNS;
			}
			set
			{
				if ((this._MaNS != value))
				{
					if (this._tbl_NhacSi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNSChanging(value);
					this.SendPropertyChanging();
					this._MaNS = value;
					this.SendPropertyChanged("MaNS");
					this.OnMaNSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_BaiHat_tbl_ChiTietAlbum", Storage="_tbl_ChiTietAlbums", ThisKey="MaBH", OtherKey="MaBH")]
		public EntitySet<tbl_ChiTietAlbum> tbl_ChiTietAlbums
		{
			get
			{
				return this._tbl_ChiTietAlbums;
			}
			set
			{
				this._tbl_ChiTietAlbums.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_TheLoai_tbl_BaiHat", Storage="_tbl_TheLoai", ThisKey="MaTL", OtherKey="MaTheLoai", IsForeignKey=true)]
		public tbl_TheLoai tbl_TheLoai
		{
			get
			{
				return this._tbl_TheLoai.Entity;
			}
			set
			{
				tbl_TheLoai previousValue = this._tbl_TheLoai.Entity;
				if (((previousValue != value) 
							|| (this._tbl_TheLoai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_TheLoai.Entity = null;
						previousValue.tbl_BaiHats.Remove(this);
					}
					this._tbl_TheLoai.Entity = value;
					if ((value != null))
					{
						value.tbl_BaiHats.Add(this);
						this._MaTL = value.MaTheLoai;
					}
					else
					{
						this._MaTL = default(int);
					}
					this.SendPropertyChanged("tbl_TheLoai");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_NhacSi_tbl_BaiHat", Storage="_tbl_NhacSi", ThisKey="MaNS", OtherKey="MaNhacSi", IsForeignKey=true)]
		public tbl_NhacSi tbl_NhacSi
		{
			get
			{
				return this._tbl_NhacSi.Entity;
			}
			set
			{
				tbl_NhacSi previousValue = this._tbl_NhacSi.Entity;
				if (((previousValue != value) 
							|| (this._tbl_NhacSi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_NhacSi.Entity = null;
						previousValue.tbl_BaiHats.Remove(this);
					}
					this._tbl_NhacSi.Entity = value;
					if ((value != null))
					{
						value.tbl_BaiHats.Add(this);
						this._MaNS = value.MaNhacSi;
					}
					else
					{
						this._MaNS = default(int);
					}
					this.SendPropertyChanged("tbl_NhacSi");
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
		
		private void attach_tbl_ChiTietAlbums(tbl_ChiTietAlbum entity)
		{
			this.SendPropertyChanging();
			entity.tbl_BaiHat = this;
		}
		
		private void detach_tbl_ChiTietAlbums(tbl_ChiTietAlbum entity)
		{
			this.SendPropertyChanging();
			entity.tbl_BaiHat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_ChiTietAlbum")]
	public partial class tbl_ChiTietAlbum : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaAB;
		
		private int _MaBH;
		
		private EntityRef<tbl_Album> _tbl_Album;
		
		private EntityRef<tbl_BaiHat> _tbl_BaiHat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaABChanging(int value);
    partial void OnMaABChanged();
    partial void OnMaBHChanging(int value);
    partial void OnMaBHChanged();
    #endregion
		
		public tbl_ChiTietAlbum()
		{
			this._tbl_Album = default(EntityRef<tbl_Album>);
			this._tbl_BaiHat = default(EntityRef<tbl_BaiHat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAB", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaAB
		{
			get
			{
				return this._MaAB;
			}
			set
			{
				if ((this._MaAB != value))
				{
					if (this._tbl_Album.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaABChanging(value);
					this.SendPropertyChanging();
					this._MaAB = value;
					this.SendPropertyChanged("MaAB");
					this.OnMaABChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaBH
		{
			get
			{
				return this._MaBH;
			}
			set
			{
				if ((this._MaBH != value))
				{
					if (this._tbl_BaiHat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBHChanging(value);
					this.SendPropertyChanging();
					this._MaBH = value;
					this.SendPropertyChanged("MaBH");
					this.OnMaBHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Album_tbl_ChiTietAlbum", Storage="_tbl_Album", ThisKey="MaAB", OtherKey="MaAlbum", IsForeignKey=true)]
		public tbl_Album tbl_Album
		{
			get
			{
				return this._tbl_Album.Entity;
			}
			set
			{
				tbl_Album previousValue = this._tbl_Album.Entity;
				if (((previousValue != value) 
							|| (this._tbl_Album.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_Album.Entity = null;
						previousValue.tbl_ChiTietAlbums.Remove(this);
					}
					this._tbl_Album.Entity = value;
					if ((value != null))
					{
						value.tbl_ChiTietAlbums.Add(this);
						this._MaAB = value.MaAlbum;
					}
					else
					{
						this._MaAB = default(int);
					}
					this.SendPropertyChanged("tbl_Album");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_BaiHat_tbl_ChiTietAlbum", Storage="_tbl_BaiHat", ThisKey="MaBH", OtherKey="MaBH", IsForeignKey=true)]
		public tbl_BaiHat tbl_BaiHat
		{
			get
			{
				return this._tbl_BaiHat.Entity;
			}
			set
			{
				tbl_BaiHat previousValue = this._tbl_BaiHat.Entity;
				if (((previousValue != value) 
							|| (this._tbl_BaiHat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_BaiHat.Entity = null;
						previousValue.tbl_ChiTietAlbums.Remove(this);
					}
					this._tbl_BaiHat.Entity = value;
					if ((value != null))
					{
						value.tbl_ChiTietAlbums.Add(this);
						this._MaBH = value.MaBH;
					}
					else
					{
						this._MaBH = default(int);
					}
					this.SendPropertyChanged("tbl_BaiHat");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_NhacSi")]
	public partial class tbl_NhacSi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNhacSi;
		
		private string _TenNhacSi;
		
		private string _Anh;
		
		private EntitySet<tbl_BaiHat> _tbl_BaiHats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhacSiChanging(int value);
    partial void OnMaNhacSiChanged();
    partial void OnTenNhacSiChanging(string value);
    partial void OnTenNhacSiChanged();
    partial void OnAnhChanging(string value);
    partial void OnAnhChanged();
    #endregion
		
		public tbl_NhacSi()
		{
			this._tbl_BaiHats = new EntitySet<tbl_BaiHat>(new Action<tbl_BaiHat>(this.attach_tbl_BaiHats), new Action<tbl_BaiHat>(this.detach_tbl_BaiHats));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhacSi", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNhacSi
		{
			get
			{
				return this._MaNhacSi;
			}
			set
			{
				if ((this._MaNhacSi != value))
				{
					this.OnMaNhacSiChanging(value);
					this.SendPropertyChanging();
					this._MaNhacSi = value;
					this.SendPropertyChanged("MaNhacSi");
					this.OnMaNhacSiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhacSi", DbType="NVarChar(50)")]
		public string TenNhacSi
		{
			get
			{
				return this._TenNhacSi;
			}
			set
			{
				if ((this._TenNhacSi != value))
				{
					this.OnTenNhacSiChanging(value);
					this.SendPropertyChanging();
					this._TenNhacSi = value;
					this.SendPropertyChanged("TenNhacSi");
					this.OnTenNhacSiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="VarChar(50)")]
		public string Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this.OnAnhChanging(value);
					this.SendPropertyChanging();
					this._Anh = value;
					this.SendPropertyChanged("Anh");
					this.OnAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_NhacSi_tbl_BaiHat", Storage="_tbl_BaiHats", ThisKey="MaNhacSi", OtherKey="MaNS")]
		public EntitySet<tbl_BaiHat> tbl_BaiHats
		{
			get
			{
				return this._tbl_BaiHats;
			}
			set
			{
				this._tbl_BaiHats.Assign(value);
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
		
		private void attach_tbl_BaiHats(tbl_BaiHat entity)
		{
			this.SendPropertyChanging();
			entity.tbl_NhacSi = this;
		}
		
		private void detach_tbl_BaiHats(tbl_BaiHat entity)
		{
			this.SendPropertyChanging();
			entity.tbl_NhacSi = null;
		}
	}
}
#pragma warning restore 1591
