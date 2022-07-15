using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любой день недели или exit чтобы завершить");

            string weekOfDay = Console.ReadLine();
   
                switch (weekOfDay)
                {
                    case "понедельник":
                    case "вторник":
                    case "среда":
                    case "четверг":
                    case "пятница":
                    case "суббота":
                    case "воскресенье":
                        Console.WriteLine("день недели");
                    break;
                case "exit":
                        Console.WriteLine("Выход из программы");
                    break;
                default:
                        Console.WriteLine("Я такого дня недели не знаю");
                        break;
                }
        }
        }
    }
    

