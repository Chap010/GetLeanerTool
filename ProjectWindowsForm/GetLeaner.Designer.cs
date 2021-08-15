
namespace ProjectWindowsForm
{
    partial class GetLeanerWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SubmitionIcon = new System.Windows.Forms.Button();
            this.InputWeight = new System.Windows.Forms.TextBox();
            this.CurrentWeightIcon = new System.Windows.Forms.Label();
            this.ProteinIcon = new System.Windows.Forms.Label();
            this.FatsIcon = new System.Windows.Forms.Label();
            this.GetLeaner = new System.Windows.Forms.Label();
            this.CarbsIcon = new System.Windows.Forms.Label();
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.CuttingTab = new System.Windows.Forms.TabPage();
            this.LinkToFinessAppIcon = new System.Windows.Forms.LinkLabel();
            this.CaloriesICon = new System.Windows.Forms.Label();
            this.Paneloutput = new System.Windows.Forms.Panel();
            this.Wateroutput = new System.Windows.Forms.Label();
            this.CaloriesOutput = new System.Windows.Forms.Label();
            this.Fatsoutput = new System.Windows.Forms.Label();
            this.WaterIcon = new System.Windows.Forms.Label();
            this.Carbsoutput = new System.Windows.Forms.Label();
            this.Proteinoutput = new System.Windows.Forms.Label();
            this.SplitsTab = new System.Windows.Forms.TabPage();
            this.SetIcon = new System.Windows.Forms.Label();
            this.inputSet = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DeleteICon = new System.Windows.Forms.Button();
            this.SaveIcon = new System.Windows.Forms.Button();
            this.WorkoutsIcon = new System.Windows.Forms.Label();
            this.Split_List = new System.Windows.Forms.ListBox();
            this.inputWorkout = new System.Windows.Forms.TextBox();
            this.BulkingTab = new System.Windows.Forms.TabPage();
            this.LinkToFinessAppIcon2 = new System.Windows.Forms.LinkLabel();
            this.MaintainweightCaloriesOutput = new System.Windows.Forms.Label();
            this.MaintainWeightIcon = new System.Windows.Forms.Label();
            this.GainweightCaloriesOutput = new System.Windows.Forms.Label();
            this.GainWeinghtIcon = new System.Windows.Forms.Label();
            this.WhatsYourWeightIcon = new System.Windows.Forms.Label();
            this.GainWeightInput = new System.Windows.Forms.TextBox();
            this.CaloriesCalculate = new System.Windows.Forms.Button();
            this.WhatsYourActivityIcon = new System.Windows.Forms.Label();
            this.ActiveIcon = new System.Windows.Forms.RadioButton();
            this.LightlyactiveIcon = new System.Windows.Forms.RadioButton();
            this.ModerateIcon = new System.Windows.Forms.RadioButton();
            this.SendetaryIcon = new System.Windows.Forms.RadioButton();
            this.Splits = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MondayShowWorkout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LegsIcon = new System.Windows.Forms.Label();
            this.SundayIcon = new System.Windows.Forms.Label();
            this.SaturdayIcon = new System.Windows.Forms.Label();
            this.FridayIcon = new System.Windows.Forms.Label();
            this.ThursdayIcon = new System.Windows.Forms.Label();
            this.WednesdayIcon = new System.Windows.Forms.Label();
            this.TuesdayIcon = new System.Windows.Forms.Label();
            this.MondayIcon = new System.Windows.Forms.Label();
            this.Dev = new System.Windows.Forms.Label();
            this.tiempoRGB = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabsControl.SuspendLayout();
            this.CuttingTab.SuspendLayout();
            this.Paneloutput.SuspendLayout();
            this.SplitsTab.SuspendLayout();
            this.BulkingTab.SuspendLayout();
            this.Splits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitionIcon
            // 
            this.SubmitionIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SubmitionIcon.Location = new System.Drawing.Point(200, 190);
            this.SubmitionIcon.Name = "SubmitionIcon";
            this.SubmitionIcon.Size = new System.Drawing.Size(110, 32);
            this.SubmitionIcon.TabIndex = 0;
            this.SubmitionIcon.Text = "Calculate";
            this.SubmitionIcon.UseVisualStyleBackColor = true;
            this.SubmitionIcon.Click += new System.EventHandler(this.SubmitionIcon_Click);
            // 
            // InputWeight
            // 
            this.InputWeight.ForeColor = System.Drawing.Color.MidnightBlue;
            this.InputWeight.Location = new System.Drawing.Point(186, 161);
            this.InputWeight.Name = "InputWeight";
            this.InputWeight.Size = new System.Drawing.Size(131, 23);
            this.InputWeight.TabIndex = 1;
            this.InputWeight.Text = "lbs";
            this.InputWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InputWeight.TextChanged += new System.EventHandler(this.InputWeight_TextChanged_1);
            // 
            // CurrentWeightIcon
            // 
            this.CurrentWeightIcon.AutoSize = true;
            this.CurrentWeightIcon.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentWeightIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CurrentWeightIcon.Location = new System.Drawing.Point(168, 139);
            this.CurrentWeightIcon.Name = "CurrentWeightIcon";
            this.CurrentWeightIcon.Size = new System.Drawing.Size(174, 19);
            this.CurrentWeightIcon.TabIndex = 2;
            this.CurrentWeightIcon.Text = "Current Weight ";
            // 
            // ProteinIcon
            // 
            this.ProteinIcon.AutoSize = true;
            this.ProteinIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProteinIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProteinIcon.Location = new System.Drawing.Point(259, 84);
            this.ProteinIcon.Name = "ProteinIcon";
            this.ProteinIcon.Size = new System.Drawing.Size(51, 15);
            this.ProteinIcon.TabIndex = 3;
            this.ProteinIcon.Text = "Protein :";
            // 
            // FatsIcon
            // 
            this.FatsIcon.AutoSize = true;
            this.FatsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FatsIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FatsIcon.Location = new System.Drawing.Point(434, 84);
            this.FatsIcon.Name = "FatsIcon";
            this.FatsIcon.Size = new System.Drawing.Size(34, 15);
            this.FatsIcon.TabIndex = 4;
            this.FatsIcon.Text = "Fats :";
            // 
            // GetLeaner
            // 
            this.GetLeaner.AutoSize = true;
            this.GetLeaner.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetLeaner.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GetLeaner.Location = new System.Drawing.Point(82, 12);
            this.GetLeaner.Name = "GetLeaner";
            this.GetLeaner.Size = new System.Drawing.Size(341, 44);
            this.GetLeaner.TabIndex = 5;
            this.GetLeaner.Text = " Loose Fat  Get Leaner";
            // 
            // CarbsIcon
            // 
            this.CarbsIcon.AutoSize = true;
            this.CarbsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarbsIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CarbsIcon.Location = new System.Drawing.Point(352, 84);
            this.CarbsIcon.Name = "CarbsIcon";
            this.CarbsIcon.Size = new System.Drawing.Size(42, 15);
            this.CarbsIcon.TabIndex = 6;
            this.CarbsIcon.Text = "Carbs :";
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.CuttingTab);
            this.TabsControl.Controls.Add(this.SplitsTab);
            this.TabsControl.Controls.Add(this.BulkingTab);
            this.TabsControl.Controls.Add(this.Splits);
            this.TabsControl.Location = new System.Drawing.Point(13, 3);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(518, 297);
            this.TabsControl.TabIndex = 7;
            // 
            // CuttingTab
            // 
            this.CuttingTab.BackColor = System.Drawing.Color.GhostWhite;
            this.CuttingTab.Controls.Add(this.LinkToFinessAppIcon);
            this.CuttingTab.Controls.Add(this.CaloriesICon);
            this.CuttingTab.Controls.Add(this.Paneloutput);
            this.CuttingTab.Controls.Add(this.Wateroutput);
            this.CuttingTab.Controls.Add(this.CurrentWeightIcon);
            this.CuttingTab.Controls.Add(this.CaloriesOutput);
            this.CuttingTab.Controls.Add(this.InputWeight);
            this.CuttingTab.Controls.Add(this.Fatsoutput);
            this.CuttingTab.Controls.Add(this.ProteinIcon);
            this.CuttingTab.Controls.Add(this.SubmitionIcon);
            this.CuttingTab.Controls.Add(this.FatsIcon);
            this.CuttingTab.Controls.Add(this.WaterIcon);
            this.CuttingTab.Controls.Add(this.CarbsIcon);
            this.CuttingTab.Controls.Add(this.Carbsoutput);
            this.CuttingTab.Controls.Add(this.Proteinoutput);
            this.CuttingTab.ForeColor = System.Drawing.Color.Black;
            this.CuttingTab.Location = new System.Drawing.Point(4, 24);
            this.CuttingTab.Name = "CuttingTab";
            this.CuttingTab.Padding = new System.Windows.Forms.Padding(3);
            this.CuttingTab.Size = new System.Drawing.Size(510, 269);
            this.CuttingTab.TabIndex = 0;
            this.CuttingTab.Text = "Cutting Calculator";
            // 
            // LinkToFinessAppIcon
            // 
            this.LinkToFinessAppIcon.AutoSize = true;
            this.LinkToFinessAppIcon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LinkToFinessAppIcon.Location = new System.Drawing.Point(6, 252);
            this.LinkToFinessAppIcon.Name = "LinkToFinessAppIcon";
            this.LinkToFinessAppIcon.Size = new System.Drawing.Size(181, 14);
            this.LinkToFinessAppIcon.TabIndex = 17;
            this.LinkToFinessAppIcon.TabStop = true;
            this.LinkToFinessAppIcon.Text = "Need Help Tracking Your Calories?";
            this.LinkToFinessAppIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToFinessAppIcon_LinkClicked);
            // 
            // CaloriesICon
            // 
            this.CaloriesICon.AutoSize = true;
            this.CaloriesICon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaloriesICon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CaloriesICon.Location = new System.Drawing.Point(167, 84);
            this.CaloriesICon.Name = "CaloriesICon";
            this.CaloriesICon.Size = new System.Drawing.Size(54, 15);
            this.CaloriesICon.TabIndex = 12;
            this.CaloriesICon.Text = "Calories :";
            // 
            // Paneloutput
            // 
            this.Paneloutput.BackColor = System.Drawing.Color.GhostWhite;
            this.Paneloutput.Controls.Add(this.GetLeaner);
            this.Paneloutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.Paneloutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.Paneloutput.ForeColor = System.Drawing.Color.Black;
            this.Paneloutput.Location = new System.Drawing.Point(3, 3);
            this.Paneloutput.Name = "Paneloutput";
            this.Paneloutput.Size = new System.Drawing.Size(504, 70);
            this.Paneloutput.TabIndex = 14;
            // 
            // Wateroutput
            // 
            this.Wateroutput.AutoSize = true;
            this.Wateroutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Wateroutput.ForeColor = System.Drawing.Color.Red;
            this.Wateroutput.Location = new System.Drawing.Point(72, 108);
            this.Wateroutput.Name = "Wateroutput";
            this.Wateroutput.Size = new System.Drawing.Size(12, 15);
            this.Wateroutput.TabIndex = 11;
            this.Wateroutput.Text = "?";
            // 
            // CaloriesOutput
            // 
            this.CaloriesOutput.AutoSize = true;
            this.CaloriesOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CaloriesOutput.ForeColor = System.Drawing.Color.Red;
            this.CaloriesOutput.Location = new System.Drawing.Point(186, 108);
            this.CaloriesOutput.Name = "CaloriesOutput";
            this.CaloriesOutput.Size = new System.Drawing.Size(12, 15);
            this.CaloriesOutput.TabIndex = 13;
            this.CaloriesOutput.Text = "?";
            // 
            // Fatsoutput
            // 
            this.Fatsoutput.AutoSize = true;
            this.Fatsoutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Fatsoutput.ForeColor = System.Drawing.Color.Red;
            this.Fatsoutput.Location = new System.Drawing.Point(443, 108);
            this.Fatsoutput.Name = "Fatsoutput";
            this.Fatsoutput.Size = new System.Drawing.Size(12, 15);
            this.Fatsoutput.TabIndex = 7;
            this.Fatsoutput.Text = "?";
            // 
            // WaterIcon
            // 
            this.WaterIcon.AutoSize = true;
            this.WaterIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WaterIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WaterIcon.Location = new System.Drawing.Point(38, 84);
            this.WaterIcon.Name = "WaterIcon";
            this.WaterIcon.Size = new System.Drawing.Size(89, 15);
            this.WaterIcon.TabIndex = 10;
            this.WaterIcon.Text = "Water Needed :";
            // 
            // Carbsoutput
            // 
            this.Carbsoutput.AutoSize = true;
            this.Carbsoutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Carbsoutput.ForeColor = System.Drawing.Color.Red;
            this.Carbsoutput.Location = new System.Drawing.Point(366, 108);
            this.Carbsoutput.Name = "Carbsoutput";
            this.Carbsoutput.Size = new System.Drawing.Size(12, 15);
            this.Carbsoutput.TabIndex = 9;
            this.Carbsoutput.Text = "?";
            // 
            // Proteinoutput
            // 
            this.Proteinoutput.AutoSize = true;
            this.Proteinoutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Proteinoutput.ForeColor = System.Drawing.Color.Red;
            this.Proteinoutput.Location = new System.Drawing.Point(277, 108);
            this.Proteinoutput.Name = "Proteinoutput";
            this.Proteinoutput.Size = new System.Drawing.Size(12, 15);
            this.Proteinoutput.TabIndex = 8;
            this.Proteinoutput.Text = "?";
            // 
            // SplitsTab
            // 
            this.SplitsTab.Controls.Add(this.SetIcon);
            this.SplitsTab.Controls.Add(this.inputSet);
            this.SplitsTab.Controls.Add(this.dateTimePicker1);
            this.SplitsTab.Controls.Add(this.DeleteICon);
            this.SplitsTab.Controls.Add(this.SaveIcon);
            this.SplitsTab.Controls.Add(this.WorkoutsIcon);
            this.SplitsTab.Controls.Add(this.Split_List);
            this.SplitsTab.Controls.Add(this.inputWorkout);
            this.SplitsTab.Location = new System.Drawing.Point(4, 24);
            this.SplitsTab.Name = "SplitsTab";
            this.SplitsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SplitsTab.Size = new System.Drawing.Size(510, 269);
            this.SplitsTab.TabIndex = 1;
            this.SplitsTab.Text = " Workouts";
            this.SplitsTab.UseVisualStyleBackColor = true;
            // 
            // SetIcon
            // 
            this.SetIcon.AutoSize = true;
            this.SetIcon.Location = new System.Drawing.Point(331, 92);
            this.SetIcon.Name = "SetIcon";
            this.SetIcon.Size = new System.Drawing.Size(34, 15);
            this.SetIcon.TabIndex = 7;
            this.SetIcon.Text = "Sets :";
            // 
            // inputSet
            // 
            this.inputSet.Location = new System.Drawing.Point(372, 84);
            this.inputSet.Name = "inputSet";
            this.inputSet.Size = new System.Drawing.Size(100, 23);
            this.inputSet.TabIndex = 6;
            this.inputSet.Text = "10x5";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // DeleteICon
            // 
            this.DeleteICon.Location = new System.Drawing.Point(113, 240);
            this.DeleteICon.Name = "DeleteICon";
            this.DeleteICon.Size = new System.Drawing.Size(75, 23);
            this.DeleteICon.TabIndex = 4;
            this.DeleteICon.Text = "Delete";
            this.DeleteICon.UseVisualStyleBackColor = true;
            // 
            // SaveIcon
            // 
            this.SaveIcon.Location = new System.Drawing.Point(387, 110);
            this.SaveIcon.Name = "SaveIcon";
            this.SaveIcon.Size = new System.Drawing.Size(75, 23);
            this.SaveIcon.TabIndex = 3;
            this.SaveIcon.Text = "Save";
            this.SaveIcon.UseVisualStyleBackColor = true;
            // 
            // WorkoutsIcon
            // 
            this.WorkoutsIcon.AutoSize = true;
            this.WorkoutsIcon.Location = new System.Drawing.Point(272, 63);
            this.WorkoutsIcon.Name = "WorkoutsIcon";
            this.WorkoutsIcon.Size = new System.Drawing.Size(94, 15);
            this.WorkoutsIcon.TabIndex = 2;
            this.WorkoutsIcon.Text = "Workout Name :";
            // 
            // Split_List
            // 
            this.Split_List.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Split_List.FormattingEnabled = true;
            this.Split_List.ItemHeight = 15;
            this.Split_List.Location = new System.Drawing.Point(43, 8);
            this.Split_List.Name = "Split_List";
            this.Split_List.Size = new System.Drawing.Size(216, 229);
            this.Split_List.TabIndex = 1;
            // 
            // inputWorkout
            // 
            this.inputWorkout.Location = new System.Drawing.Point(372, 55);
            this.inputWorkout.Name = "inputWorkout";
            this.inputWorkout.Size = new System.Drawing.Size(100, 23);
            this.inputWorkout.TabIndex = 0;
            this.inputWorkout.Text = "Legs";
            this.inputWorkout.TextChanged += new System.EventHandler(this.inputWorkout_TextChanged_1);
            // 
            // BulkingTab
            // 
            this.BulkingTab.BackColor = System.Drawing.Color.GhostWhite;
            this.BulkingTab.Controls.Add(this.LinkToFinessAppIcon2);
            this.BulkingTab.Controls.Add(this.MaintainweightCaloriesOutput);
            this.BulkingTab.Controls.Add(this.MaintainWeightIcon);
            this.BulkingTab.Controls.Add(this.GainweightCaloriesOutput);
            this.BulkingTab.Controls.Add(this.GainWeinghtIcon);
            this.BulkingTab.Controls.Add(this.WhatsYourWeightIcon);
            this.BulkingTab.Controls.Add(this.GainWeightInput);
            this.BulkingTab.Controls.Add(this.CaloriesCalculate);
            this.BulkingTab.Controls.Add(this.WhatsYourActivityIcon);
            this.BulkingTab.Controls.Add(this.ActiveIcon);
            this.BulkingTab.Controls.Add(this.LightlyactiveIcon);
            this.BulkingTab.Controls.Add(this.ModerateIcon);
            this.BulkingTab.Controls.Add(this.SendetaryIcon);
            this.BulkingTab.Location = new System.Drawing.Point(4, 24);
            this.BulkingTab.Name = "BulkingTab";
            this.BulkingTab.Padding = new System.Windows.Forms.Padding(3);
            this.BulkingTab.Size = new System.Drawing.Size(510, 269);
            this.BulkingTab.TabIndex = 2;
            this.BulkingTab.Text = "Gain Weight";
            // 
            // LinkToFinessAppIcon2
            // 
            this.LinkToFinessAppIcon2.AutoSize = true;
            this.LinkToFinessAppIcon2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LinkToFinessAppIcon2.Location = new System.Drawing.Point(6, 251);
            this.LinkToFinessAppIcon2.Name = "LinkToFinessAppIcon2";
            this.LinkToFinessAppIcon2.Size = new System.Drawing.Size(181, 14);
            this.LinkToFinessAppIcon2.TabIndex = 18;
            this.LinkToFinessAppIcon2.TabStop = true;
            this.LinkToFinessAppIcon2.Text = "Need Help Tracking Your Calories?";
            this.LinkToFinessAppIcon2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToFinessAppIcon2_LinkClicked);
            // 
            // MaintainweightCaloriesOutput
            // 
            this.MaintainweightCaloriesOutput.AutoSize = true;
            this.MaintainweightCaloriesOutput.ForeColor = System.Drawing.Color.Red;
            this.MaintainweightCaloriesOutput.Location = new System.Drawing.Point(396, 87);
            this.MaintainweightCaloriesOutput.Name = "MaintainweightCaloriesOutput";
            this.MaintainweightCaloriesOutput.Size = new System.Drawing.Size(12, 15);
            this.MaintainweightCaloriesOutput.TabIndex = 13;
            this.MaintainweightCaloriesOutput.Text = "?";
            // 
            // MaintainWeightIcon
            // 
            this.MaintainWeightIcon.AutoSize = true;
            this.MaintainWeightIcon.Location = new System.Drawing.Point(296, 87);
            this.MaintainWeightIcon.Name = "MaintainWeightIcon";
            this.MaintainWeightIcon.Size = new System.Drawing.Size(101, 15);
            this.MaintainWeightIcon.TabIndex = 12;
            this.MaintainWeightIcon.Text = "Maintain Weight :";
            // 
            // GainweightCaloriesOutput
            // 
            this.GainweightCaloriesOutput.AutoSize = true;
            this.GainweightCaloriesOutput.ForeColor = System.Drawing.Color.Red;
            this.GainweightCaloriesOutput.Location = new System.Drawing.Point(378, 63);
            this.GainweightCaloriesOutput.Name = "GainweightCaloriesOutput";
            this.GainweightCaloriesOutput.Size = new System.Drawing.Size(12, 15);
            this.GainweightCaloriesOutput.TabIndex = 11;
            this.GainweightCaloriesOutput.Text = "?";
            // 
            // GainWeinghtIcon
            // 
            this.GainWeinghtIcon.AutoSize = true;
            this.GainWeinghtIcon.Location = new System.Drawing.Point(296, 63);
            this.GainWeinghtIcon.Name = "GainWeinghtIcon";
            this.GainWeinghtIcon.Size = new System.Drawing.Size(78, 15);
            this.GainWeinghtIcon.TabIndex = 10;
            this.GainWeinghtIcon.Text = "Gain Weight :";
            // 
            // WhatsYourWeightIcon
            // 
            this.WhatsYourWeightIcon.AutoSize = true;
            this.WhatsYourWeightIcon.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WhatsYourWeightIcon.Location = new System.Drawing.Point(296, 29);
            this.WhatsYourWeightIcon.Name = "WhatsYourWeightIcon";
            this.WhatsYourWeightIcon.Size = new System.Drawing.Size(152, 18);
            this.WhatsYourWeightIcon.TabIndex = 9;
            this.WhatsYourWeightIcon.Text = "Whats Your Weight?";
            // 
            // GainWeightInput
            // 
            this.GainWeightInput.Location = new System.Drawing.Point(325, 118);
            this.GainWeightInput.Name = "GainWeightInput";
            this.GainWeightInput.Size = new System.Drawing.Size(103, 23);
            this.GainWeightInput.TabIndex = 7;
            this.GainWeightInput.Text = "lbs";
            this.GainWeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CaloriesCalculate
            // 
            this.CaloriesCalculate.Location = new System.Drawing.Point(313, 147);
            this.CaloriesCalculate.Name = "CaloriesCalculate";
            this.CaloriesCalculate.Size = new System.Drawing.Size(127, 32);
            this.CaloriesCalculate.TabIndex = 6;
            this.CaloriesCalculate.Text = "Calculate";
            this.CaloriesCalculate.UseVisualStyleBackColor = true;
            this.CaloriesCalculate.Click += new System.EventHandler(this.CaloriesCalculate_Click);
            // 
            // WhatsYourActivityIcon
            // 
            this.WhatsYourActivityIcon.AutoSize = true;
            this.WhatsYourActivityIcon.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WhatsYourActivityIcon.Location = new System.Drawing.Point(20, 29);
            this.WhatsYourActivityIcon.Name = "WhatsYourActivityIcon";
            this.WhatsYourActivityIcon.Size = new System.Drawing.Size(156, 18);
            this.WhatsYourActivityIcon.TabIndex = 5;
            this.WhatsYourActivityIcon.Text = "Whats Your Activity?";
            // 
            // ActiveIcon
            // 
            this.ActiveIcon.AutoSize = true;
            this.ActiveIcon.Location = new System.Drawing.Point(53, 135);
            this.ActiveIcon.Name = "ActiveIcon";
            this.ActiveIcon.Size = new System.Drawing.Size(58, 19);
            this.ActiveIcon.TabIndex = 3;
            this.ActiveIcon.Text = "Active";
            this.ActiveIcon.UseVisualStyleBackColor = true;
            // 
            // LightlyactiveIcon
            // 
            this.LightlyactiveIcon.AutoSize = true;
            this.LightlyactiveIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LightlyactiveIcon.Location = new System.Drawing.Point(53, 85);
            this.LightlyactiveIcon.Name = "LightlyactiveIcon";
            this.LightlyactiveIcon.Size = new System.Drawing.Size(97, 19);
            this.LightlyactiveIcon.TabIndex = 2;
            this.LightlyactiveIcon.Text = "Lightly Active";
            this.LightlyactiveIcon.UseVisualStyleBackColor = true;
            // 
            // ModerateIcon
            // 
            this.ModerateIcon.AutoSize = true;
            this.ModerateIcon.Location = new System.Drawing.Point(54, 110);
            this.ModerateIcon.Name = "ModerateIcon";
            this.ModerateIcon.Size = new System.Drawing.Size(76, 19);
            this.ModerateIcon.TabIndex = 1;
            this.ModerateIcon.Text = "Moderate";
            this.ModerateIcon.UseVisualStyleBackColor = true;
            // 
            // SendetaryIcon
            // 
            this.SendetaryIcon.AutoSize = true;
            this.SendetaryIcon.Checked = true;
            this.SendetaryIcon.Location = new System.Drawing.Point(53, 60);
            this.SendetaryIcon.Name = "SendetaryIcon";
            this.SendetaryIcon.Size = new System.Drawing.Size(77, 19);
            this.SendetaryIcon.TabIndex = 0;
            this.SendetaryIcon.TabStop = true;
            this.SendetaryIcon.Text = "Sedentary";
            this.SendetaryIcon.UseVisualStyleBackColor = true;
            // 
            // Splits
            // 
            this.Splits.BackColor = System.Drawing.Color.GhostWhite;
            this.Splits.Controls.Add(this.button7);
            this.Splits.Controls.Add(this.button6);
            this.Splits.Controls.Add(this.button5);
            this.Splits.Controls.Add(this.button3);
            this.Splits.Controls.Add(this.button2);
            this.Splits.Controls.Add(this.MondayShowWorkout);
            this.Splits.Controls.Add(this.label6);
            this.Splits.Controls.Add(this.label5);
            this.Splits.Controls.Add(this.label4);
            this.Splits.Controls.Add(this.label3);
            this.Splits.Controls.Add(this.label2);
            this.Splits.Controls.Add(this.label1);
            this.Splits.Controls.Add(this.LegsIcon);
            this.Splits.Controls.Add(this.SundayIcon);
            this.Splits.Controls.Add(this.SaturdayIcon);
            this.Splits.Controls.Add(this.FridayIcon);
            this.Splits.Controls.Add(this.ThursdayIcon);
            this.Splits.Controls.Add(this.WednesdayIcon);
            this.Splits.Controls.Add(this.TuesdayIcon);
            this.Splits.Controls.Add(this.MondayIcon);
            this.Splits.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Splits.Location = new System.Drawing.Point(4, 24);
            this.Splits.Name = "Splits";
            this.Splits.Padding = new System.Windows.Forms.Padding(3);
            this.Splits.Size = new System.Drawing.Size(510, 269);
            this.Splits.TabIndex = 3;
            this.Splits.Text = "Splits";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button7.Location = new System.Drawing.Point(292, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Show";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.Location = new System.Drawing.Point(161, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Show";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(26, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(292, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(160, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MondayShowWorkout
            // 
            this.MondayShowWorkout.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MondayShowWorkout.Location = new System.Drawing.Point(26, 103);
            this.MondayShowWorkout.Name = "MondayShowWorkout";
            this.MondayShowWorkout.Size = new System.Drawing.Size(75, 23);
            this.MondayShowWorkout.TabIndex = 14;
            this.MondayShowWorkout.Text = "Show";
            this.MondayShowWorkout.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(425, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(277, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chest/Abs or Restday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(314, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(155, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Back/Shoulders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(167, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chest/Abs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(50, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arms";
            // 
            // LegsIcon
            // 
            this.LegsIcon.AutoSize = true;
            this.LegsIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LegsIcon.Location = new System.Drawing.Point(32, 67);
            this.LegsIcon.Name = "LegsIcon";
            this.LegsIcon.Size = new System.Drawing.Size(71, 15);
            this.LegsIcon.TabIndex = 7;
            this.LegsIcon.Text = "Legs/Cardio";
            // 
            // SundayIcon
            // 
            this.SundayIcon.AutoSize = true;
            this.SundayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SundayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SundayIcon.Location = new System.Drawing.Point(414, 31);
            this.SundayIcon.Name = "SundayIcon";
            this.SundayIcon.Size = new System.Drawing.Size(56, 21);
            this.SundayIcon.TabIndex = 6;
            this.SundayIcon.Text = "Sunday";
            // 
            // SaturdayIcon
            // 
            this.SaturdayIcon.AutoSize = true;
            this.SaturdayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SaturdayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SaturdayIcon.Location = new System.Drawing.Point(301, 148);
            this.SaturdayIcon.Name = "SaturdayIcon";
            this.SaturdayIcon.Size = new System.Drawing.Size(66, 21);
            this.SaturdayIcon.TabIndex = 5;
            this.SaturdayIcon.Text = "Saturday";
            // 
            // FridayIcon
            // 
            this.FridayIcon.AutoSize = true;
            this.FridayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.FridayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FridayIcon.Location = new System.Drawing.Point(309, 31);
            this.FridayIcon.Name = "FridayIcon";
            this.FridayIcon.Size = new System.Drawing.Size(50, 21);
            this.FridayIcon.TabIndex = 4;
            this.FridayIcon.Text = "Friday";
            // 
            // ThursdayIcon
            // 
            this.ThursdayIcon.AutoSize = true;
            this.ThursdayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ThursdayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ThursdayIcon.Location = new System.Drawing.Point(167, 148);
            this.ThursdayIcon.Name = "ThursdayIcon";
            this.ThursdayIcon.Size = new System.Drawing.Size(69, 21);
            this.ThursdayIcon.TabIndex = 3;
            this.ThursdayIcon.Text = "Thursday";
            // 
            // WednesdayIcon
            // 
            this.WednesdayIcon.AutoSize = true;
            this.WednesdayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.WednesdayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WednesdayIcon.Location = new System.Drawing.Point(160, 31);
            this.WednesdayIcon.Name = "WednesdayIcon";
            this.WednesdayIcon.Size = new System.Drawing.Size(80, 21);
            this.WednesdayIcon.TabIndex = 2;
            this.WednesdayIcon.Text = "Wednesday";
            // 
            // TuesdayIcon
            // 
            this.TuesdayIcon.AutoSize = true;
            this.TuesdayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TuesdayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TuesdayIcon.Location = new System.Drawing.Point(39, 148);
            this.TuesdayIcon.Name = "TuesdayIcon";
            this.TuesdayIcon.Size = new System.Drawing.Size(62, 21);
            this.TuesdayIcon.TabIndex = 1;
            this.TuesdayIcon.Text = "Tuesday";
            // 
            // MondayIcon
            // 
            this.MondayIcon.AutoSize = true;
            this.MondayIcon.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.MondayIcon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MondayIcon.Location = new System.Drawing.Point(41, 31);
            this.MondayIcon.Name = "MondayIcon";
            this.MondayIcon.Size = new System.Drawing.Size(60, 21);
            this.MondayIcon.TabIndex = 0;
            this.MondayIcon.Text = "Monday";
            // 
            // Dev
            // 
            this.Dev.AutoSize = true;
            this.Dev.BackColor = System.Drawing.Color.GhostWhite;
            this.Dev.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dev.Location = new System.Drawing.Point(451, 304);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(60, 20);
            this.Dev.TabIndex = 8;
            this.Dev.Text = "Greaser";
            // 
            // tiempoRGB
            // 
            this.tiempoRGB.Enabled = true;
            this.tiempoRGB.Tick += new System.EventHandler(this.tiempoRGB_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GetLeanerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(544, 327);
            this.Controls.Add(this.Dev);
            this.Controls.Add(this.TabsControl);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetLeanerWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Leaner Demo";
            this.TabsControl.ResumeLayout(false);
            this.CuttingTab.ResumeLayout(false);
            this.CuttingTab.PerformLayout();
            this.Paneloutput.ResumeLayout(false);
            this.Paneloutput.PerformLayout();
            this.SplitsTab.ResumeLayout(false);
            this.SplitsTab.PerformLayout();
            this.BulkingTab.ResumeLayout(false);
            this.BulkingTab.PerformLayout();
            this.Splits.ResumeLayout(false);
            this.Splits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitionIcon;
        private System.Windows.Forms.TextBox InputWeight;
        private System.Windows.Forms.Label CurrentWeightIcon;
        private System.Windows.Forms.Label ProteinIcon;
        private System.Windows.Forms.Label FatsIcon;
        private System.Windows.Forms.Label GetLeaner;
        private System.Windows.Forms.Label CarbsIcon;
        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage CuttingTab;
        private System.Windows.Forms.TabPage SplitsTab;
        private System.Windows.Forms.Button SaveIcon;
        private System.Windows.Forms.Label WorkoutsIcon;
        private System.Windows.Forms.ListBox Split_List;
        private System.Windows.Forms.TextBox inputWorkout;
        private System.Windows.Forms.Button DeleteICon;
        private System.Windows.Forms.TabPage BulkingTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label SetIcon;
        private System.Windows.Forms.TextBox inputSet;
        private System.Windows.Forms.TabPage Splits;
        private System.Windows.Forms.Label Carbsoutput;
        private System.Windows.Forms.Label Proteinoutput;
        private System.Windows.Forms.Label Fatsoutput;
        private System.Windows.Forms.Label Dev;
        private System.Windows.Forms.Timer tiempoRGB;
        private System.Windows.Forms.Label MaintainweightCaloriesOutput;
        private System.Windows.Forms.Label MaintainWeightIcon;
        private System.Windows.Forms.Label GainweightCaloriesOutput;
        private System.Windows.Forms.Label GainWeinghtIcon;
        private System.Windows.Forms.Label WhatsYourWeightIcon;
        private System.Windows.Forms.TextBox GainWeightInput;
        private System.Windows.Forms.Button CaloriesCalculate;
        private System.Windows.Forms.Label WhatsYourActivityIcon;
        private System.Windows.Forms.RadioButton ActiveIcon;
        private System.Windows.Forms.RadioButton LightlyactiveIcon;
        private System.Windows.Forms.RadioButton ModerateIcon;
        private System.Windows.Forms.RadioButton SendetaryIcon;
        private System.Windows.Forms.Label Wateroutput;
        private System.Windows.Forms.Label WaterIcon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label CaloriesOutput;
        private System.Windows.Forms.Label CaloriesICon;
        private System.Windows.Forms.Panel Paneloutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LegsIcon;
        private System.Windows.Forms.Label SundayIcon;
        private System.Windows.Forms.Label SaturdayIcon;
        private System.Windows.Forms.Label FridayIcon;
        private System.Windows.Forms.Label ThursdayIcon;
        private System.Windows.Forms.Label WednesdayIcon;
        private System.Windows.Forms.Label TuesdayIcon;
        private System.Windows.Forms.Label MondayIcon;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MondayShowWorkout;
        private System.Windows.Forms.LinkLabel LinkToFinessAppIcon;
        private System.Windows.Forms.LinkLabel LinkToFinessAppIcon2;
    }
}

