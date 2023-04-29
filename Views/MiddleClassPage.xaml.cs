using Hegemony.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
namespace Hegemony.Views;

public partial class MiddleClassPage : ContentPage
{
    Button lastCompanyButton;
    MiddleClassModel middleClassModel = new MiddleClassModel();
    PolicyModel policyModel = new PolicyModel();
    ObservableCollection<MiddleClassModel.MiddleClassCompany> greenCompanies = new ObservableCollection<MiddleClassModel.MiddleClassCompany>();

    public MiddleClassPage()
    {
        InitializeComponent();
        MiddleClassModel.MiddleClassCompany.Companies = new List<MiddleClassModel.MiddleClassCompany>
        {
                new MiddleClassModel.MiddleClassCompany { companyName = "Convenience Store #1", prodImage="food.svg", radioButtonGroupName="Group1", selectedWage=0, prodFood = 2, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=1, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Convenience Store #2", prodImage="food.svg", radioButtonGroupName="Group2", selectedWage=0, prodFood = 2, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=1, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Fast Food Restaurant", prodImage="food.svg", radioButtonGroupName="Group3", selectedWage=0, prodFood = 3, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=0, wages = new int[] {0, 0, 0} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Organic Farm", prodImage="food.svg", radioButtonGroupName="Group4", selectedWage=0, prodFood = 2, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=2, wages = new int[] {9, 12, 15} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Doctor's Office #1", prodImage="healthcare.svg", radioButtonGroupName="Group5", selectedWage=0, prodFood = 0, prodHC = 2, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=2, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Doctor's Office #2", prodImage="healthcare.svg", radioButtonGroupName="Group6", selectedWage=0, prodFood = 0, prodHC = 2, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=2, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Medical Laboratory", prodImage="healthcare.svg", radioButtonGroupName="Group7", selectedWage=0, prodFood = 0, prodHC = 2, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=4, wages = new int[] {9, 12, 15} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Pharmacy", prodImage="healthcare.svg", radioButtonGroupName="Group8", selectedWage=0, prodFood = 0, prodHC = 4, prodLux=0, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=0, wages = new int[] {0, 0, 0} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Private School", prodImage="education.svg", radioButtonGroupName="Group9", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=2, prodInf=0, hasWorker=false, extraFromWorker=4, wages = new int[] {9, 12, 15} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Training Center", prodImage="education.svg", radioButtonGroupName="Group10", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=4, prodInf=0, hasWorker=false, extraFromWorker=0, wages = new int[] {0, 0, 0} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Tutoring Company", prodImage="education.svg", radioButtonGroupName="Group11", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=2, prodInf=0, hasWorker=false, extraFromWorker=2, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Electronics Store", prodImage="luxury.svg", radioButtonGroupName="Group12", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=2, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=4, wages = new int[] {9, 12, 15} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Game Store", prodImage="luxury.svg", radioButtonGroupName="Group13", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=2, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=2, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Jewelry Store", prodImage="luxury.svg", radioButtonGroupName="Group14", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=4, prodnEdu=0, prodInf=0, hasWorker=false, extraFromWorker=0, wages = new int[] {0, 0, 0} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Local Newspaper", prodImage="influence.svg", radioButtonGroupName="Group15", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=2, hasWorker=false, extraFromWorker=1, wages = new int[] {6, 8, 10} },
                new MiddleClassModel.MiddleClassCompany { companyName = "PR Agency", prodImage="influence.svg", radioButtonGroupName="Group16", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=3, hasWorker=false, extraFromWorker=0, wages = new int[] {0, 0, 0} },
                new MiddleClassModel.MiddleClassCompany { companyName = "Regional Radio Station", prodImage="influence.svg", radioButtonGroupName="Group17", selectedWage=0, prodFood = 0, prodHC = 0, prodLux=0, prodnEdu=0, prodInf=2, hasWorker=false, extraFromWorker=2, wages = new int[] {9, 12, 15} }
        };
        collectionView.ItemsSource = MiddleClassModel.MiddleClassCompany.Companies;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        DisplayEmploymentTax.Text = "0";
        DisplayIncomeTax.Text = "0";

        //a piece of code specified
    }
    public void HasExtraWorker(object sender, EventArgs e)
    {
        var imgButton = (ImageButton)sender;

        var selectedCompany = (MiddleClassModel.MiddleClassCompany)imgButton.BindingContext;

        // Change the image source based on the binding context8
        if (!selectedCompany.hasWorker)
        {
            imgButton.Source = "yesworkingclassworker.svg"; //new image
            selectedCompany.hasWorker = !selectedCompany.hasWorker;
        }
        else
        {
            
            imgButton.Source = "noworkingclassworker.svg"; //previous
            selectedCompany.hasWorker = !selectedCompany.hasWorker;



        }
        CountProduction();
    }

    public void CountProduction()
    {
        int Wages = 0;
        int Foods = 0;
        int Educations = 0;
        int Influences = 0;
        int Healthcares = 0;
        int Luxuries = 0;

        foreach (MiddleClassModel.MiddleClassCompany companies in greenCompanies)
        {
            if (companies.hasWorker)
            {
                Wages += companies.selectedWage;
                Foods += companies.prodFood + (companies.prodFood != 0 ? companies.extraFromWorker : 0);
                Educations += companies.prodnEdu + (companies.prodnEdu != 0 ? companies.extraFromWorker : 0);
                Influences += companies.prodInf + (companies.prodInf != 0 ? companies.extraFromWorker : 0);
                Healthcares += companies.prodHC + (companies.prodHC != 0 ? companies.extraFromWorker : 0);
                Luxuries += companies.prodLux + (companies.prodLux != 0 ? companies.extraFromWorker : 0);
            }
            else
            {
                //Wages += companies.selectedWage;
                Foods += companies.prodFood;
                Educations += companies.prodnEdu;
                Influences += companies.prodInf;
                Healthcares += companies.prodHC;
                Luxuries += companies.prodLux;
            }
        }
        DisplayWage.Text = Wages.ToString();
        DisplayEducation.Text = Educations.ToString();
        DisplayFood.Text = Foods.ToString();
        DisplayHealthcare.Text = Healthcares.ToString();
        DisplayInfluence.Text = Influences.ToString();
        DisplayLuxury.Text = Luxuries.ToString();
    }
    public void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            Color greenColor = Colors.Green;
            RadioButton radioButton = (RadioButton)sender;
            MiddleClassModel.MiddleClassCompany selectedCompany = (MiddleClassModel.MiddleClassCompany)radioButton.BindingContext;
            switch (radioButton.Content)
            {

                case "L3":
                    selectedCompany.selectedWage = selectedCompany.wages[2];
                    selectedCompany.SelectedRadioButton = radioButton.Content.ToString();
                    Console.WriteLine(selectedCompany.selectedWage);

                    break;
                case "L2":
                    selectedCompany.selectedWage = selectedCompany.wages[1];
                    selectedCompany.SelectedRadioButton = radioButton.Content.ToString();
                    Console.WriteLine(selectedCompany.selectedWage);
                    break;
                case "L1":
                    selectedCompany.selectedWage = selectedCompany.wages[0];
                    selectedCompany.SelectedRadioButton = radioButton.Content.ToString();
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
        MiddleClassModel.MiddleClassCompany selectedCompany = row.BindingContext as MiddleClassModel.MiddleClassCompany;

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
        middleClassModel.EmploymentTax = middleClassModel.OperationalCompanies * policyModel.TaxMultiplier;
        DisplayEmploymentTax.Text = middleClassModel.EmploymentTax.ToString();
    }
    public void ResetLastCompanyButton(object sender)
    {
        Button clickedButton = (Button)sender;
        if (lastCompanyButton != null)
        {
            lastCompanyButton.BackgroundColor = middleClassModel.MyBackgroundColor;
        }
        clickedButton.BackgroundColor = Colors.White;
        lastCompanyButton = clickedButton;
    }
    public void C1(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 1;
        CountEmploymentTax();

    }
    public void C2(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 2;
        CountEmploymentTax();
    }
    public void C3(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 3;
        CountEmploymentTax();
    }
    public void C4(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 4;
        CountEmploymentTax();
    }
    public void C5(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 5;
        CountEmploymentTax();
    }
    public void C6(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 6;
        CountEmploymentTax();
    }
    public void C7(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 7;
        CountEmploymentTax();
    }
    public void C8(object sender, EventArgs e)
    {
        ResetLastCompanyButton(sender);
        middleClassModel.OperationalCompanies = 8;
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
        middleClassModel.WorkersInOtherCompanies = int.Parse(this.result.Text);
        CountTaxMultiplier();
        middleClassModel.IncomeTax = middleClassModel.IncomeTaxMultiplier * middleClassModel.WorkersInOtherCompanies;
        DisplayIncomeTax.Text = middleClassModel.IncomeTax.ToString();
    }
    public void OnClear(object sender, EventArgs e)
    {
        this.result.Text = "0";
        middleClassModel.WorkersInOtherCompanies = 0;
        DisplayIncomeTax.Text = middleClassModel.WorkersInOtherCompanies.ToString();
    }
    public void OnDelete(object sender, EventArgs e)
    {
        if (this.result.Text != string.Empty)
        {
            string newResult = this.result.Text.Substring(0, this.result.Text.Length - 1);
            if (newResult.Length >= 1)
            {
            this.result.Text = newResult;
            middleClassModel.WorkersInOtherCompanies = int.Parse(this.result.Text);
            CountTaxMultiplier();
            middleClassModel.IncomeTax = middleClassModel.IncomeTaxMultiplier * middleClassModel.WorkersInOtherCompanies;
            DisplayIncomeTax.Text = middleClassModel.IncomeTax.ToString();
            }
            else { 
            this.result.Text = "0";
            }
        }

    }
    public void CountTaxMultiplier()
    {
        if (policyModel.PolicyTwo == 3)
        {
            middleClassModel.IncomeTaxArray = new int[] { 7, 6, 5 };
            switch (policyModel.PolicyThree)
            {
                case 3:
                    middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[0];
                    break;
                case 2:
                    middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[1];
                    break;
                case 1:
                    middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[2];
                    break;
            }

        }
        else if (policyModel.PolicyTwo == 2)
        {
            middleClassModel.IncomeTaxArray = new int[] { 4, 4, 4 };
            switch (policyModel.PolicyThree)
            {
                case 3:
                    middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[0];
                    break;
                case 2:
                    middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[1];
                    break;
                case 1:
                    middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[2];
                    break;
            }
        }
        else
            middleClassModel.IncomeTaxArray = new int[] { 1, 2, 3 };
        switch (policyModel.PolicyThree)
        {
            case 3:
                middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[0];
                break;
            case 2:
                middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[1];
                break;
            case 1:
                middleClassModel.IncomeTaxMultiplier = middleClassModel.IncomeTaxArray[2];
                break;
        }

    }
}