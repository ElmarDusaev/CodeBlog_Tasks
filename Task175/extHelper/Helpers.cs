using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task175.Models;

namespace Task175.extHelper
{
    public static class Helpers
    {

            public static DayOfWeek getMaxConnectWeek(this List<LogModel> data, string ip)
            {
                var res = from i in data.Where(a => a.Ip == ip) group i by i.dayOfWeek into w select new { w.Key, count = w.Count() };
                return (from i in res where i.count == res.Max(a => a.count) select i.Key).FirstOrDefault();
            }

            public static string getPopularPriod(this List<LogModel> data, string ip)
            {
                var res = from i in data.Where(a => a.Ip == ip) group i by i.Time.Hours into w select new { w.Key, count = w.Count() };
                var time = (from i in res where i.count == res.Max(a => a.count) select i).FirstOrDefault();
                return "c " + time.Key + " по " + (time.Key + 1) + " часов";
            }

            public static string getPopularPriod(this List<LogModel> data)
            {
                var res = from i in data group i by i.Time.Hours into w select new { w.Key, count = w.Count() };
                var time = (from i in res where i.count == res.Max(a => a.count) select i).FirstOrDefault();
                return "c " + time.Key + " по " + (time.Key + 1) + " часов";
            }
    }
}
