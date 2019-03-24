using System;

namespace funplacestogo
{
    public class Activity
    {
        private readonly string _mood;

        public Activity(string mood) 
        {
            _mood = mood;
        }

        public string[] ActivityFinder()
        {

            {
                if (_mood == "1" || _mood == "action")
                {
                    string[] ret = { "action", "Stock Car Racing"};
                    return ret;
                }
                else if (_mood == "2" || _mood == "chill times")
                {
                    string[] ret = { "chill times", "Hiking" };
                    return ret;
                }
                else if (_mood == "3" || _mood == "danger")
                {
                    string[] ret = { "danger", "Skydiving"};
                    return ret;
                }
                else if (_mood == "4" || _mood == "good food")
                {
                    string[] ret = { "good food", "To Taco Bell" };
                    return ret;
                }
                else
                {
                    Console.WriteLine("I'm not sure what you mean, please pick from the options I gave you.");
                    string[] ret = { "invalid", "invalid" };
                    return ret;
                }
            }
        }
    }
}
