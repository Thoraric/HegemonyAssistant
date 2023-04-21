using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegemony.Models
{ 
    public class PolicyModel : INotifyPropertyChanged
{
        static int policyTwo;
        static int policyThree;
        static int policyFour;
        static int policyFive;
        static int taxMultiplier;
        static int basisOfTaxMultiplier;
        static int modifiedBasisOfTaxMultiplier;
        static int welfareModifier;
        public int PolicyTwo
        {
            get { return policyTwo; }
            set
            {
                policyTwo = value;
                OnPropertyChanged(nameof(policyTwo));
            }
        }
        public int WelfareModifier
    {
        get { return welfareModifier; }
        set
        {
                welfareModifier = value;
                OnPropertyChanged(nameof(welfareModifier));
        }
    }

    public int ModifiedBasisOfTaxMultiplier
    {
        get { return modifiedBasisOfTaxMultiplier; }
        set
        {
                modifiedBasisOfTaxMultiplier = value;
                OnPropertyChanged(nameof(modifiedBasisOfTaxMultiplier));
        }
    }

    public int BasisOfTaxMultiplier
    {
        get { return basisOfTaxMultiplier; }
        set
        {
                basisOfTaxMultiplier = value;
                OnPropertyChanged(nameof(basisOfTaxMultiplier));
        }
    }
    public int TaxMultiplier
    {
        get { return taxMultiplier; }
        set
        {
                taxMultiplier = value;
                OnPropertyChanged(nameof(taxMultiplier));
        }
    }
    public int PolicyFive
    {
        get { return policyFive; }
        set
        {
                policyFive = value;
                OnPropertyChanged(nameof(policyFive));
        }
    }
    public int PolicyFour
    {
        get { return policyFour; }
        set
        {
                policyFour = value;
                OnPropertyChanged(nameof(policyFour));
        }
    }
    public int PolicyThree
    {
        get { return policyThree; }
        set
        {
                policyThree = value;
                OnPropertyChanged(nameof(policyThree));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
}
