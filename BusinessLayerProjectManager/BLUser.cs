using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerProjectManager;
using EntityProjectManager;


namespace BusinessLayerProjectManager
{
    public class BLUser
    {
        public void AddUser(EntityUser user)
        {
            using (MyContext db = new MyContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public List<EntityUser> GetAllUser()
        {
            using (MyContext db = new MyContext())
            {
                return db.Users.ToList();
            }
        }
    }
}
