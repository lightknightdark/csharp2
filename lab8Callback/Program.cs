using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab8Callback


{

    internal class Program
    {

        static void Main(string[] args)
        {
            FileDownloader downloader = new FileDownloader();

            
            string filename = "example_file.txt";

      
            downloader.Download(filename, OnDownloadStart, OnDownloadProgress, OnDownloadComplete);



            Console.ReadLine();
        }



        static void OnDownloadStart(string filename)
        {
            Console.WriteLine($"Download started for file: {filename}");
        }


        static void OnDownloadProgress(int percentage)
        {
            Console.WriteLine($"Download progress: {percentage}%");
        }


        static void OnDownloadComplete(string filename, bool success)
        {
            if (success)
            {
                Console.WriteLine($"Download completed successfully for file: {filename}");
            }
            else
            {
                Console.WriteLine($"Download failed for file: {filename}");
            }
        }

    }
}
