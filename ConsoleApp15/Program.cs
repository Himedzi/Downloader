using System;
using System.IO;
using System.Threading.Tasks;
using Saver;

namespace Downloader
{
     class Program
    {
        static void Main(string[] args)
        {
            int task = 0;
            TaskQueue taskQueue = new TaskQueue();

            using (StreamReader stream = new StreamReader("links.txt", System.Text.Encoding.Default))
            {
                string hyperlink;

                while ((hyperlink = stream.ReadLine()) != null)
                {
                    task++;
                    SaverOfImageToList saver = new SaverOfImageToList(task, hyperlink);
                    taskQueue.AddToQueue(Task.Run(() => saver.SaveImage()));
                }
            }

            taskQueue.WaitAll();

            Console.ReadLine();
        }
    }
}