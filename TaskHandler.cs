using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class TaskHandler
    {

        List<Task> tasks;

        public TaskHandler()
        {
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public Task FindTaskByTitle(string title)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = tasks[i];

                if (task.GetTitle() == title)
                {
                    return task;
                }

            }

            return null;
        }
    }
}
