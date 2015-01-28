using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShipitIntro
{
    class Program
    {
        static void Main(string[] args)
        {
         //updatepath is the location where I upload updated exe 
            string UpdatePath = @"\\testserver\Art\ship it\Shipit.exe";
          //applocation is the location from where this console app runs.It will also be the location where the new file will be saved 
            string AppLocation = Directory.GetCurrentDirectory() + @"\shipit.exe";
          
          
          
            try
            {
                FileInfo info1 = null;
                FileInfo info2 = null;
                if (File.Exists(UpdatePath))
                {
              //If there is a file in the update location info1 will get the fileinfo of that file 
                    info1 = new FileInfo(UpdatePath);
                }

                if (File.Exists(AppLocation))
                {
//if the exe is already present in the aplocation get its information also
                    info2 = new FileInfo(AppLocation);

                }
                else
                {
                    File.Copy(UpdatePath, AppLocation, true);
                    ExecuteApp(AppLocation);
                    return;
                }
                if (info1.LastWriteTime > info2.LastWriteTime)
                {
                    File.Copy(UpdatePath, AppLocation, true);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            ExecuteApp(AppLocation);

        }
        static void ExecuteApp(string location)
        {
            if (File.Exists(location))
            {
                try
                {
                    Process.Start(location);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message); return;
                }
            }
            else
            {
               
            }
        }
       
    }
}
