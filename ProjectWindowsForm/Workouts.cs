using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWindowsForm
{
    class Workouts
    {
       

        public string WorkoutName { get; set; }
        public string WorkoutSet { get; set; }

        public string WorkoutCompleteName
        {
            get { return WorkoutName + " - " + WorkoutSet; }
        }
        public override string ToString()
        {
            return WorkoutCompleteName;
        }
    }

     
}
