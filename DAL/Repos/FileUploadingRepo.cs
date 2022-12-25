using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
  /*  internal class FileUploadingRepo : Repo, IRepo<FileUploading>
    {
        public FileUploading Add(FileUploading obj)
        {
            db.FileUploadings.Add(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        }

        public List<FileUploading> Get()
        {
            return db.FileUploadings.ToList();
        }

        public FileUploading Get(int Id)
        {
            return db.FileUploadings.Find(Id);
        }

        public FileUploading Delete(int id)
        {
            var FileUploadingObj = Get(id);

            if (FileUploadingObj == null) return null;

            db.FileUploadings.Remove(FileUploadingObj);

            if (db.SaveChanges() > 0) return FileUploadingObj;

            return null;
        }


        public FileUploading Update(FileUploading obj)
        {
            var dbObj = Get(obj.Id);

            db.Entry(dbObj).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return obj;

            return null;
        } */
    }

