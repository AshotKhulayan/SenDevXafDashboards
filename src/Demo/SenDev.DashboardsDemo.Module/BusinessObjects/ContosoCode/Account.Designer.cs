﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SenDev.DashboardsDemo.Module.BusinessObjects
{

	[Persistent(@"DimAccount")]
	public partial class Account : XPLiteObject
	{
		int fAccountKey;
		[Key(true)]
		public int AccountKey
		{
			get
			{
				return fAccountKey;
			}
			set
			{
				SetPropertyValue<int>(nameof(AccountKey), ref fAccountKey, value);
			}
		}
		int fParentAccountKey;
		public int ParentAccountKey
		{
			get
			{
				return fParentAccountKey;
			}
			set
			{
				SetPropertyValue<int>(nameof(ParentAccountKey), ref fParentAccountKey, value);
			}
		}
		string fAccountLabel;
		public string AccountLabel
		{
			get
			{
				return fAccountLabel;
			}
			set
			{
				SetPropertyValue<string>(nameof(AccountLabel), ref fAccountLabel, value);
			}
		}
		string fAccountName;
		[Size(50)]
		public string AccountName
		{
			get
			{
				return fAccountName;
			}
			set
			{
				SetPropertyValue<string>(nameof(AccountName), ref fAccountName, value);
			}
		}
		string fAccountDescription;
		[Size(50)]
		public string AccountDescription
		{
			get
			{
				return fAccountDescription;
			}
			set
			{
				SetPropertyValue<string>(nameof(AccountDescription), ref fAccountDescription, value);
			}
		}
		string fAccountType;
		[Size(50)]
		public string AccountType
		{
			get
			{
				return fAccountType;
			}
			set
			{
				SetPropertyValue<string>(nameof(AccountType), ref fAccountType, value);
			}
		}
		string fOperator;
		[Size(50)]
		public string Operator
		{
			get
			{
				return fOperator;
			}
			set
			{
				SetPropertyValue<string>(nameof(Operator), ref fOperator, value);
			}
		}
		string fCustomMembers;
		[Size(300)]
		public string CustomMembers
		{
			get
			{
				return fCustomMembers;
			}
			set
			{
				SetPropertyValue<string>(nameof(CustomMembers), ref fCustomMembers, value);
			}
		}
		string fValueType;
		[Size(50)]
		public string ValueType
		{
			get
			{
				return fValueType;
			}
			set
			{
				SetPropertyValue<string>(nameof(ValueType), ref fValueType, value);
			}
		}
		string fCustomMemberOptions;
		[Size(200)]
		public string CustomMemberOptions
		{
			get
			{
				return fCustomMemberOptions;
			}
			set
			{
				SetPropertyValue<string>(nameof(CustomMemberOptions), ref fCustomMemberOptions, value);
			}
		}
		int fETLLoadID;
		public int ETLLoadID
		{
			get
			{
				return fETLLoadID;
			}
			set
			{
				SetPropertyValue<int>(nameof(ETLLoadID), ref fETLLoadID, value);
			}
		}
		DateTime fLoadDate;
		public DateTime LoadDate
		{
			get
			{
				return fLoadDate;
			}
			set
			{
				SetPropertyValue<DateTime>(nameof(LoadDate), ref fLoadDate, value);
			}
		}
		DateTime fUpdateDate;
		public DateTime UpdateDate
		{
			get
			{
				return fUpdateDate;
			}
			set
			{
				SetPropertyValue<DateTime>(nameof(UpdateDate), ref fUpdateDate, value);
			}
		}
		[Association(@"FactStrategyPlanReferencesAccount")]
		public XPCollection<FactStrategyPlan> FactStrategyPlans
		{
			get
			{
				return GetCollection<FactStrategyPlan>(nameof(FactStrategyPlans));
			}
		}
	}

}