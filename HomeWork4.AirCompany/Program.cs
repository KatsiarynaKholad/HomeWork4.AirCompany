namespace HomeWork4.AirCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                var plane = new AirCompany();

                plane.planesList.Add(new AirCompany { Name = "Boeing 737-8", Capacity = 174, Carrying = 79000, Range = 6574 });
                plane.planesList.Add(new AirCompany { Name = "Boeing 737-800", Capacity = 189, Carrying = 79000, Range = 5425 });
                plane.planesList.Add(new AirCompany { Name = "Boeing 737-500", Capacity = 110, Carrying = 52300, Range = 4444 });
                plane.planesList.Add(new AirCompany { Name = "Boeing 737-300", Capacity = 148, Carrying = 63276, Range = 4400 });
                plane.planesList.Add(new AirCompany { Name = "Embraer 195-E2", Capacity = 225, Carrying = 61500, Range = 4800 });
                plane.planesList.Add(new AirCompany { Name = "Embraer 195", Capacity = 107, Carrying = 50790, Range = 3900 });
                plane.planesList.Add(new AirCompany { Name = "Embraer 175", Capacity = 76, Carrying = 38790, Range = 3334 });

                plane.PrintInfo();

                PrintMenu(plane);

                Console.WriteLine("Do you want continue? Y/N");
                var isContinue = Console.ReadLine().ToUpperInvariant();

                if (isContinue == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }
        }

        static void PrintMenu(AirCompany plane)
        {
            Console.WriteLine("What would you like to display?");
            Console.WriteLine("1 - total capacity");
            Console.WriteLine("2 - total carrying");
            Console.WriteLine("3 - Sorting by range");
            Console.WriteLine("4 - Sorting by capacity");
            Console.WriteLine("5 - Sorting by carrying");
            Console.WriteLine("6 - Search plane by range. Please enter range");
            Console.WriteLine("7 - Sorting by given range");
            Console.WriteLine("0 - Exit");

            var isOption = int.TryParse(Console.ReadLine(), out var option);

            if (isOption)
            {
                if (option == 0)
                {
                    return;
                }
                else if (option <= 7 && option > 0)
                {
                    SelectedBlock(plane, option);
                }
                else
                {
                    InputError(plane);
                }
            }
            else
            {
                InputError(plane);
            }
        }

        static void SelectedBlock(AirCompany plane, int option)
        {
            switch (option)
            {
                case 1:
                    var totalCapacity = plane.CountTotalCapacity();
                    Console.WriteLine($"Total capacity: {totalCapacity}");
                    break;
                case 2:
                    var totalCarrying = plane.CountTotalCarrying();
                    Console.WriteLine($"Total carrying: {totalCarrying}");
                    break;
                case 3:
                    plane.PrintSortByRange();
                    break;
                case 4:
                    plane.PrintSortByCapacity();
                    break;
                case 5:
                    plane.PrintSortByCarrying();
                    break;
                case 6:
                    Console.WriteLine("Please enter a number by range:");
                    Console.WriteLine("6574||\t5425||\t4444||\t4400||\t4800||\t3900||\t3334");

                    var isRangeForChoice = double.TryParse(Console.ReadLine(), out var choice);

                    if (isRangeForChoice && (choice == 6574 || choice == 5425 || choice == 4444 || choice == 4400 || choice == 4800 || choice == 3900 || choice == 3344))
                    {
                        plane.SampleSort(choice);
                    }
                    else
                    {
                        InputError(plane);

                    }
                    break;
                case 7:
                    Console.WriteLine("Please enter a max value by range");

                    if (double.TryParse(Console.ReadLine(), out var valueRange) && valueRange >= 3334 && valueRange <= 6574)
                    {
                        plane.SortByTheGivenRange(valueRange);
                    }
                    else
                    {
                        Console.WriteLine("You enter a wrong number or you are out of range");
                    }
                    break;
                default:
                    InputError(plane);
                    break;
            }
        }

        static void InputError(AirCompany plane)
        {
            Console.WriteLine("You don't enter a number or you enter a wrong number");
        }
    }
}