using AutoMapper;
using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL.Services
{
    public class FileUploading
    {
       /* public static List<FileUploadingDTO> Add(Provider)
        {
     

            try
            {
               

                foreach (var file in provider.FileData)
                {
                    var name = file.Headers
                        .ContentDisposition
                        .FileName;

                    // remove double quotes from string.
                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);

                    File.Move(localFileName, filePath);
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
        } */

    }
}

