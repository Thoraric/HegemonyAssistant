using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegemony.Models
{
    public class MiddleClassModel
    {
        public class MiddleClassCompany
        {
            public string prodImage { get; set; }
            public string companyName { get; set; }
            public string radioButtonGroupName { get; set; }
            public int prodFood { get; set; }
            public int prodHC { get; set; }
            public int prodLux { get; set; }
            public int prodnEdu { get; set; }
            public int prodInf { get; set; }
            public int extraFromWorker { get; set; }
            public bool hasWorker { get; set; }
            public int[] wages { get; set; }
            public int selectedWage { get; set; }
            public static List<MiddleClassCompany> Companies { get; set; }
        }
            

            public Color MyBackgroundColor { get; set; } = Color.FromRgb(252, 193, 49);

            static int[] incomeTaxArray;
            static int employmentTax;
            static int operationalCompanies;
            static int incomeTax;
            static int incomeTaxMultiplier;
            static int workersInOtherCompanies;

        public int IncomeTaxMultiplier
        {
            get { return incomeTaxMultiplier; }
            set
            {
                incomeTaxMultiplier = value;
            }
        }
        public int WorkersInOtherCompanies
        {
            get { return workersInOtherCompanies; }
            set
            {
                workersInOtherCompanies = value;
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
        public int EmploymentTax
        {
            get { return employmentTax; }
            set
            {
                employmentTax = value;
            }
        }
        public int OperationalCompanies
        {
            get { return operationalCompanies; }
            set
            {
                operationalCompanies = value;
            }
        }

    }
}
