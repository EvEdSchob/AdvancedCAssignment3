using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid, IDroid
    {
        private bool _toolBox;
        private bool _computerConnection;
        private bool _arm;
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
        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm) : base(Material, Model, Color)
        {
            _toolBox = ToolBox;
            _computerConnection = ComputerConnection;
            _arm = Arm;
            CalculateTotalCost();
        }

        public override void CalculateTotalCost()
        {
            totalCost = baseCost + 50;
        }
    }
}
