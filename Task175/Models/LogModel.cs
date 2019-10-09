using System;

namespace Task175.Models
{
    public class LogModel
    {
        public LogModel(string str)
        {
            var arrOfItems = str.Split(' ');
            this.Ip = arrOfItems[0];
            this.Time = TimeSpan.Parse(arrOfItems[1]);
            this.dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), arrOfItems[2], true);
        }

        public string Ip { get; set; }
        public DayOfWeek dayOfWeek { get; set; }
        public TimeSpan Time { get; set; }
    }
}