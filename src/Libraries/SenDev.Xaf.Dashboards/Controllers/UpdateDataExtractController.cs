﻿using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using SenDev.Xaf.Dashboards.BusinessObjects;
using SenDev.Xaf.Dashboards.Scripting;

namespace SenDev.Xaf.Dashboards.Controllers
{
	public class UpdateDataExtractController : ObjectViewController<ListView, DashboardDataExtract>
	{


		public UpdateDataExtractController()
		{
			UpdateDataExtractAction = new SimpleAction(this, "UpdateDataExtract", PredefinedCategory.Edit);
			UpdateDataExtractAction.Caption = "Update data";
			UpdateDataExtractAction.SelectionDependencyType = SelectionDependencyType.RequireSingleObject;
			UpdateDataExtractAction.Execute += UpdateDataExtractAction_Execute;
		}

		private void UpdateDataExtractAction_Execute(object sender, SimpleActionExecuteEventArgs e)
		{
			var dm = new DataExtractDataManager(Application);
			dm.UpdateDataExtractByKey(ObjectSpace.GetKeyValue(ViewCurrentObject));
			ObjectSpace.Refresh();
		}

		public SimpleAction UpdateDataExtractAction
		{
			get;
		}
	}
}