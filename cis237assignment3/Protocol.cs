using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        //Variables
        int numberOfLanguages;
        const int costPerLanguage = 2000;
        //4 perameter constuctor
        public Protocol( string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            this.numberOfLanguages = NumberOfLanguages;
            this.BaseCost = 3000;
        }

        //add number of languages
        public override string ToString()
        {
            return base.ToString() + " " + this.numberOfLanguages;
        }
        //calculate total cost base of number of languages
        public override void CalculateTotalCost()
        {
            double costOfLanguage = numberOfLanguages * costPerLanguage;
        }
        //returns base cost.
        public override double CalculateBaseCost()
        {
            return this.BaseCost;
        }
        public override decimal TotalCost { get; set; }
    }
}
