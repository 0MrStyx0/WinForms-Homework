using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefuelingProgram.Model
{
    public class Price
    {
        public float Fuel92 { get; } = 0.546f;
        public float Fuel95 { get; } = 1.092f;
        public float Fuel98 { get; } = 1.255f;
        public float Diesel { get; } = 0.437f;
        public float Gas { get; } = 0.355f;
        public float Fuel {  get; set; }
        public float HotDog { get; } = 4.15f;
        public float Hamburger { get; } = 5.35f;
        public float FrenchFries { get; } = 3.50f;
        public float Cola { get; } = 1.25f;
        public float Menu {  get; set; }
        public float Total {  get; set; }
        public float RevenuePerDay {  get; set; }
    }
}