using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        //Variables
        bool fireExtingquisher;
        int numberShips;
        const int costPerShips = 3500;


        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtingquisher, int NumberShips)
            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.fireExtingquisher = FireExtingquisher;
            this.numberShips = NumberShips;
            this.BaseCost = 1200;
        }

        public override void CalculateTotalCost()
        {
            double costOfShips = numberShips * costPerShips;
        }

        public override double CalculateBaseCost()
        {
            return this.BaseCost;
        }
    }
}
