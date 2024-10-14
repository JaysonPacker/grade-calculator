namespace hw.gradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jayson Packer
             * IGME 201
             * Grade Calculator
             */
            // varibles
            string studentName = "Jayson";
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            int average = 0;
            // program
            Console.WriteLine($"Hello {studentName}");
            Console.WriteLine("Here are your grades");

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                if (grades[i] >= 90 && grades[i]<=100)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if(grades[i] >= 80 && grades[i] <= 89)
                {
                    Console.WriteLine("This is an B");
                }
                else if (grades[i] >= 70 && grades[i] <= 79)
                {
                    Console.WriteLine("This is an C");
                }
                else if (grades[i] >= 65 && grades[i] <= 69)
                {
                    Console.WriteLine("This is an D");
                }
                else if (grades[i] >= 0 && grades[i] <= 64)
                {
                    Console.WriteLine("This is an F");
                }
                else
                {
                    Console.WriteLine("This is out of the range 0-100. How did you even get this grade?");
                }
                average += grades[i];
            }
            // calculate average
            average = average / grades.Length;


            Console.WriteLine($"Your final calculated average is: {average}");
            Console.WriteLine($"We have dispaly all graes for {studentName}");
        }
    }
}
