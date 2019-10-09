using System;

namespace Task175.Models
{
    internal class ResultModel
    {
        public string Ip { get; set; }
        public int Count { get; set; }
        public DayOfWeek Week { get; set; }
        public string PopularPeriod { get; set; }
    }
}