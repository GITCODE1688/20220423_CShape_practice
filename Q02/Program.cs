using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
    {
    class weather
        {
        public double temperature { get; set; }
        public bool goodWeather { get; set; }

        public weather(double temperature, bool w)
            {

            }

        }
    class Program
        {
        static void Main(string[] args)
            {
            
            string inputWeekDay;
            string inputTemperature;
            bool goodWeather;
            //Console.WriteLine ( "請輸入週幾：" );
            //inputWeekDay = Console.ReadLine ( );
            Console.WriteLine ( "請輸入溫度：" );
            inputTemperature = Console.ReadLine ( );
            Console.WriteLine ( "今天天氣？：(1:晴天  2:雨天)" );
            if (Console.ReadLine ( ) == "1")
                {
                goodWeather = true;
                }
            else
                {
                goodWeather = false;
                }
            Console.WriteLine ( todo (  inputTemperature, goodWeather ) );
            Console.ReadKey ( );
            }

        static string todo( string inputTemperature, bool isGoodWeather)
            {
            int numInt;
            double numDouble;
            string weekDay = DateTime.Now.ToString ( "ddd");
            double temperature;

           
      
            if (double.TryParse ( inputTemperature, out numDouble ) == false) { return "請輸入合理溫度！！"; }
            temperature = double.Parse ( inputTemperature );

            if (weekDay =="週六" || weekDay == "週日")
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
