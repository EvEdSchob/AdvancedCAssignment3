using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid, IDroid
    {
        //Variables
        private int _numberLanguages;
        private const int costPerLanguage = 50;
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
        public Protocol(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            _numberLanguages = NumberOfLanguages;
            CalculateTotalCost();
        }

        //Methods
        public override void CalculateTotalCost()
        {
            totalCost = baseCost + 50;
        }
    }
}
