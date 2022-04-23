using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
    {
    class Program
        {
        static void Main(string[] args)
            {
            string inputWeekDay;
            string inputTemperature;
            bool goodWeather;
            Console.WriteLine ( "請輸入週幾：" );
            inputWeekDay = Console.ReadLine ( );
            Console.WriteLine ( "請輸入溫度：" );
            inputTemperature = Console.ReadLine ( );
            Console.WriteLine ( "今天天氣好嗎？： (Y/N)" );
            if (Console.ReadLine ( ) == "Y")
                {
                goodWeather = true;
                }
            else
                {
                goodWeather = false;
                }
            Console.WriteLine ( todo ( inputWeekDay, inputTemperature ,goodWeather) );
            Console.ReadKey ( );
            }

        static string todo(string inputWeekDay, string inputTemperature,bool isGoodWeather)
            {
            int numInt;
            double numDouble;
            int weekDay;
            double temperature;

            if (int.TryParse ( inputWeekDay, out numInt ) == false) { return "請輸入合理週幾！！"; }
            weekDay = int.Parse ( inputWeekDay );
            if (weekDay > 7) { return "請輸入合理週幾！！"; }

            if (double.TryParse ( inputTemperature, out numDouble ) == false) { return "請輸入合理溫度！！"; }
            temperature = double.Parse ( inputTemperature );            

            if (weekDay >= 6)
                {
                if (temperature > 30)
                    {
                    return "游泳";
                    }
                else
                    {
                    return "爬山";
                    }
                }
            else
                {
                if (isGoodWeather)
                    {
                    return "去客戶單位談業務";
                    }
                else
                    {
                    return "在公司上網查資料";
                    }
                }
            }
        }
    }
