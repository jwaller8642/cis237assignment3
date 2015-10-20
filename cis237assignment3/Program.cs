using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cis237assignment3
{
    class Program
    {
        /// <summary>
        ///           ***********Problems***********
        /// Dosen't save to file or print from file correctly
        /// Not sure if im useing calculate methods from othe classes right
        /// No UI, Will work before next assgnment
        /// Not a lot or very detail comment(have to get used to commenting while i code)
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //Variables
            string materialSelected = string.Empty;
            string modelSelected;
            string colorSelected;
            bool toolboxSelected;
            bool computerConnectionSelected;
            bool armSelected;
            bool trashCompatSelected;
            bool vacuumSelected;
            bool fireExtingSelected;
            int numOfChips;
            int numberOfLanguage;
            string userInput = string.Empty;     
            DroidCollection newDroid = new DroidCollection();
            
            // Console.Write("It Still Runs!!!!!!!!!!!");


            while (userInput != "e")
            {
                Console.WriteLine("Type n to add a new droid");
                Console.WriteLine("Type p to print droid");
                Console.WriteLine("Type e to exit");
                Console.Write("Select an opetion: ");
                userInput = Console.ReadLine();
                Console.WriteLine("----------------");

                if (userInput == "n")
                {
                    // All droid Units go throuh this procees
                    Console.WriteLine("--------------------");

                    Console.Write("Material: ");
                    materialSelected = Console.ReadLine();
                    Console.Write("Model: ");
                    modelSelected = Console.ReadLine();
                    Console.Write("Color: ");
                    colorSelected = Console.ReadLine();
                    Console.Write("Droid Model: ");
                    Console.WriteLine("Protocol, Utility, Janitor, Astromech");
                    Console.WriteLine("selcet a Droid");
                    userInput = Console.ReadLine();
                    //if protocol is selceted
                    if (userInput.Equals("protocol", StringComparison.OrdinalIgnoreCase ))
                    {
                        Console.Write("Number of Language: ");
                        numberOfLanguage = Int32.Parse(Console.ReadLine());
                        newDroid.addProtocolDroid(materialSelected, modelSelected, colorSelected, numberOfLanguage);// adds user input
                        newDroid.saveDroidList();// saves user input
                        Console.WriteLine("------------------");

                    }
                        // if utility is selected
                    else if (userInput.Equals("utility", StringComparison.OrdinalIgnoreCase ))
                    {
                        Console.Write("Tool box yes or no ");
                        toolboxSelected = ToBool(Console.ReadLine());
                        Console.Write("Computer Connection yes or no ");
                        computerConnectionSelected = ToBool(Console.ReadLine());
                        Console.Write("Arm yes or no ");
                        armSelected = ToBool(Console.ReadLine());
                        newDroid.addUtilityDroid(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected);// adds user input
                        newDroid.saveDroidList();// saves user input
                        
                    }
                        // if janitor is selected
                    else if(userInput.Equals("janitor", StringComparison.OrdinalIgnoreCase ))
                    {
                        Console.Write("Tool box yes or no ");
                        toolboxSelected = ToBool(Console.ReadLine());
                        Console.Write("Computer Connection yes or no ");
                        computerConnectionSelected = ToBool(Console.ReadLine());
                        Console.Write("Arm yes or no ");
                        armSelected = ToBool(Console.ReadLine());
                        Console.Write("Trash Compactoer yes or no ");
                        trashCompatSelected = ToBool(Console.ReadLine());
                        Console.Write("Vacuum yes or no ");
                        vacuumSelected = ToBool(Console.ReadLine());
                        newDroid.addJanitorDroid(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected, trashCompatSelected, vacuumSelected);// adds user input
                        newDroid.saveDroidList();// saves user input
                        Janitor janitorCost = new Janitor(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected, trashCompatSelected, vacuumSelected);//creates new Janitor object so we can you the methods eith n that class
                        janitorCost.CalculateBaseCost();// Calculate methods from astromech
                        janitorCost.CalculateTotalCost();
                    }
                        //If astromec is selected
                    else if (userInput.Equals("astromech" , StringComparison.OrdinalIgnoreCase ))
                    {
                        Console.Write("Tool box yes or no ");
                        toolboxSelected = ToBool(Console.ReadLine());
                        Console.Write("Computer Connection yes or no ");
                        computerConnectionSelected = ToBool(Console.ReadLine());
                        Console.Write("Arm yes or no ");
                        armSelected = ToBool(Console.ReadLine());
                        Console.Write("FireExtingquisher yes or no ");
                        fireExtingSelected = ToBool(Console.ReadLine());
                        Console.Write("Number of Chips ");
                        numOfChips = Int32.Parse(Console.ReadLine());
                        newDroid.addAstromechDroid(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected, fireExtingSelected, numOfChips); // adds user input
                        newDroid.saveDroidList(); // saves user input
                        Astromech astromechCost = new Astromech(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected, fireExtingSelected, numOfChips); //creates new astromech object so we can you the methods eith n that class
                        astromechCost.CalculateBaseCost(); // Calculate methods from astromech
                        astromechCost.CalculateTotalCost();
                    }
                    else
                    {
                        Console.WriteLine(userInput +" Is Not an Option");
                        Console.WriteLine("------------");
                    }



                }
                    //Print save file
                else if (userInput == "p")
                {
                    newDroid.PrintSDroidList();
                }
            }
        }
        //Help from http://stackoverflow.com/questions/3716845/casting-y-or-n-to-bool-c-sharp
        private static bool ToBool(string UserInput)
        {
           if(UserInput.Equals("y", StringComparison.OrdinalIgnoreCase))
           {
               return true;
           }
            else if(UserInput.Equals("n", StringComparison.OrdinalIgnoreCase))
           {
                return false;
           }
            else
           {
                throw new Exception();
            }
        }    
    }
}
