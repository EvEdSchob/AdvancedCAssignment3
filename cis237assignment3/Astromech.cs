using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility, IDroid
    {
        //Variables
        private bool _fireExtinguisher;
        private int _numberOfShips;
        private decimal modelCost;
        private decimal baseCost;
        private decimal totalCost;
        //Properties
        decimal IDroid.TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        
        //Constructors
        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberOfShips) 
            : base (Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            CalculateTotalCost();
        }

        public override void CalculateTotalCost()
        {
            totalCost = baseCost + 50;
        }
    }
}
