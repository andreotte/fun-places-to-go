using System;

namespace funplacestogo
{
    public class Transportation
    {
        private readonly int _people;

        public Transportation(int people)
        {
            _people = people;
        }

        //Push user's transportation option to an array based on user input
        public string TransportationFinder()
        {
            {
                if (_people <= 0)
                {
                    return "sneakers";
                }
                else if (_people < 5)
                {
                    return "a sedan";
                }
                else if (_people < 11 )
                {
                    return "a Volkswagon bus";
                }
                else
                {
                    return "an airplane";
                }
            }
        }
    }
}