using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitorial : Utility, IDroid
    {
        //Variables
        private bool _trashCompactor;
        private bool _vacuum;
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
        public Janitorial(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum) 
                            : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)

        {
            _trashCompactor = TrashCompactor;
            _vacuum = Vacuum;
            CalculateTotalCost();
        }

        public override void CalculateTotalCost()
        {
            totalCost = baseCost + 50;
        }
    }
}
