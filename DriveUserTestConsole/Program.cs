using DriveUse;
using System;
using System.Collections.Generic;
using System.IO;

namespace DriveUserTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

         string accessToken= "ya29.a0ARrdaM9M2O7xMDXJFZniLN8P5Yf_zn6me9RlpZvmrbRqoSugAAZrwDdG28aS7IuIN07EAhvPn7dN48oy-x08Z1gl3Nwl3dgeDuHyEWONANB3s7dh8GvQHJP1Yj85yeS4v9ugrIkSBvqBHHxYT6ej9FoHixT9";
         string refreshToken ="1//047D1zkUcnqvcCgYIARAAGAQSNwF-L9IrTf3Z6TxNmeB5Ke80Pq5kdnWr-noVZEsiLjwtB3Yb2z-Us1KfWsmj_DwajlzM5YqdCo8";
         string applicationName ="codemart";
         string username = "sahancodemart@gmail.com"; ;
         string clientId = "207000393786-6dcp1k7h1sb3qa3spkvg7fm2i6j0q7oh.apps.googleusercontent.com";
         string clientSecret = "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";

        Drive drive = new Drive(accessToken,refreshToken,applicationName,username,clientId,clientSecret);
           // string idfolder = drive.CreateFolder("root","sahanbcs");

            // drive.DeleteFile("1QmMPvv71e1zDiepZi42QxX3Yw12BHG7u");
            FileStream fs = File.OpenRead("C:\\Users\\sahanbcs\\Desktop\\Local Disk (D)\\Code-Mart\\db.sql");
            //string filefolder = drive.UploadFile(fs, "db22.sql", "text/x-sql", "root", "Normal");

            //Console.WriteLine("The SahanGod folder id is " + filefolder );

            IEnumerable<Google.Apis.Drive.v3.Data.File> ss = drive.GetFiles("1IAP-u7kIT148z7wcpK_9gUL5Gws21k31");

            foreach (Google.Apis.Drive.v3.Data.File fi in ss)
            {
                Console.WriteLine("File Id:- " + fi.Name
                                   + "\t\t " + fi.Id + "\t\t" + fi.MimeType + "\t\t" + "SAsa  " + fi.Trashed );
               //drive.DeleteFile(fi.Id);
            }


            drive.downLoadFile("1LvrER8rMk984IAaIMBu9WuWCH2IEN9Yj", "C:\\Users\\sahanbcs\\Desktop\\Local Disk (D)\\Entertainment\\sahan.sql");
            Console.WriteLine("The SahanGod folder id is");
                Console.ReadLine();
            

        }
    }
}
