using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void SubmitionIcon_Click(object sender, EventArgs e)
        {

            
            
            string inputPeso = InputWeight.Text;
            double Pesaje = double.Parse(inputPeso);   
            
            double TotalProteina = Pesaje + 25;
            double TotalCarbs = TotalProteina + 92;
            Proteinoutput.Text = Convert.ToString(TotalProteina);
            Carbsoutput.Text = Convert.ToString(TotalCarbs);
            Wateroutput.Text = "1 Gallon"; // notes paso mas importante more water to lose weight and detox,  Science is weird //
            Fatsoutput.Text = ""; //
           
            MessageBox.Show("This Are Your Macros For A Day .....");
            MessageBox.Show("Protein: " + TotalProteina);
            MessageBox.Show("Carbs: " + TotalCarbs);
            return;
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

        private void inputWorkout_TextChanged(object sender, EventArgs e)
        {
            inputWorkout.MaxLength = 20;

        }

        private void inputSet_TextChanged(object sender, EventArgs e)
        {
            inputSet.MaxLength = 10;

        }

        private void GainWeightInput_TextChanged(object sender, EventArgs e)
        {
            GainWeightInput.MaxLength = 3;
        }


        private void InputWeight_Validated(object sender, EventArgs e)
        {
           /*
             if(InputWeight.Text == "")
            {
                errorProvider1.SetError(InputWeight, " Weight Not inputed ");
                


            }
            else 
            {
                errorProvider1.Clear();
            }
            MessageBox.Show("Enter Correct Format ", "mistake", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
           */
        }

        private void InputWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
