using System;

namespace linecomp
{
    class Program
    {
        public int len1 = 0;
        public int len2 = 0;
        public int x1;
        public int y1;
        public int x2;
        public int y2;


        public Program()
        {
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Enter value for  coordinate x1 y1 x2 y2");
                this.x1 = Convert.ToInt32(Console.ReadLine());
                this.y1 = Convert.ToInt32(Console.ReadLine());
                this.x2 = Convert.ToInt32(Console.ReadLine());
                this.y2 = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double CalcLength()
        {
            //Calculating a line length
            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }

        public void EqualityMethod(string len1, string len2)
        {
            if (len1.Equals(len2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }

        public void CompareLines(string len1, string len2)
        {
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            if (len1.CompareTo(len2) == 0)
            {
                Console.WriteLine("both lines are equal");
            }
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            double length1 = obj1.CalcLength();
            Program obj2 = new Program();
            double length2 = obj2.CalcLength();

            Console.WriteLine("Length of First Line " + length1);
            Console.WriteLine("Length of Second Line " + length2);
            obj1.EqualityMethod(length1.ToString(), length2.ToString());
            obj2.CompareLines(length1.ToString(), length2.ToString());



        }

    }
}
