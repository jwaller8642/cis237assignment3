using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237assignment3
{
    class DroidCollection
    {
        List<Droid> droidlist = new List<Droid>();

        public string GetDroidList()
        {   
            string droidListString = "";

            foreach (var droid in droidlist)
            {
                droidListString += droid.ToString() + Environment.NewLine;
            }

            return droidListString;
        }

        public void addUtilityDroid(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm)
        {
            Utility newDroid = new Utility(Material,Model,Color,ToolBox,ComputerConnection,Arm);
            droidlist.Add(newDroid);
        }

        public void addJanitorDroid(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
        {
            Janitor newDroid = new Janitor(Material, Model, Color, ToolBox, ComputerConnection, Arm, TrashCompactor, Vacuum);
            droidlist.Add(newDroid);
        }
        public void addAstromechDroid(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtingquisher, int NumberShip)
        {
            Astromech newDroid = new Astromech(Material, Model, Color, ToolBox, ComputerConnection, Arm, FireExtingquisher, NumberShip);
            droidlist.Add(newDroid);
        }

        public void addProtocolDroid(string Material, string Model, string Color, int NumberOfLanguages)
        {
            Protocol newDroid = new Protocol(Material, Model, Color, NumberOfLanguages);
            droidlist.Add(newDroid);
        }

        public void saveDroidList()
        {
            TextWriter WT = new StreamWriter("Droid.txt");
            WT.WriteLine("Material      Model        Color");
            WT.WriteLine(GetDroidList());
            WT.Close();
        }
    }
}
