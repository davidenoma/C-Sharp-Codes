using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Tutorial 1 
            // Question 1
            /*
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the fourth number");
            int num4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The number are {0}, {1},{2} and {3}. The Product is: " +
                "{4} ",num,num2,num3,num4, num*num2*num3*num4);

            //Question 2
            Console.WriteLine("The value of x1");
            int x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The value of x2");
            int x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The value of y2");
            int y2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The value of y1");
            int y1 = Convert.ToInt16(Console.ReadLine());
            double x = x2 - x1;
            double y = y2 - y1;                     
            double distance = Math.Sqrt((x * x)+(y * y));
            Console.WriteLine("The distance is {0}", distance);

            //Question 3 
            Console.WriteLine("Enter temp in Celcius");
            int tempC = Convert.ToInt32(Console.ReadLine());
           double tempF = tempC * 1.8 + 32;
            Console.WriteLine("In Fahrenheit {0}", tempF);

            //Question 4

            Console.WriteLine("Enter your weight in pounds");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In Kg it is,  {0}", 0.453592 * weight);

            //Question 5
            Console.WriteLine("Enter the radius of the Sphere");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Surface area of the sphere is {0}", 4 * Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("The volume of the sphere is {0}", (4 / 3) * Math.PI * Math.Pow(radius, 3));

            ///Tutorial 2
            //Question 1 
            
            Console.WriteLine("enter temperature");
            int temp = int.Parse(Console.ReadLine());
            if(temp == 32)
            {

                Console.WriteLine("Freezing point");
            }
            else if(temp > 32)
            {
                Console.WriteLine("Above freexing pint");
            }
            else
            {
                Console.WriteLine("Below Freexing point");
            }
            
            //Question 2 
            Console.WriteLine("hours worked? ");
            int time = Convert.ToInt32(Console.ReadLine());
            if(time <= 12)
            {
                Console.WriteLine("Amount earned: {0}", time * 50);
            }
            else
            {
                int extra = time - 12;
                Console.WriteLine("Amount earned plus overtime: {0}", (time * 50) + (90 * extra));
            }
            //Question 3
            Console.WriteLine("Enter the year to check");
            int year = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            if (year % 4 == 0)
            {
                check = true;
            }
            if (year % 4 == 0 && year % 100 == 0)
            {
                check = false;
            } else if (year % 100 == 0 && year % 400 == 0)
            {
                check = true;
               
            }
            if (check)
            {
                Console.WriteLine("Leap year: {0}", year);
            }
            else
            {
                Console.WriteLine("Not a Leap Year: {0}", year);
            }


            ///Tutorial 3 
            //Question 1

            //Question 2    
            Console.WriteLine("Enter your Matric Number");
            string matNo = Console.ReadLine();
            Console.WriteLine("Enter number of courses done");
            int numCourses = Convert.ToInt32(Console.ReadLine());
            int totalGradePoint = 0;
            int totalCreditUnit = 0;
            int index = 1;
            while (numCourses > 0)
            {
                int qualPoint = 0;
                int gradePoint = 0;
                
                Console.WriteLine("Enter credit Unit for Course {0}",index);
                int courseUnit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter score for course {0}", index);
                int score = Convert.ToInt32(Console.ReadLine());

                if (score >= 70 && score <= 100)
                {
                    gradePoint = 5;
                }
                else if (score >= 60 && score <= 69)
                {
                    gradePoint = 4;
                }
                else if(score >= 50 && score <= 59)
                {
                    gradePoint = 3;
                }
                else if (score >= 45 && score <= 49)
                {
                    gradePoint = 2;
                }
                else if (score >= 40 && score <= 44)
                {
                    gradePoint = 1;
                }
                else
                {
                    gradePoint = 0;
                }
                totalCreditUnit += courseUnit;
                qualPoint = gradePoint * courseUnit;
                totalGradePoint += qualPoint;
                index++;
                numCourses--;
                
            }
            float CGPA = (float) (totalGradePoint / totalCreditUnit);
            Console.WriteLine("Dear Student, {0}, your CGPA is {1}", matNo, CGPA);
            

            ///Tutorial 4 
            ///

            //Question 1 

            static void errorPrinter()
            {
                int count = 0;
                char[] correctChars = { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                Console.WriteLine("Enter printer control string");
                string control = Console.ReadLine();
                char[] myChars = control.ToCharArray();
                int occured = 0;
                for(int i = 0; i < myChars.Length;i++)
                {
                    for(int j = 0; j < correctChars.Length; j++)
                    {
                        if (myChars[i] == correctChars[j])
                        {
                            count++;                          
                        }
                    }
                    if (count > 0)
                    {
                        occured++;
                        count = 0;
                    }
                }
                Console.WriteLine("{0}/{1}", occured, control.Length);

            }
            errorPrinter();

            //Question 2 
            static int sumEven()
            {
                int total = 0;
                for(int i = 1; i <= 100; i++)
                {
                    if (i%2 == 0)
                    {
                        total += i;
                    }
                }
                return total;
            }
            static int sumOdd()
            {
                int total = 0;
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        total += i;
                    }
                }
                return total;
            }
            static void totalSum()
            {
                Console.WriteLine("Sum Odd is {0}, Sum Even in {1} and total sume is {2}", sumOdd(), sumEven(), sumEven()
                    + sumOdd());
                
            }

            totalSum();
            */

            //Question 3

            static void findNextSquare()
            {
                Console.WriteLine("Enter Number");
                double square = Convert.ToDouble(Console.ReadLine());
                double sq = Math.Sqrt(square);
                string sqs =  Convert.ToString(sq);
                if(sqs.IndexOf('.') < 0)
                {
                    Console.WriteLine("Next Square is: {0}",Math.Pow(sq+1, 2));
                }
                else
                {
                    Console.WriteLine("oops {0}", -1);
                }
                

            }

            findNextSquare();

            //Question 4
            int[][] inputArray;

        }

    }
}
