using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BusinessLayerProjectManager;
using EntityProjectManager;

namespace UnitTestProjectManager
{
    [TestFixture]
    public class UnitTestUser
    {
        private BusinessLayerProjectManager.BLUser BLProjectManager = new BusinessLayerProjectManager.BLUser();

        [Test]
        public void AddUser()
        {
            EntityUser entUser = new EntityUser();

            entUser.userId = 1;
            entUser.employeeId = 1;
            entUser.firstName = "John";
            entUser.lastName = "Blair";
            
            BLProjectManager.AddUser(entUser);
            NUnit.Framework.Assert.AreEqual(entUser.userId, 3);
            NUnit.Framework.Assert.IsNotNull(entUser);
        }

        [Test]
        public void GetAllUser()
        {
            var result = BLProjectManager.GetAllUser();
            NUnit.Framework.Assert.AreEqual(result.Count, 1);
        }
    }
}
