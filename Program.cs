using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高(cm)：");
            float Height = float.Parse(Console.ReadLine()) / 100;
            Console.Write("請輸入體重(kg)：");
            float Weight = float.Parse(Console.ReadLine());

            //計算BMI
            float BMI = Weight / (Height * Height);
            Console.WriteLine("BMI指數為： " + BMI + "  (kg / m * m)");

            //判斷體重為正常、過輕、過重，是否免兵役
            if (BMI < 18.5)
            {
                Console.WriteLine("體重過輕");
                if (BMI < 16.5)
                    Console.WriteLine("免兵役");
            }
            else if(18.5 <= BMI && BMI < 24)
            {
                Console.WriteLine("體重正常");
            }
            else if(BMI >= 24)
            {
                Console.WriteLine("體重過重");
                if(BMI > 31.5)
                    Console.WriteLine("免兵役");
            }

            Console.ReadLine();

        }
    }
}
