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
            int score;
            Console.WriteLine ("請輸入分數：");
            score = int.Parse ( Console.ReadLine ( ) );
            Console.WriteLine ( evaluation(score));
            Console.ReadKey ( );

            }

        static String evaluation(int score )
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
