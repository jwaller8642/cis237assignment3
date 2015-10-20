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
        // From Previous assignment
        List<Droid> collectedDroids = new List<Droid>();

        public string GetCollectedDroid()
        {   
            string droidListString = "";

            foreach (var newDroid in collectedDroids)
            {
                droidListString += newDroid.ToString() + Environment.NewLine;
            }

            return droidListString;
        }
        //add Methods for each droid
        public void addUtilityDroid(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm)
        {
            Utility newDroid = new Utility(Material,Model,Color,ToolBox,ComputerConnection,Arm);
            collectedDroids.Add(newDroid);
        }

        public void addJanitorDroid(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
        {
            Janitor newDroid = new Janitor(Material, Model, Color, ToolBox, ComputerConnection, Arm, TrashCompactor, Vacuum);
            collectedDroids.Add(newDroid);
        }
        public void addAstromechDroid(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtingquisher, int NumberShip)
        {
            Astromech newDroid = new Astromech(Material, Model, Color, ToolBox, ComputerConnection, Arm, FireExtingquisher, NumberShip);
            collectedDroids.Add(newDroid);
        }

        public void addProtocolDroid(string Material, string Model, string Color, int NumberOfLanguages)
        {
            Protocol newDroid = new Protocol(Material, Model, Color, NumberOfLanguages);
            collectedDroids.Add(newDroid);
        }
        //Save And Print Method Below
        public void saveDroidList()
        {
            TextWriter WT = new StreamWriter("Droid.txt");
            WT.WriteLine("Material      Model        Color");
            WT.WriteLine(GetCollectedDroid());
            WT.Close();
        }

        public void PrintSDroidList()
        {
            TextReader RT = new StreamReader("Droid.txt");
            Console.WriteLine(RT.ReadLine());
            RT.Close();
        }

    }
}
