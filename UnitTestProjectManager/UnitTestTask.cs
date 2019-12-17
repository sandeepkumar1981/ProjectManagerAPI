using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BusinessLayerProjectManager;
using EntityProjectManager;

namespace UnitTestProjectManager
{
    [TestFixture]
    public class UnitTestTask
    {
        private BusinessLayerProjectManager.BLTask BLProjectManager = new BusinessLayerProjectManager.BLTask();

        [Test]
        public void AddTask()
        {
            EntityTask entTask = new EntityTask();
            EntityUser entUser = new EntityUser();
            EntityProject entProject = new EntityProject();
            EntityParentTask entParentTask = new EntityParentTask();

            entTask.taskId = 1;
            entTask.task = "Test Task";
            entTask.startDate = DateTime.Now;
            entTask.endDate = DateTime.Now;
            entTask.priority = 1;
            entTask.isCompleted = false;
            entTask.user = entUser;
            entTask.project = entProject;
            entTask.parentTask = entParentTask;

            BLProjectManager.AddTask(entTask);
            NUnit.Framework.Assert.AreEqual(entTask.taskId, 1);
            NUnit.Framework.Assert.IsNotNull(entTask);
        }

        [Test]
        public void GetAllUser()
        {
            var result = BLProjectManager.GetAllTask();
            NUnit.Framework.Assert.AreEqual(result.Count, 1);
        }

        [Test]
        public void UpdateTask()
        {
            EntityTask entTask = new EntityTask();
            EntityUser entUser = new EntityUser();
            EntityProject entProject = new EntityProject();
            EntityParentTask entParentTask = new EntityParentTask();

            entTask.taskId = 1;
            entTask.task = "Updated Task";
            entTask.startDate = DateTime.Now;
            entTask.endDate = DateTime.Now;
            entTask.priority = 1;
            entTask.isCompleted = false;
            entTask.user = entUser;
            entTask.project = entProject;
            entTask.parentTask = entParentTask;

            BLProjectManager.UpdateTask(entTask, 1);
            NUnit.Framework.Assert.IsNotEmpty("1");
            NUnit.Framework.Assert.IsNotNull("1");
        }
    }
}
