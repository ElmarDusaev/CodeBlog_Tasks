using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Task175.extHelper;
using Task175.Models;

namespace Task175.Repository
{
    public static class Data
    {
        private static List<LogModel> getData(string path)
        {

                var data = File.ReadAllLines(path);
                List<LogModel> model = new List<LogModel>();

                foreach (var item in data)
                {
                    model.Add(new LogModel(item));
                }

                return model;


        }

        public static bool CreateStatisticFile(string path)
        {
            if (File.Exists(path))
            {
                var data = getData(path);
                Save(data);
                return true;
            }
            else
            {
                Console.WriteLine("Файл не найден");
                return false;
            }

        }

        private static void Save(List<LogModel> data)
        {
            var logResult = from i in data
                            group i by i.Ip
                            into ip
                            let count = ip.Count()
                            select new ResultModel
                            {
                                Ip = ip.Key,
                                Count = count,
                                Week = data.getMaxConnectWeek(ip.Key),
                                PopularPeriod = data.getPopularPriod(ip.Key)
                            };


            StringBuilder strBuilder = new StringBuilder();
            foreach (var item in logResult)
            {
                strBuilder.AppendLine($"IP адрес: {item.Ip}, Количество посещений в неделю: {item.Count}, Популярный день недели: {item.Week}, Популярный отрезок времени: {item.PopularPeriod}");
            }

            strBuilder.AppendLine("*****************************");
            strBuilder.AppendLine(data.getPopularPriod());

            File.WriteAllText(@"Repositoriy\Result.txt", strBuilder.ToString());

        }
    }


}
