using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin>
    {
        public Admin Add(Admin obj)
        {
            db.Admins.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public Admin Delete(int Id)
        {
            var adminObj = Get(Id);

            if (adminObj == null) return null;

            db.Admins.Remove(adminObj);

            if (db.SaveChanges() > 0) return adminObj;

            return null;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int Id)
        {
            return db.Admins.Find(Id);
        }

        public Admin Update(Admin obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        
    }
}
