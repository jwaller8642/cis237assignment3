using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cis237assignment3
{
    class Program
    {


        static void Main(string[] args)
        {
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
                    if (userInput == "protocol")
                    {
                        Console.Write("Number of Language: ");
                        numberOfLanguage = Int32.Parse(Console.ReadLine());
                        newDroid.addProtocolDroid(materialSelected, modelSelected, colorSelected, numberOfLanguage);
                        newDroid.saveDroidList();
                        Console.WriteLine("================");

                    }
                    else if (userInput == "utility")
                    {
                        Console.WriteLine("Tool box yes or no");
                        toolboxSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Computer Connection yes or no");
                        computerConnectionSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Arm yes or no");
                        armSelected = ToBool(Console.ReadLine());
                        newDroid.addUtilityDroid(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected,armSelected);
                        newDroid.saveDroidList();
                        
                    }
                    else if(userInput == "janitor")
                    {
                        Console.WriteLine("Tool box yes or no");
                        toolboxSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Computer Connection yes or no");
                        computerConnectionSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Arm yes or no");
                        armSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Trash Compactoer yes or no");
                        trashCompatSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Vacuum yes or no");
                        vacuumSelected = ToBool(Console.ReadLine());
                        newDroid.addJanitorDroid(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected, trashCompatSelected,vacuumSelected);
                        newDroid.saveDroidList();
                    }
                    else if (userInput.Equals("astromech" , StringComparison.OrdinalIgnoreCase ))
                    {
                        Console.WriteLine("Tool box yes or no");
                        toolboxSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Computer Connection yes or no");
                        computerConnectionSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("Arm yes or no");
                        armSelected = ToBool(Console.ReadLine());
                        Console.WriteLine("FireExtingquisher yes or no");
                        fireExtingSelected = ToBool(Console.ReadLine());
                        Console.Write("Number of Chips");
                        numOfChips = Int32.Parse(Console.ReadLine());
                        newDroid.addAstromechDroid(materialSelected, modelSelected, colorSelected, toolboxSelected, computerConnectionSelected, armSelected, fireExtingSelected, numOfChips);
                        newDroid.saveDroidList();
                    }



                }
            }
        }

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
