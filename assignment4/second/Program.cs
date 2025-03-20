using System;


namespace _2025_3_20_assignment4
{
   public class AlarmClock
    {
        private int ClockTime;
        public AlarmClock(int time)
        {
            ClockTime = time;
        }
        public event Action Tick;
        public event Action Alarm;
        public void Start()
        {
            for(int i=0;i<ClockTime;i++)
            {
                Tick();
            }
            Alarm();
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock(10);
            clock.Tick += () => Console.WriteLine("时钟滴答……");
            clock.Alarm += () => Console.WriteLine("时钟闹铃……");
            clock.Start();

        }
    }
}