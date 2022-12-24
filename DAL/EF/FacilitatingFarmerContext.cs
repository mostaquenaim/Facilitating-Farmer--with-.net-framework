using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class FacilitatingFarmerContext : DbContext
    {

        public DbSet <Customer> Customers { get; set; }

        public DbSet <Specialist> Specialists { get; set; }

        public DbSet <Course> Courses { get; set; }

        public DbSet <CourseInstructorMap> CoursesInstructors { get; set; }

        public DbSet <Difficulty> Difficulties { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet <CourseVideo> CourseVideos { get; set; }

        public DbSet <CouseVideoLock> CouseVideoLocks { get; set; }

        public DbSet <CourseEnrollment> CourseEnrollments { get; set; }

        public DbSet <Rating> Ratings { get; set; }

        public DbSet <Question> Questions { get; set; }

        public DbSet <Answer> Answers { get; set; }

        public DbSet <Admin> Admins { get; set; }

        public DbSet <AdminSendMessage> AdminSendMessages { get; set; }

    }
}
