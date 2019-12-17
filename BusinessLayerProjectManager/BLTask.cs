using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerProjectManager;
using EntityProjectManager;

namespace BusinessLayerProjectManager
{
    public class BLTask
    {
        public void AddTask(EntityTask task)
        {
            using (MyContext db = new MyContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
        }

        public List<EntityTask> GetAllTask()
        {
            using (MyContext db = new MyContext())
            {
                return db.Tasks.ToList();
            }
        }

        public bool UpdateTask(EntityTask task, int ID)
        {
            using (MyContext db = new MyContext())
            {
                var entity = db.Tasks.FirstOrDefault(e => e.taskId == ID);
                if (entity == null)
                {
                    return false;
                }
                else
                {
                    entity.task = task.task;
                    entity.parentTask = task.parentTask;
                    entity.priority = task.priority;
                    entity.startDate = task.startDate;
                    entity.endDate = task.endDate;
                    entity.isCompleted = task.isCompleted;
                    entity.project = task.project;
                    db.SaveChanges();
                    return true;
                }
            }
        }
    }
}
