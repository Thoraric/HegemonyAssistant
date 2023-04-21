using Hegemony.Models;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Hegemony.Views;

public partial class StateClassPage : ContentPage
{
    List<StateCompany> greenCompanies = new List<StateCompany>();

    public StateClassPage()
    {
        InitializeComponent();
        StateCompany.Companies = new List<StateCompany>
        {
            new StateCompany { companyName = "Public Hospital #1", prodImage = "healthcare.svg", radioButtonGroupName = "Group1", selectedWage = 0, prodFood = 0, prodHC = 4, prodLux = 0, prodnEdu = 0, prodInf = 0, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Public Hospital #2", prodImage = "healthcare.svg", radioButtonGroupName = "Group2", selectedWage = 0, prodFood = 0, prodHC = 4, prodLux = 0, prodnEdu = 0, prodInf = 0, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Public Hospital #3", prodImage = "healthcare.svg", radioButtonGroupName = "Group3", selectedWage = 0, prodFood = 0, prodHC = 4, prodLux = 0, prodnEdu = 0, prodInf = 0, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "University Hospital", prodImage = "healthcare.svg", radioButtonGroupName = "Group4", selectedWage = 0, prodFood = 0, prodHC = 6, prodLux = 0, prodnEdu = 0, prodInf = 0, isWorkingClass = true, wages = new int[] { 25, 30, 35 } },
            new StateCompany { companyName = "Public University #1", prodImage = "education.svg", radioButtonGroupName = "Group5", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 4, prodInf = 0, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Public University #2", prodImage = "education.svg", radioButtonGroupName = "Group6", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 4, prodInf = 0, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Public University #3", prodImage = "education.svg", radioButtonGroupName = "Group7", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 4, prodInf = 0, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Technical University", prodImage = "education.svg", radioButtonGroupName = "Group8", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 6, prodInf = 0, isWorkingClass = true, wages = new int[] { 25, 30, 35 } },
            new StateCompany { companyName = "Regional TV Station #1", prodImage = "influence.svg", radioButtonGroupName = "Group9", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 0, prodInf = 3, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Regional TV Station #2", prodImage = "influence.svg", radioButtonGroupName = "Group10", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 0, prodInf = 3, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "Regional TV Station #3", prodImage = "influence.svg", radioButtonGroupName = "Group11", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 0, prodInf = 3, isWorkingClass = true, wages = new int[] { 15, 20, 25 } },
            new StateCompany { companyName = "National Public Broadcasting", prodImage = "influence.svg", radioButtonGroupName = "Group12", selectedWage = 0, prodFood = 0, prodHC = 0, prodLux = 0, prodnEdu = 0, prodInf = 4, isWorkingClass = true, wages = new int[] { 25, 30, 35 } }
        };
        collectionView.ItemsSource = StateCompany.Companies;
    }
    

    public void ChangeClass(object sender, EventArgs e)
    {
        var imgButton = (ImageButton)sender;
        var selectedCompany = (StateCompany)imgButton.BindingContext;

        // Change the image source based on the binding context
        if (!selectedCompany.isWorkingClass)
        {
            imgButton.Source = "workingclassworker.svg"; //new image
            selectedCompany.isWorkingClass = !selectedCompany.isWorkingClass;
        }
        else
        {
            imgButton.Source = "middleclassworker.svg"; //previous
            selectedCompany.isWorkingClass = !selectedCompany.isWorkingClass;
        }
        CountProduction();
    }

    public void CountProduction()
    {
        int workingWages = 0;
        int middleWages = 0;
        int stateFoods = 0;
        int stateEducations = 0;
        int stateInfluences = 0;
        int stateHealthcares = 0;
        int stateLuxuries = 0;

        foreach (StateCompany companies in greenCompanies)
        {
            if (companies.isWorkingClass)
            {
                    workingWages += companies.selectedWage;
            }
            else //IF middle
            {
                middleWages += companies.selectedWage;
            }
            stateFoods += companies.prodFood;
            stateEducations += companies.prodnEdu;
            stateInfluences += companies.prodInf;
            stateHealthcares += companies.prodHC;
            stateLuxuries += companies.prodLux;
        }
        DisplayStateMiddleWage.Text = middleWages.ToString();
        DisplayStateEducation.Text = stateEducations.ToString();
        DisplayStateFood.Text = stateFoods.ToString();
        DisplayStateHealthcare.Text = stateHealthcares.ToString();
        DisplayStateInfluence.Text = stateInfluences.ToString();
        DisplayStateLuxury.Text = stateLuxuries.ToString();
        DisplayStateWorkingWage.Text = workingWages.ToString();

    }
    public void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            Color greenColor = Colors.Green;
            RadioButton radioButton = (RadioButton)sender;
            StateCompany selectedCompany = (StateCompany)radioButton.BindingContext;
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
        StateCompany selectedCompany = row.BindingContext as StateCompany;

        if (row.BackgroundColor != greenColor)
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
}