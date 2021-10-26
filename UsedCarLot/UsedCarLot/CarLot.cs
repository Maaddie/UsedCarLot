using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class CarLot : Car
    {
        List<Car> Cars { get; set; } = new List<Car>();

        public CarLot()
        {
            Cars.Add(new Car("Toyota", "Corolla", 2022, 28998, 72));
            Cars.Add(new Car("Honda", "Civic", 2021, 30998, 42));
            Cars.Add(new Car("Lexus", "ES350", 2021, 44998, 40));
            Cars.Add(new UsedCar("Chevrolet","Tahoe", 2021, 79998, 24.216));
            Cars.Add(new UsedCar("GMC", "Youkon XL", 2020, 56998, 52.970));
            Cars.Add(new UsedCar("Chevrolet", "Tahoe", 2021, 79998, 24.216));


        }

        public void PrintCars()
        {
            for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine( i + ". " + Cars[i].ToString());
            }
        }

        //Method to add cars
        public void AddCar(string Make, string Model, int Year, double Price, double Mileage)
        {
            if(Mileage > 1000)
            {
                UsedCar carToAdd = new UsedCar(Make, Model, Year, Price, Mileage);
                Cars.Add(carToAdd);
            }
            else
            {
                Car newCarToAdd = new Car(Make, Model, Year, Price, Mileage);
                Cars.Add(newCarToAdd);
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Hello! Welcome to Maddie's Car Lot!");
            while (true)
            {
                try
                {

                    Console.WriteLine("Please select one of the below options: ");
                    PrintCars();
                    Console.WriteLine(Cars.Count + ". Add a car");
                    Console.WriteLine((Cars.Count + 1) + ". Quit");
                    int userSelection = int.Parse(Console.ReadLine());


                    if (userSelection == Cars.Count)
                    {
                        //Add a car
                        Console.WriteLine("Please enter the following information about the car you would like to add: ");
                        Console.WriteLine("Please enter the Make: ");
                        string makeinput = Console.ReadLine();
                        Console.WriteLine("Please enter the Model of the car: ");
                        string modelInput = Console.ReadLine();
                        Console.WriteLine("Please enter the Year the car was made in: ");
                        int yearInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the Price of the car: ");
                        double priceInput = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the Mileage of the car: ");
                        double mileageInput = double.Parse(Console.ReadLine());

                        this.AddCar(makeinput, modelInput, yearInput, priceInput, mileageInput);

                    }
                    else if (userSelection == Cars.Count + 1)
                    {
                        Console.WriteLine("Have a nice day!");
                        break;
                    }
                    else if (userSelection > Cars.Count)
                    {
                        Console.WriteLine("Sorry, the selection you have made is invalid.");
                    }
                    else
                    {
                        //based on user selection display the car
                        Console.WriteLine(Cars[userSelection].ToString());
                        Console.WriteLine("Would you like to buy the car? y/n");
                        string userInput = Console.ReadLine().ToLower();

                        if (userInput == "y" || userInput == "yes")
                        {
                            Console.WriteLine("Congratulations! We will be in touch to put together final details!");
                            //This will remove the car from the list 
                            Cars.RemoveAt(userSelection);
                        }
                        else
                        {
                            Console.WriteLine("Okay! Please make another selection: ");
                        }

                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Oh no! That's not good! Try again. ");
                    break;
                }
            }
        }
    }
}
