using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo{ Description = "Task 1", EstimatedHour = 6, Status = Status.NotStarted},
                new Todo{ Description = "Task 2", EstimatedHour = 2, Status = Status.InProgress},
                new Todo{ Description = "Task 3", EstimatedHour = 8, Status = Status.Completed},
                new Todo{ Description = "Task 4", EstimatedHour = 12, Status = Status.Deleted},
                new Todo{ Description = "Task 5", EstimatedHour = 6, Status = Status.OnHold},
                new Todo{ Description = "Task 6", EstimatedHour = 14, Status = Status.NotStarted},
                new Todo{ Description = "Task 7", EstimatedHour = 8, Status = Status.InProgress},
                new Todo{ Description = "Task 8", EstimatedHour = 9, Status = Status.Completed},
                new Todo{ Description = "Task 9", EstimatedHour = 1, Status = Status.Completed}
            };

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            PrintAssesment(todos);
            Console.ReadLine();
        }

        private static void PrintAssesment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description)
;            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHour { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
