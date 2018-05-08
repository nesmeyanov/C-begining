using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace HomeWork8
{
    public class Alarm
    {
        private int hours;
        private int minutes;
        public event EventHandler<string> WakeUp;

        public void SetAlarm(string input)
        {
            parse(input);
            WakeUp.Invoke(this, $"Time is: {hours}:{minutes}");
        }

        private void parse(string input)
        {
            TimeSpan time;
            if (!TimeSpan.TryParse(input, out time))
            {
                throw new ValidationException("parsing error");
            }

            if (time.Days > 0) // in case user input '24'
            {
                throw new ValidationException("parsing error");
            }


            hours = time.Hours;
            minutes = time.Minutes;
            
        }
    }
}