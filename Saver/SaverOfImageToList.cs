using System;
using System.Threading;

namespace Saver
{
    public class SaverOfImageToList : ISave
    {
        private readonly int _task;
        private readonly string _hyperlink;

        public SaverOfImageToList(int task, string hyperlink)
        {
            _task = task;
            _hyperlink = hyperlink;
        }

        public void SaveImage()
        {
            Random random = new Random();
            int time = random.Next(5000, 15000);

            Console.WriteLine(_task + ". Start from " + _hyperlink);
            Thread.Sleep(time);
            Console.WriteLine(_task + ". End from " + _hyperlink + " in " + time / 1000 + " sec");
        }
    }
}
