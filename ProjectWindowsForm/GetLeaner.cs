using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;


namespace ProjectWindowsForm
{
    public partial class GetLeanerWin : Form
    {
        public double Pesaje { get; private set; }
        public double TotalProteina { get; private set; }



        public GetLeanerWin()
        {
            InitializeComponent();
        }

        public void SubmitionIcon_Click(object sender, EventArgs e)
        {


            int inputPeso;
            if (isWeightValid(InputWeight.Text))
            {
                inputPeso = Int32.Parse(InputWeight.Text);
            }
            else
            {
                MessageBox.Show("That is not a valid weight");
                return;
            }
            // string inputPeso = InputWeight.Text;
            // double Pesaje = double.Parse(inputPeso);          
            double TotalProteina = inputPeso + 25;
            double TotalCarbs = TotalProteina + 92;
            double Magiccalories = 2700; // Change(lower) If Needed  Max is 2000Cal over this 2800 is for bulking up for males,Woman are around 1500 to 2300 cal per meal.
            double TotalFats = Magiccalories * .25 / 7; // Max fat to consume is 60 to 115 fats range. 
            double RoundedFats = Math.Ceiling(TotalFats);
            double waterNeeded = 1;
            Proteinoutput.Text = Convert.ToString(TotalProteina);
            Carbsoutput.Text = Convert.ToString(TotalCarbs);
            CaloriesOutput.Text = Convert.ToString(Magiccalories);
            Wateroutput.Text = "1 Gallon"; // notes paso mas importante MORE water(1 gallon to 1.5 gallons) to lose unnecessary weight and detox and you will see result in about a week,  Science is weird. 
            Fatsoutput.Text = Convert.ToString(RoundedFats);
            double Pesaje = (double)inputPeso;
            MessageBox.Show("This Are Your Macros For A Day .....");
            MessageBox.Show("Protein: " + TotalProteina);
            MessageBox.Show("Carbs: " + TotalCarbs);
            MessageBox.Show("Fats:  " + RoundedFats);
            MessageBox.Show("Calories: " + Magiccalories);
            MessageBox.Show("Water: " + waterNeeded + " Gallon ");
        }
        public bool isWeightValid(string inputPeso)
        {
            int weight;
            try
            {
                weight = int.Parse(inputPeso);

            }
            catch (Exception e)
            {
                return false;
            }
            if (weight > 200)
            {
                MessageBox.Show("Sorry Bro Your Weight is not Human");
                return false;
            }
            return true;
        }

        private void TotalProtein_Click(object sender, EventArgs e)
        {
            double TotalProteina = Pesaje + 25;
        }

        public void TotalCarbs_Click(object sender, EventArgs e)
        {
            double TotalCarbs = TotalProteina + 92;
        }

        private void SaveIcon_Click(object sender, EventArgs e)
        {
            Workouts workout = new Workouts();
            workout.WorkoutName = inputWorkout.Text;
            workout.WorkoutSet = inputSet.Text;
            Split_List.Items.Add(workout);
        }

        private void DeleteICon_Click(object sender, EventArgs e)
        {
            int IndexSelected = Split_List.SelectedIndex;
            Split_List.Items.RemoveAt(IndexSelected);
        }


        public void tiempoRGB_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            Dev.ForeColor = Color.FromArgb(A, R, G, B);
            tiempoRGB.Start();
        }

        private void inputWorkout_TextChanged_1(object sender, EventArgs e)
        {
            inputWorkout.MaxLength = 20;

        }

        private void inputSet_TextChanged_1(object sender, EventArgs e)
        {
            inputSet.MaxLength = 10;

        }

        private void GainWeightInput_TextChanged_1(object sender, EventArgs e)
        {
            GainWeightInput.MaxLength = 3;
        }

        private void InputWeight_TextChanged_1(object sender, EventArgs e)
        {
            InputWeight.MaxLength = 3;
        }
        private void LinkToFinessAppIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://apps.apple.com/us/app/myfitnesspal/id341232718");
        }

        private void LinkToFinessAppIcon2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://apps.apple.com/us/app/myfitnesspal/id341232718");
        }


        private void CaloriesCalculate_Click(object sender, EventArgs e)
        {
            string bodyActivity = "";
            int gainWeight;
            gainWeight = Int32.Parse(GainWeightInput.Text);
            double bmr = gainWeight / 2.2046; // lbs to kg for bmr
            double lbsBMR = gainWeight * 15;
            double sedentary = bmr * 1.2;
            double moderate = bmr * 1.55;
            double active = bmr * 1.725;
            /*<-- everyweek you should try adding 100 to 200 more calories to be on a surplus 
                  The body is beutiful that it takes 1 week to adjust to change, 
                  those few weeks goin to be the hardest because you
                  forcing your stomach to spand STAY Hard Dont GIVE UP.      
                  This is only to gain weight not to build muscle! 
                  To build muscle you need to workout and make the muscle do so kind of resistance.
            -->*/
            double SurplusCaloriesSeden = lbsBMR + 300; 
            double surplusCaloriesLigh = lbsBMR + 500;
            double surplusCaloriesMode = lbsBMR + 700;
            double surplusCaloriesActi = lbsBMR + 1000;
            MaintainweightCaloriesOutput.Text = Convert.ToString(lbsBMR + " Calories");

            if (SendetaryIcon.Checked)
            {
                
               // double 1bmr = gainWeight / 2.2046 ; // lbs to kg for bmr
                
                GainweightCaloriesOutput.Text = Convert.ToString(SurplusCaloriesSeden + " Calories");
            }

            if (LightlyactiveIcon.Checked)
            {
                bodyActivity = LightlyactiveIcon.Text;
                double output = bmr;
                GainweightCaloriesOutput.Text = Convert.ToString(surplusCaloriesLigh + " Calories");
            }
            if (ModerateIcon.Checked)
            {
                bodyActivity = ModerateIcon.Text;
                GainweightCaloriesOutput.Text = Convert.ToString(surplusCaloriesMode + " Calories");
            }
            if (ActiveIcon.Checked)
            {
                bodyActivity = ActiveIcon.Text;
                GainweightCaloriesOutput.Text = Convert.ToString(surplusCaloriesActi + " Calories");
            }

        }
        public bool isGainWeightValid(string GainWeightInput)
        {
            int gainWeight;
            try
            {
                gainWeight = int.Parse(GainWeightInput);
            }
            catch (Exception e)
            {
                return false;
            }
            if (gainWeight > 200)
            {
                MessageBox.Show("Sorry Bro Your Weight is not Human");
                return false;
            }
            return true;
        }

      
    }
}

