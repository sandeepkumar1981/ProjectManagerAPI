using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BusinessLayerProjectManager;
using EntityProjectManager;

namespace UnitTestProjectManager
{
    [TestFixture]
    public class UnitTestProject
    {
        private BusinessLayerProjectManager.BLProject BLProjectManager = new BusinessLayerProjectManager.BLProject();

        [Test]
        public void AddProject()
        {
            EntityProject entProject = new EntityProject();
            EntityUser entUser = new EntityUser();

            entProject.projectId = 1;
            entProject.projectName = "Cards and Payment";
            entProject.startDate = DateTime.Now;
            entProject.endDate = DateTime.Now;
            entProject.priority = 1;
            entProject.isCompleted = false;
            entProject.numberofTasks = 2;
            entProject.completedTasks = 1;
            entProject.manager = entUser;

            BLProjectManager.AddProject(entProject);
            NUnit.Framework.Assert.AreEqual(entProject.projectId, 1);
            NUnit.Framework.Assert.IsNotNull(entUser);
        }

        [Test]
        public void GetAllProject()
        {
            var result = BLProjectManager.GetAllProject();
            NUnit.Framework.Assert.AreEqual(result.Count, 1);
        }
    }
}
