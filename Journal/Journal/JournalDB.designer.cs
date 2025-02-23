﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Journal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="University")]
	public partial class JournalDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertGrade(Grade instance);
    partial void UpdateGrade(Grade instance);
    partial void DeleteGrade(Grade instance);
    partial void InsertAuditories(Auditories instance);
    partial void UpdateAuditories(Auditories instance);
    partial void DeleteAuditories(Auditories instance);
    partial void InsertGroups(Groups instance);
    partial void UpdateGroups(Groups instance);
    partial void DeleteGroups(Groups instance);
    partial void InsertTimeTable(TimeTable instance);
    partial void UpdateTimeTable(TimeTable instance);
    partial void DeleteTimeTable(TimeTable instance);
    partial void InsertTeacher(Teacher instance);
    partial void UpdateTeacher(Teacher instance);
    partial void DeleteTeacher(Teacher instance);
    partial void InsertSubjects(Subjects instance);
    partial void UpdateSubjects(Subjects instance);
    partial void DeleteSubjects(Subjects instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public JournalDBDataContext() : 
				base(global::Journal.Properties.Settings.Default.UniversityConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public JournalDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JournalDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JournalDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public JournalDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Grade> Grade
		{
			get
			{
				return this.GetTable<Grade>();
			}
		}
		
		public System.Data.Linq.Table<Auditories> Auditories
		{
			get
			{
				return this.GetTable<Auditories>();
			}
		}
		
		public System.Data.Linq.Table<Groups> Groups
		{
			get
			{
				return this.GetTable<Groups>();
			}
		}
		
		public System.Data.Linq.Table<TimeTable> TimeTable
		{
			get
			{
				return this.GetTable<TimeTable>();
			}
		}
		
		public System.Data.Linq.Table<Teacher> Teacher
		{
			get
			{
				return this.GetTable<Teacher>();
			}
		}
		
		public System.Data.Linq.Table<Subjects> Subjects
		{
			get
			{
				return this.GetTable<Subjects>();
			}
		}
		
		public System.Data.Linq.Table<Student> Student
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Grade")]
	public partial class Grade : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _TeacherId;
		
		private System.Nullable<int> _StudentId;
		
		private System.Nullable<int> _SubjectId;
		
		private EntityRef<Teacher> _Teacher;
		
		private EntityRef<Subjects> _Subjects;
		
		private EntityRef<Student> _Student;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTeacherIdChanging(System.Nullable<int> value);
    partial void OnTeacherIdChanged();
    partial void OnStudentIdChanging(System.Nullable<int> value);
    partial void OnStudentIdChanged();
    partial void OnSubjectIdChanging(System.Nullable<int> value);
    partial void OnSubjectIdChanged();
    #endregion
		
		public Grade()
		{
			this._Teacher = default(EntityRef<Teacher>);
			this._Subjects = default(EntityRef<Subjects>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherId", DbType="Int")]
		public System.Nullable<int> TeacherId
		{
			get
			{
				return this._TeacherId;
			}
			set
			{
				if ((this._TeacherId != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeacherIdChanging(value);
					this.SendPropertyChanging();
					this._TeacherId = value;
					this.SendPropertyChanged("TeacherId");
					this.OnTeacherIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int")]
		public System.Nullable<int> StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectId", DbType="Int")]
		public System.Nullable<int> SubjectId
		{
			get
			{
				return this._SubjectId;
			}
			set
			{
				if ((this._SubjectId != value))
				{
					if (this._Subjects.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectIdChanging(value);
					this.SendPropertyChanging();
					this._SubjectId = value;
					this.SendPropertyChanged("SubjectId");
					this.OnSubjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Grade", Storage="_Teacher", ThisKey="TeacherId", OtherKey="Id", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.Grade.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.Grade.Add(this);
						this._TeacherId = value.Id;
					}
					else
					{
						this._TeacherId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Teacher");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_Grade", Storage="_Subjects", ThisKey="SubjectId", OtherKey="Id", IsForeignKey=true)]
		public Subjects Subjects
		{
			get
			{
				return this._Subjects.Entity;
			}
			set
			{
				Subjects previousValue = this._Subjects.Entity;
				if (((previousValue != value) 
							|| (this._Subjects.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subjects.Entity = null;
						previousValue.Grade.Remove(this);
					}
					this._Subjects.Entity = value;
					if ((value != null))
					{
						value.Grade.Add(this);
						this._SubjectId = value.Id;
					}
					else
					{
						this._SubjectId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Subjects");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Grade", Storage="_Student", ThisKey="StudentId", OtherKey="Id", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Grade.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Grade.Add(this);
						this._StudentId = value.Id;
					}
					else
					{
						this._StudentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Student");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Auditories")]
	public partial class Auditories : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Number;
		
		private EntitySet<TimeTable> _TimeTable;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNumberChanging(int value);
    partial void OnNumberChanged();
    #endregion
		
		public Auditories()
		{
			this._TimeTable = new EntitySet<TimeTable>(new Action<TimeTable>(this.attach_TimeTable), new Action<TimeTable>(this.detach_TimeTable));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number", DbType="Int NOT NULL")]
		public int Number
		{
			get
			{
				return this._Number;
			}
			set
			{
				if ((this._Number != value))
				{
					this.OnNumberChanging(value);
					this.SendPropertyChanging();
					this._Number = value;
					this.SendPropertyChanged("Number");
					this.OnNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Auditories_TimeTable", Storage="_TimeTable", ThisKey="Id", OtherKey="AuditoriesId")]
		public EntitySet<TimeTable> TimeTable
		{
			get
			{
				return this._TimeTable;
			}
			set
			{
				this._TimeTable.Assign(value);
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
		
		private void attach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.Auditories = this;
		}
		
		private void detach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.Auditories = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Groups")]
	public partial class Groups : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _SubjectId;
		
		private System.Nullable<int> _TimeId;
		
		private EntityRef<TimeTable> _TimeTable;
		
		private EntityRef<Subjects> _Subjects;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSubjectIdChanging(System.Nullable<int> value);
    partial void OnSubjectIdChanged();
    partial void OnTimeIdChanging(System.Nullable<int> value);
    partial void OnTimeIdChanged();
    #endregion
		
		public Groups()
		{
			this._TimeTable = default(EntityRef<TimeTable>);
			this._Subjects = default(EntityRef<Subjects>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectId", DbType="Int")]
		public System.Nullable<int> SubjectId
		{
			get
			{
				return this._SubjectId;
			}
			set
			{
				if ((this._SubjectId != value))
				{
					if (this._Subjects.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectIdChanging(value);
					this.SendPropertyChanging();
					this._SubjectId = value;
					this.SendPropertyChanged("SubjectId");
					this.OnSubjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeId", DbType="Int")]
		public System.Nullable<int> TimeId
		{
			get
			{
				return this._TimeId;
			}
			set
			{
				if ((this._TimeId != value))
				{
					if (this._TimeTable.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTimeIdChanging(value);
					this.SendPropertyChanging();
					this._TimeId = value;
					this.SendPropertyChanged("TimeId");
					this.OnTimeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TimeTable_Groups", Storage="_TimeTable", ThisKey="TimeId", OtherKey="Id", IsForeignKey=true)]
		public TimeTable TimeTable
		{
			get
			{
				return this._TimeTable.Entity;
			}
			set
			{
				TimeTable previousValue = this._TimeTable.Entity;
				if (((previousValue != value) 
							|| (this._TimeTable.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TimeTable.Entity = null;
						previousValue.Groups.Remove(this);
					}
					this._TimeTable.Entity = value;
					if ((value != null))
					{
						value.Groups.Add(this);
						this._TimeId = value.Id;
					}
					else
					{
						this._TimeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TimeTable");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_Groups", Storage="_Subjects", ThisKey="SubjectId", OtherKey="Id", IsForeignKey=true)]
		public Subjects Subjects
		{
			get
			{
				return this._Subjects.Entity;
			}
			set
			{
				Subjects previousValue = this._Subjects.Entity;
				if (((previousValue != value) 
							|| (this._Subjects.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subjects.Entity = null;
						previousValue.Groups.Remove(this);
					}
					this._Subjects.Entity = value;
					if ((value != null))
					{
						value.Groups.Add(this);
						this._SubjectId = value.Id;
					}
					else
					{
						this._SubjectId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Subjects");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TimeTable")]
	public partial class TimeTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _Date_Time;
		
		private System.Nullable<int> _AuditoriesId;
		
		private System.Nullable<int> _SubjectId;
		
		private System.Nullable<int> _TeacherId;
		
		private EntitySet<Groups> _Groups;
		
		private EntityRef<Auditories> _Auditories;
		
		private EntityRef<Teacher> _Teacher;
		
		private EntityRef<Subjects> _Subjects;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDate_TimeChanging(System.DateTime value);
    partial void OnDate_TimeChanged();
    partial void OnAuditoriesIdChanging(System.Nullable<int> value);
    partial void OnAuditoriesIdChanged();
    partial void OnSubjectIdChanging(System.Nullable<int> value);
    partial void OnSubjectIdChanged();
    partial void OnTeacherIdChanging(System.Nullable<int> value);
    partial void OnTeacherIdChanged();
    #endregion
		
		public TimeTable()
		{
			this._Groups = new EntitySet<Groups>(new Action<Groups>(this.attach_Groups), new Action<Groups>(this.detach_Groups));
			this._Auditories = default(EntityRef<Auditories>);
			this._Teacher = default(EntityRef<Teacher>);
			this._Subjects = default(EntityRef<Subjects>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Time", DbType="DateTime NOT NULL")]
		public System.DateTime Date_Time
		{
			get
			{
				return this._Date_Time;
			}
			set
			{
				if ((this._Date_Time != value))
				{
					this.OnDate_TimeChanging(value);
					this.SendPropertyChanging();
					this._Date_Time = value;
					this.SendPropertyChanged("Date_Time");
					this.OnDate_TimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuditoriesId", DbType="Int")]
		public System.Nullable<int> AuditoriesId
		{
			get
			{
				return this._AuditoriesId;
			}
			set
			{
				if ((this._AuditoriesId != value))
				{
					if (this._Auditories.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuditoriesIdChanging(value);
					this.SendPropertyChanging();
					this._AuditoriesId = value;
					this.SendPropertyChanged("AuditoriesId");
					this.OnAuditoriesIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectId", DbType="Int")]
		public System.Nullable<int> SubjectId
		{
			get
			{
				return this._SubjectId;
			}
			set
			{
				if ((this._SubjectId != value))
				{
					if (this._Subjects.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectIdChanging(value);
					this.SendPropertyChanging();
					this._SubjectId = value;
					this.SendPropertyChanged("SubjectId");
					this.OnSubjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherId", DbType="Int")]
		public System.Nullable<int> TeacherId
		{
			get
			{
				return this._TeacherId;
			}
			set
			{
				if ((this._TeacherId != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeacherIdChanging(value);
					this.SendPropertyChanging();
					this._TeacherId = value;
					this.SendPropertyChanged("TeacherId");
					this.OnTeacherIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TimeTable_Groups", Storage="_Groups", ThisKey="Id", OtherKey="TimeId")]
		public EntitySet<Groups> Groups
		{
			get
			{
				return this._Groups;
			}
			set
			{
				this._Groups.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Auditories_TimeTable", Storage="_Auditories", ThisKey="AuditoriesId", OtherKey="Id", IsForeignKey=true)]
		public Auditories Auditories
		{
			get
			{
				return this._Auditories.Entity;
			}
			set
			{
				Auditories previousValue = this._Auditories.Entity;
				if (((previousValue != value) 
							|| (this._Auditories.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Auditories.Entity = null;
						previousValue.TimeTable.Remove(this);
					}
					this._Auditories.Entity = value;
					if ((value != null))
					{
						value.TimeTable.Add(this);
						this._AuditoriesId = value.Id;
					}
					else
					{
						this._AuditoriesId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Auditories");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_TimeTable", Storage="_Teacher", ThisKey="TeacherId", OtherKey="Id", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.TimeTable.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.TimeTable.Add(this);
						this._TeacherId = value.Id;
					}
					else
					{
						this._TeacherId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Teacher");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_TimeTable", Storage="_Subjects", ThisKey="SubjectId", OtherKey="Id", IsForeignKey=true)]
		public Subjects Subjects
		{
			get
			{
				return this._Subjects.Entity;
			}
			set
			{
				Subjects previousValue = this._Subjects.Entity;
				if (((previousValue != value) 
							|| (this._Subjects.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subjects.Entity = null;
						previousValue.TimeTable.Remove(this);
					}
					this._Subjects.Entity = value;
					if ((value != null))
					{
						value.TimeTable.Add(this);
						this._SubjectId = value.Id;
					}
					else
					{
						this._SubjectId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Subjects");
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
		
		private void attach_Groups(Groups entity)
		{
			this.SendPropertyChanging();
			entity.TimeTable = this;
		}
		
		private void detach_Groups(Groups entity)
		{
			this.SendPropertyChanging();
			entity.TimeTable = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Teacher")]
	public partial class Teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Grade> _Grade;
		
		private EntitySet<TimeTable> _TimeTable;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Teacher()
		{
			this._Grade = new EntitySet<Grade>(new Action<Grade>(this.attach_Grade), new Action<Grade>(this.detach_Grade));
			this._TimeTable = new EntitySet<TimeTable>(new Action<TimeTable>(this.attach_TimeTable), new Action<TimeTable>(this.detach_TimeTable));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_Grade", Storage="_Grade", ThisKey="Id", OtherKey="TeacherId")]
		public EntitySet<Grade> Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				this._Grade.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_TimeTable", Storage="_TimeTable", ThisKey="Id", OtherKey="TeacherId")]
		public EntitySet<TimeTable> TimeTable
		{
			get
			{
				return this._TimeTable;
			}
			set
			{
				this._TimeTable.Assign(value);
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
		
		private void attach_Grade(Grade entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_Grade(Grade entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
		
		private void attach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subjects")]
	public partial class Subjects : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Grade> _Grade;
		
		private EntitySet<Groups> _Groups;
		
		private EntitySet<TimeTable> _TimeTable;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Subjects()
		{
			this._Grade = new EntitySet<Grade>(new Action<Grade>(this.attach_Grade), new Action<Grade>(this.detach_Grade));
			this._Groups = new EntitySet<Groups>(new Action<Groups>(this.attach_Groups), new Action<Groups>(this.detach_Groups));
			this._TimeTable = new EntitySet<TimeTable>(new Action<TimeTable>(this.attach_TimeTable), new Action<TimeTable>(this.detach_TimeTable));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_Grade", Storage="_Grade", ThisKey="Id", OtherKey="SubjectId")]
		public EntitySet<Grade> Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				this._Grade.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_Groups", Storage="_Groups", ThisKey="Id", OtherKey="SubjectId")]
		public EntitySet<Groups> Groups
		{
			get
			{
				return this._Groups;
			}
			set
			{
				this._Groups.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_TimeTable", Storage="_TimeTable", ThisKey="Id", OtherKey="SubjectId")]
		public EntitySet<TimeTable> TimeTable
		{
			get
			{
				return this._TimeTable;
			}
			set
			{
				this._TimeTable.Assign(value);
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
		
		private void attach_Grade(Grade entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = this;
		}
		
		private void detach_Grade(Grade entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = null;
		}
		
		private void attach_Groups(Groups entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = this;
		}
		
		private void detach_Groups(Groups entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = null;
		}
		
		private void attach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = this;
		}
		
		private void detach_TimeTable(TimeTable entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _GroupId;
		
		private EntitySet<Grade> _Grade;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGroupIdChanging(System.Nullable<int> value);
    partial void OnGroupIdChanged();
    #endregion
		
		public Student()
		{
			this._Grade = new EntitySet<Grade>(new Action<Grade>(this.attach_Grade), new Action<Grade>(this.detach_Grade));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="Int")]
		public System.Nullable<int> GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Grade", Storage="_Grade", ThisKey="Id", OtherKey="StudentId")]
		public EntitySet<Grade> Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				this._Grade.Assign(value);
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
		
		private void attach_Grade(Grade entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Grade(Grade entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
}
#pragma warning restore 1591
