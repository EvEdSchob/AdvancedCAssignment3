using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        //Backing fields
        private string _material;
        private string _model;
        private string _color;
        private decimal modelCost;
        private decimal baseCost;
        private decimal totalCost;


        //Properties
        string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        decimal IDroid.TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        //Constructors
        public Droid(string Material, string Model, string Color)
        {
            CalculateTotalCost();
        }

        //Methods
        public virtual void CalculateTotalCost()
        {

        }
    }
}
