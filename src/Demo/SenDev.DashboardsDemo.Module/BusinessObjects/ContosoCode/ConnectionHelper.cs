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
	public static class ConnectionHelper
	{
		static Type[] persistentTypes = new Type[] {
			typeof(Account),
			typeof(Channel),
			typeof(Currency),
			typeof(Customer),
			typeof(Date),
			typeof(Employee),
			typeof(Entity),
			typeof(Geography),
			typeof(Machine),
			typeof(Outage),
			typeof(Product),
			typeof(ProductCategory),
			typeof(ProductSubcategory),
			typeof(Promotion),
			typeof(SalesTerritory),
			typeof(Scenario),
			typeof(Store),
			typeof(FactExchangeRate),
			typeof(FactInventory),
			typeof(FactITMachine),
			typeof(FactITSLA),
			typeof(FactOnlineSales),
			typeof(Sales),
			typeof(FactSalesQuota),
			typeof(FactStrategyPlan),
			typeof(sysdiagrams)
		};
		public static Type[] GetPersistentTypes()
		{
			Type[] copy = new Type[persistentTypes.Length];
			Array.Copy(persistentTypes, copy, persistentTypes.Length);
			return copy;
		}
#warning We recommend moving the connection string out of your source code (for instance, to a configuration file) to improve your application's maintainability and security.
		public const string ConnectionString = "XpoProvider=MSSqlServer;data source=.;integrated security=SSPI;initial catalog=ContosoRetailDW";
		public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, bool threadSafe = false)
		{
			if (threadSafe)
			{
				var provider = XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
				var dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
				dictionary.GetDataStoreSchema(persistentTypes);
				XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
			}
			else
			{
				XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
			}
			XpoDefault.Session = null;
		}
		public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
		{
			return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
		}
		public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
		{
			return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
		}
		public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
		{
			return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
		}
	}

}