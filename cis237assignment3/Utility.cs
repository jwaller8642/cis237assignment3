using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        //Variabbles
        bool toolbox;
        bool computerConnection;
        bool arm;
        
        //Properties
        public bool Toolbox
        {
            get { return toolbox; }
            set { toolbox = value; }
        }
        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }
        }

        public bool Arm
        {
            get { return arm; }
            set { arm = value; }
        }

        //
        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm) : base (Material , Model,Color)
        {
            this.toolbox = ToolBox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
            this.BaseCost = 4000;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.toolbox + " " + this.computerConnection + " " + this.arm;
        }

        public override double CalculateBaseCost()
        {
            return this.BaseCost;
        }

        public override decimal TotalCost { get; set; }
        public override void CalculateTotalCost()
        {

        }
    }
}
