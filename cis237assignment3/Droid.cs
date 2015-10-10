using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
   abstract class Droid : IDroid
    {

       //Variables
       string material;
       string model;
       string color;
       double baseCost;
       double totalCost;

       //Properties
       public string Material
       {
           get { return material; }
           set { material = value; }
       }
       public string Model
       {
           get { return model; }
           set { model = value; }
       }
       public string Color
       {
           get { return color; }
           set { color = value; }
       }

       public double BaseCost
       {
           get { return baseCost; }
           set { baseCost = value; }
       }

       public double TotalCost1
       {
           get { return totalCost; }
           set { totalCost = value; }
       }
       //3 Paremeter Construtor
       public Droid(string Material, string Model, string Color)
       {
           this.material = Material;
           this.model = Model;
           this.color = Color;
       }

    //  public override string Tosting()
      // {
        //   return this.Material + " " + this.Color + " " + this.Model;
       //}

      
       public abstract double CalculateBaseCost();
       public abstract void CalculateTotalCost();
       public abstract decimal TotalCost { get; set; }
    }
}
