using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer>
    {
        public Customer Add(Customer obj)
        {
            db.Customers.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int Id)
        {
            return db.Customers.Find(Id);
        }

        public Customer Delete(int id)
        {
            var CustomerObj = Get(id);

            if (CustomerObj == null) return null;

            db.Customers.Remove(CustomerObj);

            if (db.SaveChanges() > 0) return CustomerObj;

            return null;
        }


        public Customer Update(Customer obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }
}
