using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course>, ICourseCategory
    {
        public Course Add(Course obj)
        {
            db.Courses.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<Course> Get()
        {
            return db.Courses.ToList();
        }

        public Course Get(int Id)
        {
            return db.Courses.Find(Id);
        }

        public List<Course> Getwithcatid(int Id)
        {
            var db = new FacilitatingFarmerContext();
            var courses=(from row in db.Courses
                where row.CategoryId == Id
                select row).ToList();
            return courses;
        }

        public Course Delete(int id)
        {
            var courseObj = Get(id);

            if (courseObj == null) return null;

            db.Courses.Remove(courseObj);

            if(db.SaveChanges()>0) return courseObj;

            return null;
        }


        public Course Update(Course obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }
    }

}
