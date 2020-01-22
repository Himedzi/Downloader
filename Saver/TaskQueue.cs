using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Saver
{
    public class TaskQueue
    {
        private readonly List<Task> _queue = new List<Task>();

        public void AddToQueue(Task task)
        {
            lock (_queue)
            {
                _queue.Add(task);
            }
        }

        public void WaitAll()
        {
            Task.WaitAll(_queue.ToArray());
            Console.WriteLine("Завершено");
        }
    }
}
