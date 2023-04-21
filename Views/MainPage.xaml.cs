using Microsoft.Maui.Controls;
using System;
using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using Hegemony.Models;

namespace Hegemony.Views
{

    public partial class MainPage : ContentPage
    {
        ImageButton lastclickedButtonNullRow;
        ImageButton lastclickedButtonFirstRow;
        ImageButton lastclickedButtonSecondRow;
        ImageButton lastclickedButtonThirdRow;
        PolicyModel policyModel = new PolicyModel();

        public MainPage()
        {
            InitializeComponent();
        }

        public void CountTaxMultiplier()
        {
            switch (policyModel.PolicyThree)
            {
                case 3:
                    policyModel.BasisOfTaxMultiplier = 3;
                    policyModel.WelfareModifier = 2;
                    break;
                case 2:
                    policyModel.BasisOfTaxMultiplier = 2;
                    policyModel.WelfareModifier = 1;
                    break;
                case 1:
                    policyModel.BasisOfTaxMultiplier = 1;
                    policyModel.WelfareModifier = 0;
                    break;
            }
            switch (policyModel.PolicyFour)
            {
                case 3:
                    policyModel.ModifiedBasisOfTaxMultiplier = policyModel.BasisOfTaxMultiplier + 2 * policyModel.WelfareModifier;
                    break;
                case 2:
                    policyModel.ModifiedBasisOfTaxMultiplier = policyModel.BasisOfTaxMultiplier + 1 * policyModel.WelfareModifier;
                    break;
                case 1:
                    policyModel.ModifiedBasisOfTaxMultiplier = policyModel.BasisOfTaxMultiplier + 0 * policyModel.WelfareModifier;
                    break;
            }
            switch (policyModel.PolicyFive)
            {
                case 3:
                    policyModel.TaxMultiplier = policyModel.ModifiedBasisOfTaxMultiplier + 2 * policyModel.WelfareModifier;
                    break;
                case 2:
                    policyModel.TaxMultiplier = policyModel.ModifiedBasisOfTaxMultiplier + 1 * policyModel.WelfareModifier;
                    break;
                case 1:
                    policyModel.TaxMultiplier = policyModel.ModifiedBasisOfTaxMultiplier + 0 * policyModel.WelfareModifier;
                    break;
            }
            displayTaxMultiplier.Text = policyModel.TaxMultiplier.ToString();

        }

        public void P2AClicked(object sender, EventArgs e)
        {
            ResetLastButtonNullRow(sender);
            policyModel.PolicyTwo = 3;
            

        }


        public void P2BClicked(object sender, EventArgs e)
        {
            ResetLastButtonNullRow(sender);
            policyModel.PolicyTwo = 2;
        }
        public void P2CClicked(object sender, EventArgs e)
        {
            ResetLastButtonNullRow(sender);
            policyModel.PolicyTwo = 1;
        }
        public void P3AClicked(object sender, EventArgs e)
        {
            ResetLastButtonFirstRow(sender);
            policyModel.PolicyThree = 3;
            CountTaxMultiplier();

        }
        public void P3BClicked(object sender, EventArgs e)
        {
            ResetLastButtonFirstRow(sender);
            policyModel.PolicyThree = 2;
            CountTaxMultiplier();
        }
        public void P3CClicked(object sender, EventArgs e)
        {
            ResetLastButtonFirstRow(sender);
            policyModel.PolicyThree = 1;
            CountTaxMultiplier();
        }

        public void P4AClicked(object sender, EventArgs e)
        {
            ResetLastButtonSecondRow(sender);
            policyModel.PolicyFour = 3;
            CountTaxMultiplier();

        }
        public void P4BClicked(object sender, EventArgs e)
        {
            ResetLastButtonSecondRow(sender);
            policyModel.PolicyFour = 2;
            CountTaxMultiplier();

        }
        public void P4CClicked(object sender, EventArgs e)
        {
            ResetLastButtonSecondRow(sender);
            policyModel.PolicyFour = 1;
            CountTaxMultiplier();

        }
        public void P5AClicked(object sender, EventArgs e)
        {
            ResetLastButtonThirdRow(sender);
            policyModel.PolicyFive = 3;
            CountTaxMultiplier();

        }
        public void P5BClicked(object sender, EventArgs e)
        {
            ResetLastButtonThirdRow(sender);
            policyModel.PolicyFive = 2;
            CountTaxMultiplier();

        }
        public void P5CClicked(object sender, EventArgs e)
        {
            ResetLastButtonThirdRow(sender);
            policyModel.PolicyFive = 1;
            CountTaxMultiplier();
        }

        public void ResetLastButtonNullRow(object sender)
        {
            ImageButton clickedButton = (ImageButton)sender;
            if (lastclickedButtonNullRow != null)
            {
                lastclickedButtonNullRow.Scale = 1;
            }
            clickedButton.Scale = 0.8;
            lastclickedButtonNullRow = clickedButton;
        }
        public void ResetLastButtonFirstRow(object sender)
        {
            ImageButton clickedButton = (ImageButton)sender;
            if (lastclickedButtonFirstRow != null)
            {
                lastclickedButtonFirstRow.Scale = 1;
            }
            clickedButton.Scale = 0.8;
            lastclickedButtonFirstRow = clickedButton;
        }
        public void ResetLastButtonSecondRow(object sender)
        {
            ImageButton clickedButton = (ImageButton)sender;
            if (lastclickedButtonSecondRow != null)
            {
                lastclickedButtonSecondRow.Scale = 1;
            }
            clickedButton.Scale = 0.8;
            lastclickedButtonSecondRow = clickedButton;
        }
        public void ResetLastButtonThirdRow(object sender)
        {
            ImageButton clickedButton = (ImageButton)sender;
            if (lastclickedButtonThirdRow != null)
            {
                lastclickedButtonThirdRow.Scale = 1;
            }
            clickedButton.Scale = 0.8;
            lastclickedButtonThirdRow = clickedButton;
        }
    }
}


