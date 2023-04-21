using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegemony.Models;

public class CapitalistModel
{
    public class CapitalistCompany
    {

        public string prodImage { get; set; }
        public string companyName { get; set; }
        public string radioButtonGroupName { get; set; }
        public int prodFood { get; set; }
        public int prodHC { get; set; }
        public int prodLux { get; set; }
        public int prodnEdu { get; set; }
        public int prodInf { get; set; }
        public int[] wages { get; set; }
        public int selectedWage { get; set; }
        public bool hasAuto { get; set; }
        public bool isWorkingClass { get; set; }
        public int extraFromAuto { get; set; }
        public static List<CapitalistCompany> Companies { get; set; }

    }
    public Color MyBackgroundColor { get; set; } = Color.FromRgb(8, 131, 198);
    static int[] revenueArray;
    static int corporateTax;
    static int employmentTax;
    static int operationalCompanies;
    static int revenue;
    public int[] RevenueArray
    {
        get { return revenueArray; }
        set
        {
            revenueArray = value;
        }
    }
    public int CorporateTax
    {
        get { return corporateTax; }
        set
        {
            corporateTax = value;
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
    public int Revenue
    {
        get { return revenue; }
        set
        {
            revenue = value;
        }
    }
}
