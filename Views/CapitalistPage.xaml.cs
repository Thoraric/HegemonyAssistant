using Hegemony.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace Hegemony.Views;

public partial class CapitalistPage : ContentPage
{
    Button lastCompanyButton;
    PolicyModel policyModel = new PolicyModel();
    CapitalistModel capitalistModel = new CapitalistModel();
    ObservableCollection<CapitalistModel.CapitalistCompany> greenCompanies = new ObservableCollection<CapitalistModel.CapitalistCompany>();


    public CapitalistPage()
    {
        InitializeComponent();
        CapitalistModel.CapitalistCompany.Companies = new List<CapitalistModel.CapitalistCompany>
        {
            new CapitalistModel.CapitalistCompany { companyName = "Automated Dairy Farm", prodImage="food.svg", radioButtonGroupName="Group1", selectedWage=0, prodFood = 3, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {0, 0, 0} },
            new CapitalistModel.CapitalistCompany { companyName = "Automated Grain Farm", prodImage="food.svg", radioButtonGroupName="Group2", selectedWage=0, prodFood = 2, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {0, 0, 0} },
            new CapitalistModel.CapitalistCompany { companyName = "Fast Food Chain", prodImage="food.svg", radioButtonGroupName="Group3", selectedWage=0, prodFood = 3, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {10, 15, 20} },
            new CapitalistModel.CapitalistCompany { companyName = "Fish Farm", prodImage="food.svg", radioButtonGroupName="Group4", selectedWage=0, prodFood = 6, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=1, isWorkingClass=true, wages = new int[] {25, 30, 35} },
            new CapitalistModel.CapitalistCompany { companyName = "Supermarket #1", prodImage="food.svg", radioButtonGroupName="Group5", selectedWage=0, prodFood = 4, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=1, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "Supermarket #2", prodImage="food.svg", radioButtonGroupName="Group6", selectedWage=0, prodFood = 4, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=1, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "Vegetable Farm", prodImage="food.svg", radioButtonGroupName="Group7", selectedWage=0, prodFood = 5, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {20, 25, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Clinic #1", prodImage="healthcare.svg", radioButtonGroupName="Group8", selectedWage=0, prodFood = 0, prodHC = 6, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Clinic #2", prodImage="healthcare.svg", radioButtonGroupName="Group9", selectedWage=0, prodFood = 0, prodHC = 6, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Hospital", prodImage="healthcare.svg", radioButtonGroupName="Group10", selectedWage=0, prodFood = 0, prodHC = 7, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Medical Village", prodImage="healthcare.svg", radioButtonGroupName="Group11", selectedWage=0, prodFood = 0, prodHC = 9, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {20, 30, 40} },
            new CapitalistModel.CapitalistCompany { companyName = "Pharmaceutical Company", prodImage="healthcare.svg", radioButtonGroupName="Group34", selectedWage=0, prodFood = 0, prodHC = 8, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=3, isWorkingClass=true, wages = new int[] {20, 30, 40} },
            new CapitalistModel.CapitalistCompany { companyName = "Public Hospital", prodImage="healthcare.svg", radioButtonGroupName="Group12", selectedWage=0, prodFood = 0, prodHC = 4, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "University Hospital", prodImage="healthcare.svg", radioButtonGroupName="Group13", selectedWage=0, prodFood = 0, prodHC = 6, prodLux=0, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {25, 30, 35} },
            new CapitalistModel.CapitalistCompany { companyName = "Academy", prodImage="education.svg", radioButtonGroupName="Group14", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=7, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "College #1", prodImage="education.svg", radioButtonGroupName="Group15", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=6, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "College #2", prodImage="education.svg", radioButtonGroupName="Group16", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=6, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Institute of Technology", prodImage="education.svg", radioButtonGroupName="Group17", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=8, prodInf=0, hasAuto=false, extraFromAuto=3, isWorkingClass=true, wages = new int[] {20, 30, 40} },
            new CapitalistModel.CapitalistCompany { companyName = "Public University", prodImage="education.svg", radioButtonGroupName="Group18", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=4, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "Technical University", prodImage="education.svg", radioButtonGroupName="Group19", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=6, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {25, 30, 35} },
            new CapitalistModel.CapitalistCompany { companyName = "University", prodImage="education.svg", radioButtonGroupName="Group20", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=9, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {20, 30, 40} },
            new CapitalistModel.CapitalistCompany { companyName = "Car Manufacturer", prodImage="luxury.svg", radioButtonGroupName="Group21", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=5, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {0, 0, 0} },
            new CapitalistModel.CapitalistCompany { companyName = "Electronics Manufacturer", prodImage="luxury.svg", radioButtonGroupName="Group22", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=3, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {0, 0, 0} },
            new CapitalistModel.CapitalistCompany { companyName = "Fashion Company", prodImage="luxury.svg", radioButtonGroupName="Group23", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=4, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {10, 15, 20} },
            new CapitalistModel.CapitalistCompany { companyName = "Hotel", prodImage="luxury.svg", radioButtonGroupName="Group24", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=7, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {20, 25, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Shopping Mall #1", prodImage="luxury.svg", radioButtonGroupName="Group25", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=6, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "Shopping Mall #2", prodImage="luxury.svg", radioButtonGroupName="Group26", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=6, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=2, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "Stadium", prodImage="luxury.svg", radioButtonGroupName="Group27", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=8, prodnEdu=0, prodInf=0, hasAuto=false, extraFromAuto=3, isWorkingClass=true, wages = new int[] {25, 30, 35} },
            new CapitalistModel.CapitalistCompany { companyName = "Lobbying Firm", prodImage="influence.svg", radioButtonGroupName="Group28", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=3, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {10, 20, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "National Public Broadcasting", prodImage="influence.svg", radioButtonGroupName="Group29", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=4, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {25, 30, 35} },
            new CapitalistModel.CapitalistCompany { companyName = "Publishing House", prodImage="influence.svg", radioButtonGroupName="Group30", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=3, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {20, 25, 30} },
            new CapitalistModel.CapitalistCompany { companyName = "Radio Station", prodImage="influence.svg", radioButtonGroupName="Group31", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=2, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {10, 15, 20} },
            new CapitalistModel.CapitalistCompany { companyName = "Regional TV Station", prodImage="influence.svg", radioButtonGroupName="Group32", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=3, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {15, 20, 25} },
            new CapitalistModel.CapitalistCompany { companyName = "TV Station", prodImage="influence.svg", radioButtonGroupName="Group33", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=4, hasAuto=false, extraFromAuto=0, isWorkingClass=true, wages = new int[] {20, 30, 40} },

        };
        collectionView.ItemsSource = CapitalistModel.CapitalistCompany.Companies;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        DisplayEmploymentTax.Text = "0";
        displayRevenue.Text = "0";
        //a piece of code specified
    }
    public void ChangeClass(object sender, EventArgs e)
    {
        var imgButton = (ImageButton)sender;
        var selectedCompany = (CapitalistModel.CapitalistCompany)imgButton.BindingContext;

        // Change the image source based on the binding context
        if (selectedCompany.isWorkingClass)
        {
            imgButton.Source = "middleclassworker.svg"; //new image
            selectedCompany.isWorkingClass = !selectedCompany.isWorkingClass;
        }
        else
        {
            imgButton.Source = "workingclassworker.svg"; //previous
            selectedCompany.isWorkingClass = !selectedCompany.isWorkingClass;
        }
        CountProduction();
    }
    public void HasAutoToken(object sender, EventArgs e)
    {
        var imgButton = (ImageButton)sender;
        var selectedCompany = (CapitalistModel.CapitalistCompany)imgButton.BindingContext;

        // Change the image source based on the binding context
        if (!selectedCompany.hasAuto)
        {
            imgButton.Source = "autoon.svg"; //new image
            selectedCompany.hasAuto = !selectedCompany.hasAuto;
        }
        else
        {
            imgButton.Source = "autooff.svg"; //previous
            selectedCompany.hasAuto = !selectedCompany.hasAuto;
        }
        CountProduction();
    }
    public void CountProduction()
    {
        int workingWages = 0;
        int capitalistFoods = 0;
        int capitalistEducations = 0;
        int capitalistInfluences = 0;
        int capitalistHealthcares = 0;
        int capitalistLuxuries = 0;
        int middleWages = 0;

        foreach (CapitalistModel.CapitalistCompany companies in greenCompanies)
        {
            if (companies.isWorkingClass)
            {
                workingWages += companies.selectedWage;
                if (companies.hasAuto)
                {
                    capitalistFoods += companies.prodFood + (companies.prodFood != 0 ? companies.extraFromAuto : 0);
                    capitalistEducations += companies.prodnEdu + (companies.prodnEdu != 0 ? companies.extraFromAuto : 0);
                    capitalistInfluences += companies.prodInf + (companies.prodInf != 0 ? companies.extraFromAuto : 0);
                    capitalistHealthcares += companies.prodHC + (companies.prodHC != 0 ? companies.extraFromAuto : 0);
                    capitalistLuxuries += companies.prodLux + (companies.prodLux != 0 ? companies.extraFromAuto : 0);
                }
                else
                {
                   
                    capitalistFoods += companies.prodFood;
                    capitalistEducations += companies.prodnEdu;
                    capitalistInfluences += companies.prodInf;
                    capitalistHealthcares += companies.prodHC;
                    capitalistLuxuries += companies.prodLux;
                }
            }
            else
            {
                middleWages += companies.selectedWage;
                if (companies.hasAuto)
                {

                    capitalistFoods += companies.prodFood + (companies.prodFood != 0 ? companies.extraFromAuto : 0);
                    capitalistEducations += companies.prodnEdu + (companies.prodnEdu != 0 ? companies.extraFromAuto : 0);
                    capitalistInfluences += companies.prodInf + (companies.prodInf != 0 ? companies.extraFromAuto : 0);
                    capitalistHealthcares += companies.prodHC + (companies.prodHC != 0 ? companies.extraFromAuto : 0);
                    capitalistLuxuries += companies.prodLux + (companies.prodLux != 0 ? companies.extraFromAuto : 0);
                }
                else
                {
                    
                    capitalistFoods += companies.prodFood;
                    capitalistEducations += companies.prodnEdu;
                    capitalistInfluences += companies.prodInf;
                    capitalistHealthcares += companies.prodHC;
                    capitalistLuxuries += companies.prodLux;
                }
            }
        }
        DisplayCapitalistWorkingWage.Text = workingWages.ToString();
        DisplayCapitalistEducation.Text = capitalistEducations.ToString();
        DisplayCapitalistFood.Text = capitalistFoods.ToString();
        DisplayCapitalistHealthcare.Text = capitalistHealthcares.ToString();
        DisplayCapitalistInfluence.Text = capitalistInfluences.ToString();
        DisplayCapitalistLuxury.Text = capitalistLuxuries.ToString();

        DisplayCapitalistMiddleWage.Text = middleWages.ToString();
    }
    public void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            Color greenColor = Colors.Green;
            RadioButton radioButton = (RadioButton)sender;
            CapitalistModel.CapitalistCompany selectedCompany = (CapitalistModel.CapitalistCompany)radioButton.BindingContext;
            switch (radioButton.Content)
            {

                case "L3":
                    selectedCompany.selectedWage = selectedCompany.wages[2];
                    Console.WriteLine(selectedCompany.selectedWage);
                    break;
                case "L2":
                    selectedCompany.selectedWage = selectedCompany.wages[1];
                    Console.WriteLine(selectedCompany.selectedWage);
                    break;
                case "L1":
                    selectedCompany.selectedWage = selectedCompany.wages[0];
                    Console.WriteLine(selectedCompany.selectedWage);
                    break;
            }
            CountProduction();
        }
    }
    public void OnRowTapped(object sender, EventArgs e)
    {
        StackLayout row = (StackLayout)sender;
        Color defaultColor = null;
        Color greenColor = Colors.Green;
        CapitalistModel.CapitalistCompany selectedCompany = row.BindingContext as CapitalistModel.CapitalistCompany;

        if (row.BackgroundColor == defaultColor)
        {
            row.BackgroundColor = greenColor;
            greenCompanies.Add(selectedCompany);
            CountProduction();
        }
        else
        {
            row.BackgroundColor = defaultColor;
            greenCompanies.Remove(selectedCompany);
            CountProduction();
        }
    }
    public void CountEmploymentTax()
    {
        capitalistModel.EmploymentTax = capitalistModel.OperationalCompanies * policyModel.TaxMultiplier;
        DisplayEmploymentTax.Text = capitalistModel.EmploymentTax.ToString();
    }

    public void ResetLastCompanyButton(object sender)
    {
        Button clickedButton = (Button)sender;
        if (lastCompanyButton != null)
        {
            lastCompanyButton.BackgroundColor = capitalistModel.MyBackgroundColor;
            lastCompanyButton.TextColor = Colors.White;
        }
        clickedButton.BackgroundColor = Colors.White;
        clickedButton.TextColor = Colors.Black;
        lastCompanyButton = clickedButton;
    }
    public void C1(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 1;
        CountEmploymentTax();

    }
    public void C2(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 2;
        CountEmploymentTax();
    }
    public void C3(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 3;
        CountEmploymentTax();
    }
    public void C4(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 4;
        CountEmploymentTax();
    }
    public void C5(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 5;
        CountEmploymentTax();
    }
    public void C6(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 6;
        CountEmploymentTax();
    }
    public void C7(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 7;
        CountEmploymentTax();
    }
    public void C8(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 8;
        CountEmploymentTax();
    }
    public void C9(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 9;
        CountEmploymentTax();
    }
    public void C10(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 10;
        CountEmploymentTax();
    }
    public void C11(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 11;
        CountEmploymentTax();
    }
    public void C12(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        capitalistModel.OperationalCompanies = 12;
        CountEmploymentTax();
    }
    public void OnNumberSelection(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string btnPressed = button.Text;
        if (this.result.Text == "0")
        {
            this.result.Text = "";
        }
        this.result.Text += btnPressed;
        capitalistModel.Revenue = int.Parse(this.result.Text);
        CountRevenueTax();
        displayRevenue.Text = capitalistModel.Revenue.ToString();
    }
    public void OnDelete(object sender, EventArgs e)
    {
        if (this.result.Text != string.Empty)
        {
            string newResult = this.result.Text.Substring(0, this.result.Text.Length - 1);
            if (newResult.Length >= 1)
            {
                this.result.Text = newResult;
                if (this.result.Text != null)
                {
                    capitalistModel.Revenue = int.Parse(this.result.Text);
                    CountRevenueTax();
                    displayRevenue.Text = capitalistModel.Revenue.ToString();
                }

            }
            else
            {
                this.result.Text = "0";
            }
        }

    }


    public void OnClear(object sender, EventArgs e)
    {
        this.result.Text = "0";
        capitalistModel.Revenue = 0;
        displayRevenue.Text = capitalistModel.Revenue.ToString();
    }

    public void CountRevenueTax()
    {
        //TODO
        try
        {
            switch (policyModel.PolicyThree)
            {
                case 3:
                    capitalistModel.RevenueArray = new int[] { 1, 5, 12, 24, 40, 100, 160 };
                    break;
                case 2:
                    capitalistModel.RevenueArray = new int[] { 2, 5, 10, 15, 30, 70, 120 };
                    break;
                case 1:
                    capitalistModel.RevenueArray = new int[] { 2, 4, 7, 10, 20, 40, 60 };
                    break;
            }
            if (5 <= capitalistModel.Revenue && capitalistModel.Revenue <= 9)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[0];
            }
            else if (10 <= capitalistModel.Revenue && capitalistModel.Revenue <= 24)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[1];
            }
            else if (25 <= capitalistModel.Revenue && capitalistModel.Revenue <= 49)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[2];
            }
            else if (50 <= capitalistModel.Revenue && capitalistModel.Revenue <= 99)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[3];
            }
            else if (100 <= capitalistModel.Revenue && capitalistModel.Revenue <= 199)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[4];
            }
            else if (200 <= capitalistModel.Revenue && capitalistModel.Revenue <= 299)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[5];
            }
            else if (capitalistModel.Revenue >= 300)
            {
                capitalistModel.Revenue = capitalistModel.RevenueArray[6];
            }
            else
                capitalistModel.Revenue = 0;

        }
        catch (Exception ex)
        {
            DisplayAlert("Error", "Please set the policies first", "OK");
        }
    }


}