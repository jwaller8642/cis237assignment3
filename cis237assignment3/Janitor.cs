using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        bool trashCompactor;
        bool vacuum;

        public Janitor(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum) : 
            base(Material,Model,Color,ToolBox,ComputerConnection,Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
            this.BaseCost = 6000;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.trashCompactor + " " + this.vacuum;
        }
    }
}
