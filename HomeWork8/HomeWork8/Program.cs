using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время будильника в формате: hh:mm ");

            string input=Console.ReadLine();

            Alarm alarm= new Alarm();
            
            alarm.WakeUp += Alarm_WakeUp;
            alarm.SetAlarm(input);

            Console.ReadLine();

        }

        private static void Alarm_WakeUp(object sender, string e)
        {
            Alarm alarm = (Alarm) sender;
            Console.WriteLine($"{e}");
            Console.WriteLine();
            
        }
    }
}
