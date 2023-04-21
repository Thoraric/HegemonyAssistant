using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegemony.Models;
public class StateCompany
{
    public bool SelectedCompany { get; set; }
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
    public bool isWorkingClass { get; set; } //True Working, False Middle

    public static List<StateCompany> Companies { get; set; }


}

