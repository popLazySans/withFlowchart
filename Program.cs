using System;

namespace fromFlowChart
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sleeptime;
            do
            {
                Console.WriteLine("When are you go to bed?");
                Sleeptime = double.Parse(Console.ReadLine());
            } while (Sleeptime < 0 || Sleeptime > 24);
            double AlarmTime = Sleeptime + 8;
            if(AlarmTime>=6 && AlarmTime <= 12)
            {

            }
            else if (AlarmTime>12 && AlarmTime<=18)
            {
                AlarmTime = 12.00;
            }
            else
            {
                AlarmTime = 6.00;
            }

            bool Awake;
            do
            {
                Console.WriteLine("{0:.00}",AlarmTime);
                Console.WriteLine("Are you wake up?(True or False)");
                Awake = bool.Parse(Console.ReadLine());
                if (Awake == true)
                {
                   
                }
                else
                {
                    AlarmTime = AlarmTime + 1;
                }
            } while (Awake == false);
        }
    }
}
