﻿using Core.Utililies.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utililies.Helpers
{
    public class FileHelper
    {
        static string directory = Directory.GetCurrentDirectory() + @"\wwwroot\";
        static string path = @"Images\";
        public static string Add(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName).ToUpper();
            string newFileName = Guid.NewGuid().ToString("N") + extension;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using (FileStream fileStream = File.Create(directory + path + newFileName))
            {
                file.CopyToAsync(fileStream);
                fileStream.Flush();
            }
            return (path + newFileName).Replace("\\", "/");
        }
        //public static string Add(IFormFile file)
        //{
        //    var sourcepath = Path.GetTempFileName();
        //    if (file.Length > 0)
        //    {
        //        using (var stream = new FileStream(sourcepath, FileMode.Create))
        //        {
        //            file.CopyTo(stream);
        //        }
        //    }
        //    var result = newPath(file);
        //    File.Move(sourcepath, result);
        //    return result;
        // }
        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }
        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            string path = Environment.CurrentDirectory + @"\Images\carImages";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }

    }
}
