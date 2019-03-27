using System;

namespace funplacestogo
{
    class FunPlaces
    {
        public static void Main()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = "";
            while (name == "") 
            {
                name = Console.ReadLine();
            }

            Console.WriteLine(name + ", what are you in the mood for this evening?" + "\n" +
                "1) Action" + "\n" +
                "2) Chill Times" + "\n" +
                "3) Danger" + "\n" +
                "4) Good Food");

            //Array to hold components of the final string based on user input. 
            string[,] activityMessage = new string[2, 2];
            bool validActivity = false;

            //Loop back to question when user's input is invalid for what they 
            //want to do this evening
            while (!validActivity)
            {
                string mood = Console.ReadLine().ToLower();
                Activity moods = new Activity(mood);
                //Find the activity that corresponds to the user's mood
                string [] activity = moods.ActivityFinder();

                if (activity[0] != "invalid")
                {
                    validActivity = true;
                    string feeling = activity[0];
                    string action = activity[1];
                    activityMessage[0,0] = feeling;
                    activityMessage[0, 1] = action;
                }
            }

            bool stringIsInt = false;

            //Loop back to question when user's input is invalid for how many
            //people they are bringing along
            while (!stringIsInt) 
            {
                Console.WriteLine("How many people are you bringing along?");
                try
                {
                    int peopleNum = Convert.ToInt32(Console.ReadLine());
                    Transportation transportation = new Transportation(peopleNum);
                    //Find a viable transportation option
                    string vehicle = transportation.TransportationFinder();
                    activityMessage[1, 0] = vehicle;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Please enter the number of people as an integer.");
                    continue;
                }
                stringIsInt = true;
            }

            //Tell the user what they are going to do this evening
            Console.WriteLine("Okay if you’re in the mood for " + activityMessage[0, 0]  
                               + ", then you should go " + activityMessage[0, 1]  
                               + " and travel in " + activityMessage[1, 0] + "!");
        }
    }
}


