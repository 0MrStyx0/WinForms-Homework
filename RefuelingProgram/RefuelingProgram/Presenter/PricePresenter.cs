using RefuelingProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefuelingProgram.Presenter
{
    public class PricePresenter
    {
        public Price price { get; set; } = new Price();
        public float HotDogSum {  get; set; }
        public float HamburgerSum {  get; set; }
        public float FrenchFriesSum {  get; set; }
        public float ColaSum {  get; set; }

        public float MenuOperation(float price,int count)
        {
            float result;
            if (price == this.price.HotDog)
            {
                result = price * count;
                HotDogSum = result;
            }
            else if (price == this.price.Hamburger)
            {
                result = price * count;
                HamburgerSum = result;
            }
            else if (price == this.price.FrenchFries)
            {
                result = price * count;
                FrenchFriesSum = result;
            }
            else if (price == this.price.Cola)
            {
                result = price * count;
                ColaSum = result;
            }

            this.price.Menu = HotDogSum + HamburgerSum + FrenchFriesSum + ColaSum;
            return (float)Math.Round(this.price.Menu, 3);
        }

        public float PriceCalculation(int liters, string fuel)
        {
            switch (fuel)
            {
                case "92":
                    return (float)Math.Round(price.Fuel = liters * price.Fuel92, 3);

                case "95":
                    return (float)Math.Round(price.Fuel = liters * price.Fuel95, 3);

                case "98":
                    return (float)Math.Round(price.Fuel = liters * price.Fuel98, 3);

                case "Diesel":
                    return (float)Math.Round(price.Fuel = liters * price.Diesel, 3);

                case "Gas":
                    return (float)Math.Round(price.Fuel = liters * price.Gas, 3);
            }
            return price.Fuel;
        }

        public float LitersCalculation(int price, string fuel)
        {
            float liters;
            switch (fuel)
            {
                case "92":
                    this.price.Fuel = price;
                    return (float)Math.Round(liters = price / this.price.Fuel92, 2);

                case "95":
                    this.price.Fuel = price;
                    return (float)Math.Round(liters = price / this.price.Fuel95, 2);

                case "98":
                    this.price.Fuel = price;
                    return (float)Math.Round(liters = price / this.price.Fuel98, 2);

                case "Diesel":
                    this.price.Fuel = price;
                    return (float)Math.Round(liters = price / this.price.Diesel, 2);

                case "Gas":
                    this.price.Fuel = price;
                    return (float)Math.Round(liters = price / this.price.Gas, 2);
            }
            return 0;
        }

        public float TotalSum()
        {
            price.Total = price.Menu + price.Fuel;
            return (float)Math.Round(price.Total, 2);
        }

        public void RevenuePerDay()
        {
            price.RevenuePerDay += price.Total;
        }
    }
}