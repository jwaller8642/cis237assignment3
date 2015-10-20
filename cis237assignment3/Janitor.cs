using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //variables
        bool trashCompactor;
        bool vacuum;
        //8 paramentor contructor
        public Janitor(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum) : 
            base(Material,Model,Color,ToolBox,ComputerConnection,Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
            this.BaseCost = 6000;
        }
        //Overide string method in utility
        public override string ToString()
        {
            return base.ToString() + " " + this.trashCompactor + " " + this.vacuum;
        }
    }
}
