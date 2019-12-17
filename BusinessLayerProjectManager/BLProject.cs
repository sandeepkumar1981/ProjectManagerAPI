using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerProjectManager;
using EntityProjectManager;

namespace BusinessLayerProjectManager
{
    public class BLProject
    {
        public void AddProject(EntityProject project)
        {
            using (MyContext db = new MyContext())
            {
                db.Projects.Add(project);
                db.SaveChanges();
            }
        }

        public List<EntityProject> GetAllProject()
        {
            using (MyContext db = new MyContext())
            {
                return db.Projects.ToList();
            }
        }
    }
}
