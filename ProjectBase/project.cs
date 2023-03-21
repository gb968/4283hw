namespace ProjectBase
{
    using System;
    public class main{
        public static void Main()
        {
            int feet, inches, pounds;
            string height;
            Console.WriteLine("Enter height in feet and inches");
            height = Console.ReadLine();
            int.TryParse(height.Split(' ',',')[0],out feet);
            int.TryParse(height.Split(' ',',')[1],out inches);
            Console.WriteLine("Enter weight in pounds");
            int.TryParse(Console.ReadLine(),out pounds);
            var functions = new Functions();
            double bmi = functions.bmiCalculator(feet,inches,pounds);
            Category bmiCategory = functions.CategorySorter(bmi);
            Console.WriteLine("Your bmi is " + bmi.ToString() + " in category: "+bmiCategory.ToString());
            Console.ReadKey(true);
        }
    }
    //define bmi categories
    public enum Category{
        Underweight,
        Normalweight,
        Overweight,
        Obese
    }
    public class Functions{
        public double bmiCalculator(int feet, int inches, int pounds){
            double kilograms = pounds * 0.45;
            double meters = (inches + feet*12)*0.025;
            double final = kilograms/(meters*meters);
            return Math.Round(final,1);
        }
        public Category CategorySorter(double inp){
            Category finalCategory;
            switch (inp)
            {
                case var _ when inp < 18.5:
                    finalCategory = Category.Underweight;
                    break;
                case var _ when inp < 25:
                    finalCategory = Category.Normalweight;
                    break;
                case var _ when inp < 30:
                    finalCategory = Category.Overweight;
                    break;
                case var _ when inp >= 30:
                    finalCategory = Category.Obese;
                    break;
                default:
                    finalCategory = Category.Normalweight;
                    Console.WriteLine("Weight value out of range: " + inp.ToString());
                    break;
            }
            return finalCategory;
        }
    }
}