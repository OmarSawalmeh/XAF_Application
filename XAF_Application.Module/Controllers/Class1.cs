using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.ExpressApp.Actions;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using XAF_Application.Module.BusinessObjects;

namespace XAF_Application.Module.Controllers
{
    public class TaskCompletedController : ViewController
    {
        SimpleAction Complete;

        public TaskCompletedContoller()
        {
            TargetObjectType = typeof(ProjectTask);

            Complete = new SimpleAction(this, "Complete", DevExpress.Persistent.Base.PredefinedCategory.Edit);
            Complete.SelectionDependencyType = SelectionDependencyType.Independent;
            Complete.Execute += Complete_Execute;

        }

        protected override void onViewControlsCreated()
        {
            base.onViewControlsCreated();
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }

        void Complete_Execute(object sender, SimpleActionExecuteEventArgs e) { 
            var currentObj = e.CurrentObject as ProjectTask;
            if(currentObj != null)
            {

            }
         }
    }
}
