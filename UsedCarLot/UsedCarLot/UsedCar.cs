using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string Make, string Model, int Year, double Price, double Mileage) : base(Make, Model, Year, Price, Mileage)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.Mileage = Mileage;
        }
        public override string ToString()
        {
            string output = $"Make: {Make}\t";
            output += $"Model: {Model}\t";
            output += $"Year: {Year}\t";
            output += $"Price: ${string.Format("{0:n}", Price)}\t";
            output += $"Mileage: {Mileage}\t";
            output += $"Used";
           
            return output;
        }
    }
}
