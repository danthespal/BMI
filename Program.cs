using System;

namespace BMI_Calculator
{
    internal class Program
    {
        private static void Main()
        {

        Gender:
            Console.WriteLine("Write your gender type:");
            string gender = Console.ReadLine();
            Console.Clear();

            if (string.IsNullOrEmpty(gender))
            {
                goto Gender;
            }

            char g = gender[0];

            if (g != 'f' && g != 'F' && g != 'm' && g != 'M')
            {
                goto Gender;
            }

        Weight:
            Console.WriteLine("Write your weight in kg:");
            string weight = Console.ReadLine();
            Console.Clear();

            if (!double.TryParse(weight, out _))
            {
                goto Weight;
            }

        Height:
            Console.WriteLine("Write your height in m:");
            string height = Console.ReadLine();
            Console.Clear();

            if (!double.TryParse(height, out _))
            {
                goto Height;
            }

            double weight_num = Convert.ToDouble(weight);
            double height_num = Convert.ToDouble(height);
            double bmi = Math.Round(weight_num / Math.Pow(height_num, 2), 2);

            double heightInch = height_num / 0.0254;
            double ibwM = Math.Round(50 + (2.3 * (heightInch - 60)));
            double ibwF = Math.Round(45.5 + (2.3 * (heightInch - 60)));

            double diffKgM = Math.Round(ibwM - weight_num);
            double diffKgF = Math.Round(ibwF - weight_num);

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
                    Console.WriteLine("Recomanded kg for your height: " + ibwM + " kg / " + height_num + " m");
                    Console.WriteLine("Gender: " + gender);
                    _ = Console.ReadKey();
                }
                else if (g.Equals('f') || g.Equals('F'))
                {
                    Console.WriteLine();
                    Console.WriteLine("You should gain: " + diffKgF + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwF + " kg / " + height_num + " m");
                    Console.WriteLine("Gender: " + gender);
                    _ = Console.ReadKey();
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
                    Console.WriteLine("You should lose: " + (diffKgM * -1) + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwM + " kg / " + height_num + " m");
                    Console.WriteLine("Gender: " + gender);
                    _ = Console.ReadKey();
                }
                else if (g.Equals('f') || g.Equals('F'))
                {
                    Console.WriteLine();
                    Console.WriteLine("You should lose: " + (diffKgF * -1) + " kg");
                    Console.WriteLine("Recomanded kg for your height: " + ibwF + " kg / " + height_num + " m");
                    Console.WriteLine("Gender: " + gender);
                    _ = Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Your BMI score is: " + bmi);
                Console.WriteLine("Health status: Normal (healthy weight)");
                _ = Console.ReadKey();
            }
        }
    }
}
