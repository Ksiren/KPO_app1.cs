using Microsoft.Extensions.DependencyInjection;
using KPO_app;
using System;
using System.Drawing;
using System.Windows.Markup;

public class Program
{
    static void AddingAnimal(Zoo zoo)
    {
        Console.WriteLine("\t1. Add monkey\n" +
                "\t2. Add rabbit\n" +
                "\t3. Add tiger\n" +
                "\t4. Add wolf");
        bool is_int = int.TryParse(Console.ReadLine(), out int userAnswer);
        if (!is_int) userAnswer = 100;

        switch (userAnswer)
        {
            case 1: {
                    Console.WriteLine("How kind your monkey? (0-10)\n");
                    is_int = int.TryParse(Console.ReadLine(), out userAnswer);
                    if (is_int && userAnswer <= 10 && userAnswer >= 0) {
                        var monkey = new Monkey(userAnswer);
                        zoo.AddAnimal(monkey);
                    }
                    else Console.WriteLine("nope, it's not number or number not in 0-10\n");
                    break;
                }
            case 2: {
                    Console.WriteLine("How kind your rabbit? (0-10)\n");
                    is_int = int.TryParse(Console.ReadLine(), out userAnswer);
                    if (is_int && userAnswer <= 10 && userAnswer >= 0)
                    {
                        var rabbit = new Rabbit(userAnswer);
                        zoo.AddAnimal(rabbit);
                    }
                    else Console.WriteLine("nope, it's not number or number not in 0-10\n");
                    break;
                }
            case 3: {
                    var Tiger = new Tiger();
                    zoo.AddAnimal(Tiger);
                    break;
                }
            case 4:
                {
                    var Wolf = new Wolf();
                    zoo.AddAnimal(Wolf);
                    break;
                }
            default: Console.WriteLine("You had to chose number 1-4, try again :(\n"); return;
        }
        Console.WriteLine("\nAnimal adding finished ;)\n");
    }
    static void AddingThings(Zoo zoo)
    {
        Console.WriteLine( $"\t1. Add table\n" +
                    $"\t2. Add computer\n");
        bool is_int = int.TryParse(Console.ReadLine(), out int userAnswer);
        if (!is_int) userAnswer = 100;

        switch (userAnswer)
        {
            case 1:
                {
                    Table table = new Table();
                    zoo.AddThing(table);
                    break;
                }
            case 2:
                {
                    Computer computer = new Computer();
                    zoo.AddThing(computer);
                    break;
                }
            default: Console.WriteLine("You had to chose number 1-2, try again :(\n"); return;
        }
        Console.WriteLine("\nThing Adding finished :)\n");
    }
    static void ConsoleApp()
    {
        var serviceProvider = new ServiceCollection().AddSingleton<IHealthCheck, VetClinic>().AddSingleton<Zoo>().BuildServiceProvider();
        var mainZoo = serviceProvider.GetService<Zoo>();
        ReportMaker reportMaker = new ReportMaker(mainZoo);
        int userAnswer = 100;
        string menu = "Menu:\n" +
                "\t1. Add animal\n" +
                "\t2. Add thing\n" +
                "\t3. Print total food consumption\n" +
                "\t4. Print contact animals\n" +
                "\t5. Print animals\n" +
                "\t6. Print things\n" +
                "\t7. Print whole report\n" +
                "\t0. Exit\n";

        while (userAnswer != 0)
        {
            switch (userAnswer)
            {
                case 1: AddingAnimal(mainZoo); break;
                case 2: AddingThings(mainZoo); break;
                case 3: reportMaker.PrintFoodPerDay(); break;
                case 4: reportMaker.PrintListOfContact(); break;
                case 5: reportMaker.PrintListOfAnimals(); break;
                case 6: reportMaker.PrintListOfThings(); break;
                case 7: reportMaker.PrintWholeReport(); break;
                default: Console.WriteLine("(You have to choose number 1-7 or 0 if you want to finish)\n"); break ;
            }
            Console.WriteLine(menu);
            bool is_int = int.TryParse(Console.ReadLine(), out userAnswer);
            if (!is_int) userAnswer = -1;
        }

        Console.WriteLine("\nGoodbye :)");
    }

    static void Main()
    {
        ConsoleApp();
    }
}