using Hegemony.Models;
using Microsoft.Maui.Controls;

namespace Hegemony.Views
{

    public partial class WorkingClassPage : ContentPage
    {
        Button lastPopulationButton;
        PolicyModel policyModel = new PolicyModel();
        WorkingClassModel workingClassModel = new WorkingClassModel();
        public WorkingClassPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayIncomeTax.Text = "0";
            //a piece of code specified
        }

        public void CountIncomeTax()
        {
            CountIncomeTaxMultiplier();
            workingClassModel.IncomeTax = workingClassModel.Population * workingClassModel.IncomeTaxMultiplier;
            DisplayIncomeTax.Text = workingClassModel.IncomeTax.ToString();
        }
        public void ResetLastPopulationButton(object sender)
        {
            Button clickedButton = (Button)sender;
            if (lastPopulationButton != null)
            {
                lastPopulationButton.BackgroundColor = workingClassModel.MyBackgroundColor;
            }
            clickedButton.BackgroundColor = Colors.White;
            lastPopulationButton = clickedButton;
        }
        public void C3(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 3;
            CountIncomeTax();
        }
        public void C4(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 4;
            CountIncomeTax();
        }
        public void C5(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 5;
            CountIncomeTax();
        }
        public void C6(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 6;
            CountIncomeTax();
        }
        public void C7(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 7;
            CountIncomeTax();
        }
        public void C8(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 8;
            CountIncomeTax();
        }
        public void C9(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 9;
            CountIncomeTax();
        }
        public void C10(object sender, EventArgs e)
        {
            ResetLastPopulationButton(sender);
            workingClassModel.Population = 10;
            CountIncomeTax();
        }
        public void CountIncomeTaxMultiplier()
        {
            if (policyModel.PolicyTwo == 3)
            {
                workingClassModel.IncomeTaxArray = new int[] { 7, 6, 5 };
                switch (policyModel.PolicyThree)
                {
                    case 3:
                        workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[0];
                        break;
                    case 2:
                        workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[1];
                        break;
                    case 1:
                        workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[2];
                        break;
                }

            }
            else if (policyModel.PolicyTwo == 2)
            {
                workingClassModel.IncomeTaxArray = new int[] { 4, 4, 4 };
                switch (policyModel.PolicyThree)
                {
                    case 3:
                        workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[0];
                        break;
                    case 2:
                        workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[1];
                        break;
                    case 1:
                        workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[2];
                        break;
                }
            }
            else
                workingClassModel.IncomeTaxArray = new int[] { 1, 2, 3 };
            switch (policyModel.PolicyThree)
            {
                case 3:
                    workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[0];
                    break;
                case 2:
                    workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[1];
                    break;
                case 1:
                    workingClassModel.IncomeTaxMultiplier = workingClassModel.IncomeTaxArray[2];
                    break;
            }
        }
    }
}