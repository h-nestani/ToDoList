using System;
namespace ToDoList
{
    public class Task
    {

        string _title;
        string _description;
        DateTime _timestamp;

        public Task(string title, string description, DateTime timestamp)
        {
            _title = title;
            _description = description;
            _timestamp = timestamp;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetDescription()
        {
            return _description;
        }

        public DateTime GetTimestamp()
        {
            return _timestamp;
        }
    }
}
