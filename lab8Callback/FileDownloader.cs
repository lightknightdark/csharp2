using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab8Callback
{
  
    class FileDownloader
    {



        Random rnd = new Random();

        public void Download(string filename, StartCallback startCallback, ProgressCallback progressCallback, CompletionCallback completionCallback)
        {
            while (true)
            {
                startCallback(filename);
                FileDownloader fileDownloader = new FileDownloader();
                int progress = 0;
                progressCallback(progress);

                Thread.Sleep(1000);

                while (progress < 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    progress += rnd.Next(1, 10);
                    if (progress > 100)
                    {
                        progress = 100;
                    }
                    progressCallback(progress);

                }
                bool success = rnd.Next(0, 100) < 90;


                completionCallback(filename, success);

            }


        }




    }



}
