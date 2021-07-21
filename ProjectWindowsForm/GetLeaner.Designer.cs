
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
            this.Wateroutput = new System.Windows.Forms.Label();
            this.WaterIcon = new System.Windows.Forms.Label();
            this.Carbsoutput = new System.Windows.Forms.Label();
            this.Proteinoutput = new System.Windows.Forms.Label();
            this.Fatsoutput = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.MaintainWeightIcon = new System.Windows.Forms.Label();
            this.CaloriesInput = new System.Windows.Forms.Label();
            this.GainWeinghtIcon = new System.Windows.Forms.Label();
            this.WhatsYourWeightIcon = new System.Windows.Forms.Label();
            this.GainWeightInput = new System.Windows.Forms.TextBox();
            this.CaloriesCalculate = new System.Windows.Forms.Button();
            this.WhatsYourActivityIcon = new System.Windows.Forms.Label();
            this.VeryActiveIcon = new System.Windows.Forms.RadioButton();
            this.ActiveIcon = new System.Windows.Forms.RadioButton();
            this.LightlyactiveIcon = new System.Windows.Forms.RadioButton();
            this.ModerateIcon = new System.Windows.Forms.RadioButton();
            this.SendetaryIcon = new System.Windows.Forms.RadioButton();
            this.Splits = new System.Windows.Forms.TabPage();
            this.Dev = new System.Windows.Forms.Label();
            this.tiempoRGB = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabsControl.SuspendLayout();
            this.CuttingTab.SuspendLayout();
            this.SplitsTab.SuspendLayout();
            this.BulkingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitionIcon
            // 
            this.SubmitionIcon.Location = new System.Drawing.Point(189, 185);
            this.SubmitionIcon.Name = "SubmitionIcon";
            this.SubmitionIcon.Size = new System.Drawing.Size(110, 32);
            this.SubmitionIcon.TabIndex = 0;
            this.SubmitionIcon.Text = "Calculate";
            this.SubmitionIcon.UseVisualStyleBackColor = true;
            this.SubmitionIcon.Click += new System.EventHandler(this.SubmitionIcon_Click);
            // 
            // InputWeight
            // 
            this.InputWeight.Location = new System.Drawing.Point(177, 156);
            this.InputWeight.Name = "InputWeight";
            this.InputWeight.Size = new System.Drawing.Size(131, 23);
            this.InputWeight.TabIndex = 1;
            this.InputWeight.TextChanged += new System.EventHandler(this.InputWeight_TextChanged);
            this.InputWeight.Validated += new System.EventHandler(this.InputWeight_Validated);
            // 
            // CurrentWeightIcon
            // 
            this.CurrentWeightIcon.AutoSize = true;
            this.CurrentWeightIcon.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentWeightIcon.Location = new System.Drawing.Point(126, 128);
            this.CurrentWeightIcon.Name = "CurrentWeightIcon";
            this.CurrentWeightIcon.Size = new System.Drawing.Size(240, 19);
            this.CurrentWeightIcon.TabIndex = 2;
            this.CurrentWeightIcon.Text = "Current Weight In Lbs";
            // 
            // ProteinIcon
            // 
            this.ProteinIcon.AutoSize = true;
            this.ProteinIcon.Location = new System.Drawing.Point(140, 81);
            this.ProteinIcon.Name = "ProteinIcon";
            this.ProteinIcon.Size = new System.Drawing.Size(51, 15);
            this.ProteinIcon.TabIndex = 3;
            this.ProteinIcon.Text = "Protein :";
            this.ProteinIcon.Click += new System.EventHandler(this.TotalProtein_Click);
            // 
            // FatsIcon
            // 
            this.FatsIcon.AutoSize = true;
            this.FatsIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FatsIcon.Location = new System.Drawing.Point(51, 80);
            this.FatsIcon.Name = "FatsIcon";
            this.FatsIcon.Size = new System.Drawing.Size(34, 15);
            this.FatsIcon.TabIndex = 4;
            this.FatsIcon.Text = "Fats :";
            // 
            // GetLeaner
            // 
            this.GetLeaner.AutoSize = true;
            this.GetLeaner.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetLeaner.Location = new System.Drawing.Point(77, 14);
            this.GetLeaner.Name = "GetLeaner";
            this.GetLeaner.Size = new System.Drawing.Size(341, 44);
            this.GetLeaner.TabIndex = 5;
            this.GetLeaner.Text = " Loose Fat  Get Leaner";
            // 
            // CarbsIcon
            // 
            this.CarbsIcon.AutoSize = true;
            this.CarbsIcon.Location = new System.Drawing.Point(249, 82);
            this.CarbsIcon.Name = "CarbsIcon";
            this.CarbsIcon.Size = new System.Drawing.Size(43, 15);
            this.CarbsIcon.TabIndex = 6;
            this.CarbsIcon.Text = "Carbs :";
            this.CarbsIcon.Click += new System.EventHandler(this.TotalCarbs_Click);
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
            this.CuttingTab.Controls.Add(this.Wateroutput);
            this.CuttingTab.Controls.Add(this.WaterIcon);
            this.CuttingTab.Controls.Add(this.Carbsoutput);
            this.CuttingTab.Controls.Add(this.Proteinoutput);
            this.CuttingTab.Controls.Add(this.Fatsoutput);
            this.CuttingTab.Controls.Add(this.CurrentWeightIcon);
            this.CuttingTab.Controls.Add(this.FatsIcon);
            this.CuttingTab.Controls.Add(this.CarbsIcon);
            this.CuttingTab.Controls.Add(this.InputWeight);
            this.CuttingTab.Controls.Add(this.GetLeaner);
            this.CuttingTab.Controls.Add(this.ProteinIcon);
            this.CuttingTab.Controls.Add(this.SubmitionIcon);
            this.CuttingTab.Location = new System.Drawing.Point(4, 24);
            this.CuttingTab.Name = "CuttingTab";
            this.CuttingTab.Padding = new System.Windows.Forms.Padding(3);
            this.CuttingTab.Size = new System.Drawing.Size(510, 269);
            this.CuttingTab.TabIndex = 0;
            this.CuttingTab.Text = "Cutting Calculator";
            this.CuttingTab.UseVisualStyleBackColor = true;
            // 
            // Wateroutput
            // 
            this.Wateroutput.AutoSize = true;
            this.Wateroutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Wateroutput.ForeColor = System.Drawing.Color.Red;
            this.Wateroutput.Location = new System.Drawing.Point(433, 85);
            this.Wateroutput.Name = "Wateroutput";
            this.Wateroutput.Size = new System.Drawing.Size(12, 15);
            this.Wateroutput.TabIndex = 11;
            this.Wateroutput.Text = "?";
            // 
            // WaterIcon
            // 
            this.WaterIcon.AutoSize = true;
            this.WaterIcon.Location = new System.Drawing.Point(339, 84);
            this.WaterIcon.Name = "WaterIcon";
            this.WaterIcon.Size = new System.Drawing.Size(88, 15);
            this.WaterIcon.TabIndex = 10;
            this.WaterIcon.Text = "Water Needed :";
            // 
            // Carbsoutput
            // 
            this.Carbsoutput.AutoSize = true;
            this.Carbsoutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Carbsoutput.ForeColor = System.Drawing.Color.Red;
            this.Carbsoutput.Location = new System.Drawing.Point(295, 83);
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
            this.Proteinoutput.Location = new System.Drawing.Point(193, 82);
            this.Proteinoutput.Name = "Proteinoutput";
            this.Proteinoutput.Size = new System.Drawing.Size(12, 15);
            this.Proteinoutput.TabIndex = 8;
            this.Proteinoutput.Text = "?";
            // 
            // Fatsoutput
            // 
            this.Fatsoutput.AutoSize = true;
            this.Fatsoutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Fatsoutput.ForeColor = System.Drawing.Color.Red;
            this.Fatsoutput.Location = new System.Drawing.Point(89, 81);
            this.Fatsoutput.Name = "Fatsoutput";
            this.Fatsoutput.Size = new System.Drawing.Size(12, 15);
            this.Fatsoutput.TabIndex = 7;
            this.Fatsoutput.Text = "?";
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
            this.inputSet.TextChanged += new System.EventHandler(this.inputSet_TextChanged);
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
            this.DeleteICon.Click += new System.EventHandler(this.DeleteICon_Click);
            // 
            // SaveIcon
            // 
            this.SaveIcon.Location = new System.Drawing.Point(387, 110);
            this.SaveIcon.Name = "SaveIcon";
            this.SaveIcon.Size = new System.Drawing.Size(75, 23);
            this.SaveIcon.TabIndex = 3;
            this.SaveIcon.Text = "Save";
            this.SaveIcon.UseVisualStyleBackColor = true;
            this.SaveIcon.Click += new System.EventHandler(this.SaveIcon_Click);
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
            this.inputWorkout.TextChanged += new System.EventHandler(this.inputWorkout_TextChanged);
            // 
            // BulkingTab
            // 
            this.BulkingTab.Controls.Add(this.label2);
            this.BulkingTab.Controls.Add(this.MaintainWeightIcon);
            this.BulkingTab.Controls.Add(this.CaloriesInput);
            this.BulkingTab.Controls.Add(this.GainWeinghtIcon);
            this.BulkingTab.Controls.Add(this.WhatsYourWeightIcon);
            this.BulkingTab.Controls.Add(this.GainWeightInput);
            this.BulkingTab.Controls.Add(this.CaloriesCalculate);
            this.BulkingTab.Controls.Add(this.WhatsYourActivityIcon);
            this.BulkingTab.Controls.Add(this.VeryActiveIcon);
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
            this.BulkingTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(396, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "?";
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
            // CaloriesInput
            // 
            this.CaloriesInput.AutoSize = true;
            this.CaloriesInput.ForeColor = System.Drawing.Color.Red;
            this.CaloriesInput.Location = new System.Drawing.Point(378, 63);
            this.CaloriesInput.Name = "CaloriesInput";
            this.CaloriesInput.Size = new System.Drawing.Size(12, 15);
            this.CaloriesInput.TabIndex = 11;
            this.CaloriesInput.Text = "?";
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
            this.GainWeightInput.Text = "Weight LBS";
            this.GainWeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GainWeightInput.TextChanged += new System.EventHandler(this.GainWeightInput_TextChanged);
            // 
            // CaloriesCalculate
            // 
            this.CaloriesCalculate.Location = new System.Drawing.Point(313, 147);
            this.CaloriesCalculate.Name = "CaloriesCalculate";
            this.CaloriesCalculate.Size = new System.Drawing.Size(127, 32);
            this.CaloriesCalculate.TabIndex = 6;
            this.CaloriesCalculate.Text = "Calculate";
            this.CaloriesCalculate.UseVisualStyleBackColor = true;
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
            // VeryActiveIcon
            // 
            this.VeryActiveIcon.AutoSize = true;
            this.VeryActiveIcon.Location = new System.Drawing.Point(53, 160);
            this.VeryActiveIcon.Name = "VeryActiveIcon";
            this.VeryActiveIcon.Size = new System.Drawing.Size(83, 19);
            this.VeryActiveIcon.TabIndex = 4;
            this.VeryActiveIcon.Text = "Very Active";
            this.VeryActiveIcon.UseVisualStyleBackColor = true;
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
            this.Splits.Location = new System.Drawing.Point(4, 24);
            this.Splits.Name = "Splits";
            this.Splits.Padding = new System.Windows.Forms.Padding(3);
            this.Splits.Size = new System.Drawing.Size(510, 269);
            this.Splits.TabIndex = 3;
            this.Splits.Text = "Splits";
            this.Splits.UseVisualStyleBackColor = true;
            // 
            // Dev
            // 
            this.Dev.AutoSize = true;
            this.Dev.BackColor = System.Drawing.SystemColors.Control;
            this.Dev.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dev.Location = new System.Drawing.Point(451, 301);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(544, 327);
            this.Controls.Add(this.Dev);
            this.Controls.Add(this.TabsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetLeanerWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Leaner Demo";
            this.TabsControl.ResumeLayout(false);
            this.CuttingTab.ResumeLayout(false);
            this.CuttingTab.PerformLayout();
            this.SplitsTab.ResumeLayout(false);
            this.SplitsTab.PerformLayout();
            this.BulkingTab.ResumeLayout(false);
            this.BulkingTab.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaintainWeightIcon;
        private System.Windows.Forms.Label CaloriesInput;
        private System.Windows.Forms.Label GainWeinghtIcon;
        private System.Windows.Forms.Label WhatsYourWeightIcon;
        private System.Windows.Forms.TextBox GainWeightInput;
        private System.Windows.Forms.Button CaloriesCalculate;
        private System.Windows.Forms.Label WhatsYourActivityIcon;
        private System.Windows.Forms.RadioButton VeryActiveIcon;
        private System.Windows.Forms.RadioButton ActiveIcon;
        private System.Windows.Forms.RadioButton LightlyactiveIcon;
        private System.Windows.Forms.RadioButton ModerateIcon;
        private System.Windows.Forms.RadioButton SendetaryIcon;
        private System.Windows.Forms.Label Wateroutput;
        private System.Windows.Forms.Label WaterIcon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

