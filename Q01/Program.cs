using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
    {
    class Program
        {
        static void Main(string[] args)
            {
            string inputScore;
            int score;
            int number;

            Console.WriteLine ( "請輸入分數：" );
            inputScore =  Console.ReadLine ( ) ;
            if (int.TryParse ( inputScore, out number ))
                {
                score = int.Parse ( inputScore );
                Console.WriteLine ( evaluation ( score ) );
                }
            else
                {
                Console.WriteLine ( "請輸入數值！！" );
                }

            Console.ReadKey ( );

            }

        static String evaluation(int score)
            {
            string result = "";

            if (score >= 90)
                {
                result = "考試優秀";
                }
            else if (score >= 80)
                {
                result = "考試良好";
                }
            else if (score >= 60)
                {
                result = "考試及格";
                }
            else
                {
                result = "下次繼續努力";
                }

            return result;

            }

        }
    }