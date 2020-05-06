using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double height = 0;
            string gender = "";

            /*
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("");
            Console.WriteLine("developer: dannybest");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            */

            Console.WriteLine("Write your gender type:");
            gender = Console.ReadLine();
            char g = gender[0];
            Console.Clear();

            Console.WriteLine("Write your weight in kg:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Write your height in m:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            double bmi = Math.Round((weight / Math.Pow(height, 2)), 2);
            double heightInch = height / 0.0254;

            double ibwM = Math.Round(50 + 2.3 * (heightInch - 60));
            double ibwF = Math.Round(45.5 + 2.3 * (heightInch - 60));

            double diffKgM = Math.Round(ibwM - weight);
            double diffKgF = Math.Round(ibwF - weight);

            if (bmi < 18.5)
            {
                if (bmi < 15)
                {
                    Console.WriteLine("Your BMI is: " + bmi);
                    Console.WriteLine("Health: Very serious underweight");

                }
                else if (bmi > 15.0 && bmi < 16.0)
                {
                    Console.WriteLine("Your BMI is: " + bmi);
                    Console.WriteLine("Health: Severely underweight");
                }
                else if (bmi > 16.0 && bmi < 18.5)
                {
                    Console.WriteLine("Your BMI is: " + bmi);
                    Console.WriteLine("Health: Underweight");
                }

                if (g.Equals('m') || g.Equals('M'))
                {
                    Console.WriteLine();
                    Console.WriteLine("You should gain: " + diffKgM + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwM + " kg / " + height + " m");
                    Console.WriteLine("Gender: " + gender);
                    Console.ReadKey();
                }
                else if (g.Equals('f') || g.Equals('F'))
                {
                    Console.WriteLine();
                    Console.WriteLine("You should gain: " + diffKgF + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwF + " kg / " + height + " m");
                    Console.WriteLine("Gender: " + gender);
                    Console.ReadKey();
                }
            }
            else if (bmi > 25)
            {
                if (bmi > 25 && bmi < 30)
                {
                    Console.WriteLine("Your BMI score is: " + bmi);
                    Console.WriteLine("Health status: Overweight");
                }
                else if (bmi > 30 && bmi < 35)
                {
                    Console.WriteLine("Your BMI is: " + bmi);
                    Console.WriteLine("Health: Obese Class I (moderately obese)");
                }
                else if (bmi > 35 && bmi < 40)
                {
                    Console.WriteLine("Your BMI is: " + bmi);
                    Console.WriteLine("Health: Obese Class II (strictly obese)");
                }
                else if (bmi > 40)
                {
                    Console.WriteLine("Your BMI is: " + bmi);
                    Console.WriteLine("Health: Obese Class III (very seriously obese)");
                }

                if (g.Equals('m') || g.Equals('M'))
                {
                    Console.WriteLine();
                    Console.WriteLine("You should gain: " + diffKgM + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwM + " kg / " + height + " m");
                    Console.WriteLine("Gender: " + gender);
                    Console.ReadKey();
                }
                else if (g.Equals('f') || g.Equals('F'))
                {
                    Console.WriteLine();
                    Console.WriteLine("You should gain: " + diffKgF + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwF + " kg / " + height + " m");
                    Console.WriteLine("Gender: " + gender);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Your BMI score is: " + bmi);
                Console.WriteLine("Health status: Normal (healthy weight)");
                Console.ReadKey();
            }
        }
    }
}
