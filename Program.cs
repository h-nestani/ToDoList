using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHandler th = new TaskHandler();

            string menu = "To Do List <Hemen>";
            menu += "[ 1 ] Show All";
            menu += "[ 2 ] Find task by title";
            menu += "[ 3 ] Add new task";
            menu += "[ 4 ] Remove task";
            menu += "[ 0 ] Exit";

            int menuSelection = -1;

            while(menuSelection != 0)
            {
                string answer = "";
                try
                {
                    Console.WriteLine(menu);
                    answer = Console.ReadLine();
                    menuSelection = Convert.ToInt32(answer);

                    // Selection was OK
                    switch (menuSelection)
                    {
                        case 0: return;
                        case 1: // Show all
                        case 2: // Find task by title;
                        case 3: // Add new task;
                        case 4: // Remove task;

                        default:
                            break;
                    }



                }
                catch
                {
                    string error = "\n\n";
                    error += answer + "Is not a valid answer, please make a selection from the menu. \n\n";

                    Console.WriteLine(error);
                }
            }
            


        }
    }
}
