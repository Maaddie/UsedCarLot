using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car()
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public Car(string Make, string Model, int Year, double Price, double Mileage)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
           
        }

        public override string ToString()
        {
            string output = $"Make: {Make}\t";
            output += $"Model: {Model}\t";
            output += $"Year: {Year}\t";
            output += $"Price: ${string.Format("{0:n}",Price)}\t";

            return output;
        }
    }
}
