using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegemony.Models
{

    public class WorkingClassModel
    {
        public Color MyBackgroundColor { get; set; } = Color.FromRgb(225, 0, 27);
        static int[] incomeTaxArray;
        static int incomeTax;
        static int incomeTaxMultiplier;
        static int population;
        static int wageTotal;

        public int WageTotal
        {
            get { return wageTotal; }
            set
            {
                wageTotal = value;
            }
        }

        public int IncomeTax
        {
            get { return incomeTax; }
            set
            {
                incomeTax = value;
            }
        }
        public int[] IncomeTaxArray
        {
            get { return incomeTaxArray; }
            set
            {
                incomeTaxArray = value;
            }
        }
        public int IncomeTaxMultiplier
        {
            get { return incomeTaxMultiplier; }
            set
            {
                incomeTaxMultiplier = value;
            }
        }
        public int Population
        {
            get { return population; }
            set
            {
                population = value;
            }
        }
    }

}
