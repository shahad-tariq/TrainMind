using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace solutions
{
    class Program
    {

        static void Main(string[] args)
        {

            //Console.Write("Enter the first Input: ");
            //string input1 = (Console.ReadLine());
            //Console.Write("Enter the secound Input: ");
            //string input2 = (Console.ReadLine());
            //Console.Write($"Enter the postion for letter between 0 & {input.Length - 1} :");
            //int position = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Enter the first number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input a character: ");
            //char ch = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            sumSquareNumbers();
            //sortLetters(input1);
            //dynamic result = isAlaphabet(ch);

            //Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }


        // 1. Write a C# Sharp program to compute the sum of the two numerical values.
        // If the two values are the same, return triple their sum.
        static int sumTriple(int n1, int n2)
        =>
            (n1 == n2) ?
            (n1 + n2) * 3 :
            n1 + n2;


        // 2. Write a C# Sharp program to get the absolute difference between n and 51.
        // If n is broader than 51 return triple the absolute difference.

        // Note:
        // Since the value is required to be (absolute difference), the following will be added: Math.Abs
        static int absoluteDifferenceForNumber(int n1)
         =>
             n1 > 51 ?
            (n1 - 51) * 3 :
            (51 - Math.Abs(n1));


        // 3. Write a C# Sharp program to check two given integers, and return true if one of
        // them is 30 or if their sum is 30.
        static bool ifNumberEqualTo30(int n1, int n2)
        =>
            new[] { n1, n2 }.Any(x => x == 30) || (n1 + n2).Equals(30);



        // 4. Write a C# Sharp program to check a given integer and return true if it is within 10
        // of 100 or 200.
        static bool isWithinRange100And200(int n1)
        =>
             (100 - n1) <= 10 || (200 - n1) <= 10;



        // 5. Write a C# Sharp program to create a string where 'if' is added to the front of
        // a given string. If the string already begins with 'if', return it unchanged.
        static string startWithIfPrefix(string input)
        =>
            input.StartsWith("if") ?
            input :
            string.Concat("if", " ", input);



        // 6. Write a C# Sharp program to remove the character at a given position in the string.
        // The given position will be in the range 0..(string length -1) inclusive.
        static string removeCharacterAtPosition(string input, int position)
        =>
            (position >= 0 && position < input.Length) ?
            input.Remove(position, 1) :
            input;


        // 7. Write a C# Sharp program to exchange the first and last characters in a given
        // string and return the new string.
        static string exchangeFirstAndLastCharacters(string input)
        =>
            string.Concat(
                input.LastOrDefault(),
                input.Substring(1, input.Length - 2),
                input.FirstOrDefault()
                );


        // 8. Write a C# Sharp program to create a string which is 4 copies of the 2 front
        // characters of a given string. If the given string length is less than 2 return
        // the original string.
        static string createStringWith4Copies(string input)
        =>
            input.Length < 2 ?
            input :
            string.Join("", Enumerable.Repeat(input.Substring(0, 2), 4));


        // 9. Write a C# Sharp program to create a string with the last char added at
        // the front and back of a given string of length 1 or more.
        static string lastCharcterAddToFront(string input)
        =>
            string.Concat(
                input.LastOrDefault(),
                input,
                input.LastOrDefault()
                );


        // 10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
        static bool isMultipleOf3Or7(int n1)
         =>
             n1 % 3 == 0 || n1 % 7 == 0;


        //11. Write a C# Sharp program to create a string taking the first 3 characters of
        //a given string. Return the string with the 3 characters added at both the front
        //and back. If the given string length is less than 3, use whatever characters are there.
        static string createStringWithFirstAndLastThreeChars(string input)
        {
            if (!string.IsNullOrWhiteSpace(input)) return "";
            string threeChars = input.Substring(0, 3);

            return string.Concat(threeChars, input, threeChars);
        }


        //12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
        static bool ifStartsWithCSharp(string input)
        =>
             !string.IsNullOrWhiteSpace(input) && input.StartsWith("C#");


        //13. Write a C# Sharp program that checks whether one temperature is less than 0 and
        //another is greater than 100.
        static bool ifTemperatureInRange(int t1, int t2)
         =>
             (t1 < 0 && t2 > 100) || (t2 < 0 && t1 > 100);


        //14. Write a C# Sharp program to check two given integers whether either of them is
        //in the range 100..200 inclusive.
        static bool ifInRange100and200(int n1, int n2)
        =>
            (n1 >= 100 && n1 <= 200) || (n2 >= 100 && n2 <= 200);


        //15. Write a C# Sharp program to check whether three given integer values are in
        //the range 20..50 inclusive. Return true if 1 or more of them are in the said
        //range otherwise false.
        static bool ifInRange20and50(int n1, int n2, int n3)
        =>
            (n1 >= 20 && n1 <= 50) || (n2 >= 20 && n2 <= 50) || (n3 >= 20 && n3 <= 50);



        //16. Write a C# Sharp program to check whether two given integer values are in the
        //range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.
        static bool ifOneInRange20and50(int n1, int n2)
        =>
            ((n1 >= 20 && n1 <= 50) && !(n2 >= 20 && n2 <= 50)) ||
            (!(n1 >= 20 && n1 <= 50) && (n2 >= 20 && n2 <= 50));


        //17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string.
        //If it appears return a string without 'yt' otherwise return the original string.
        static string ifOneInRange20and50(string input)
        =>
            (!string.IsNullOrWhiteSpace(input) && input.Substring(1, 2) == "yt") ?
            input.Remove(1, 2) :
            input;


        //18. Write a C# Sharp program to check the largest number among three given integers.
        static int getLargestNumber(int n1, int n2, int n3)
        =>
           new[] { n1, n2, n3 }.Max();


        //19. Write a C# Sharp program to check which number is closest to 100 among two given integers.
        //Return 0 if the two numbers are equal.
        static int closestNumberTo100(int n1, int n2)
        =>
           n1 != n2 ?
            Math.Max(n1, n2) :
            0;



        //20. Write a C# Sharp program to check whether two given integers are in the
        //range 40..50 inclusive, or they are both in the range 50..60 inclusive.
        static bool ifInRange40and60(int n1, int n2)
        =>
           Enumerable.Range(40, 11).Contains(n1) && Enumerable.Range(40, 11).Contains(n2) ||
           Enumerable.Range(50, 11).Contains(n2) && Enumerable.Range(50, 11).Contains(n1);



        //21. Write a C# Sharp program to find the largest value from two positive integer
        //values in the range 20..30 inclusive. Return 0 if neither is in that range.
        static int ifInRange20and30GetMax(int n1, int n2)
        =>
           Enumerable.Range(20, 11).Contains(n1) && Enumerable.Range(20, 11).Contains(n2) ?
            Math.Max(n1, n2) :
            0;

        //22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
        static bool checkZCount(string input)
        {
            int zCount = input.Count(c => c == 'z');
            return zCount >= 2 && zCount <= 4;
        }



        //23. Write a C# Sharp program to check if two given non-negative integers have
        //the same last digit.
        static bool isSameLastDigit(int n1, int n2)
        =>
             n1 % 10 == n2 % 10;



        //24. Write a C# Sharp program to convert the last 3 characters of a given string
        //to uppercase. If the length of the string is less than 3, then uppercase all the characters.
        static string convertLastThreeToUppercase(string input)
        =>
             input.Substring(0, input.Length - 3) + input.Substring(input.Length - 3).ToUpper();




        //25. Write a C# Sharp program to create a string which is n (non-negative integer)
        //copies of a given string.
        static string createCopiesOfString(string input, int n1)
        =>
            n1 > 0 ? String.Concat(Enumerable.Repeat(input, n1)) : "number is negative";



        //1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
        static string ifTwoNumberEquals(int n1, int n2)
        =>
            n1 == n2 ?
            $"{n1} and {n2} are equal" :
            $"{n1} and {n2} are not equal";



        //2. Write a C# Sharp program to check whether a given number is even or odd.
        static string isEvenNumber(int n1)
        =>
            (n1 % 2 == 0) ? "even" : "odd";


        //3. Write a C# Sharp program to check whether a given number is positive or negative.
        static string isNumberPositiveOrNegative(int n1)
        =>
            $"{n1} is a { (n1 > 0 ? "positive" : "negative") } number";


        //4. Write a C# Sharp program to find out whether a given year is a leap year or not.
        static string isLeapYear(int year)
        =>
            (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ?
            $"{year} is a leap year." :
            $"{year} is not leap year.";



        //5. Write a C# Sharp program to read the age of a candidate and determine whether it
        //is eligible for casting his/her own vote.
        static string isEligibleOrNot(int n1)
        =>
           n1 > 18 ?
           ("Congratulation! You are eligible for casting your vote.") :
           ("You are not eligible to cast your own vote.");



        //6. Write a C# Sharp program to read the value of an integer m and display the
        //value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        static int getN(int n1)
        =>
           n1 > 0 ? 1 : (n1 < 0 ? -1 : 0);


        //7. Write a C# Sharp program to accept a person's height in centimeters and categorize
        //them according to their height.
        static string categorizeHeight(int height)
        =>
            height switch
            {
                _ when height < 150 => "Dwarf",
                _ when height >= 150 && height < 170 => "Average",
                _ when height >= 170 && height < 190 => "Tall",
                _ => "Very Tall",
            };


        //8. Write a C# Sharp program to find the largest of three numbers
        static string largestOf3Numbers(int n1, int n2, int n3)
        {

            string maxKey = new Dictionary<string, int>()
            {
                { "1st", n1 },
                { "2nd", n2 },
                { "3rd", n3 }
            }.Aggregate((x, y) => x.Value > y.Value ? x : y)
            .Key;

            return $"The {maxKey} Number is the greatest among three";
        }


        //9. Write a C# Sharp program to accept a coordinate point in an XY coordinate
        //system and determine in which quadrant the coordinate point lies.
        static string coordinateXY(int x, int y)
        {
            string result = "";

            if (x > 0 && y > 0)
                result = "First quadrant";
            else if (x < 0 && y > 0)
                result = "Second quadrant";
            else if (x < 0 && y < 0)
                result = "Third quadrant";
            else if (x > 0 && y < 0)
                result = "Fourth quadrant";
            else
                result = "Origin";

            return result;
        }



        //10. Write a C# Sharp program to determine the eligibility for admission to a
        //professional course based on the following criteria
        static string isEligibleForAdmission(
            int physicsMarks,
            int chemistryMarks,
            int mathMarks
            )
        {
            int sum = physicsMarks + chemistryMarks + mathMarks;


            return (sum >= 180) || (sum + mathMarks) >= 140 ?
                   "The candidate is eligible for admission." :
                   "The candidate is not eligible for admission.";

        }


        //11. Write a C# Sharp program to calculate the root of a quadratic equation.
        static string calculateRoots(
            int a,
            int b,
            int c
            )
        {
            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return "the root is : " + root1 + "," + root2;
            }
            else
            {
                return "Roots are imaginary; No Solution.";
            }

        }


        //12. Write a C# Sharp program to read roll no, name and marks of three
        //subjects and calculate the total, percentage and division.
        static void readAndShowStudentInfo()
        {
            Console.Write("Input the Roll Number of the student: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();

            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
            List<string> marksInput = Console.ReadLine().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            int physicsMarks = Convert.ToInt32(marksInput[0]);
            int chemistryMarks = Convert.ToInt32(marksInput[1]);
            int computerMarks = Convert.ToInt32(marksInput[2]);

            int totalMarks = physicsMarks + chemistryMarks + computerMarks;
            double percentage = (double)totalMarks / 3;

            string division = getDivision(percentage);

            Console.WriteLine($"Roll No: {rollNumber}");
            Console.WriteLine($"Name of Student: {name}");
            Console.WriteLine($"Marks in Physics: {physicsMarks}");
            Console.WriteLine($"Marks in Chemistry: {chemistryMarks}");
            Console.WriteLine($"Marks in Computer Application: {computerMarks}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage.ToString("F2")}");
            Console.WriteLine($"Division: {division}");
        }

        static string getDivision(double p)
        =>
            p switch
            {
                _ when p >= 80 => "First",
                _ when p >= 60 => "Second",
                _ when p >= 40 => "Third",
                _ => "Fail"
            };



        //13. Write a C# Sharp program to read temperature in centigrade and display a
        //suitable message according to the temperature state below:
        static string getTemperatureMessage(int t)
        =>
            t switch
            {
                _ when t < 0 => "Freezing weather",
                _ when t >= 0 && t <= 10 => "Very Cold weather",
                _ when t > 10 && t <= 20 => "Cold weather",
                _ when t > 20 && t <= 30 => "Normal in Temp",
                _ when t > 30 && t <= 40 => "Its Hot",
                _ => "Its Very Hot"
            };



        //14. Write a C# Sharp program to check whether a triangle is Equilateral,
        //Isosceles or Scalene.
        static string checkTriangleType(
            int n1,
            int n2,
            int n3
            )
        {
            string result;

            if (n1 == n2 && n2 == n3)
            {
                result = ("This is an equilateral triangle.");
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                result = ("This is an isosceles triangle.");
            }
            else
            {
                result = ("This is a scalene triangle.");
            }

            return result;

        }


        //15. Write a C# Sharp program to check whether a triangle can be formed by
        //the given angles value.
        static string ifTriangleFormatAngler(
            string n1
            )
        =>
             n1
            .Split(" ")
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(x => Convert.ToInt32(x)).Sum() == 180 ? "The triangle is valid" : "The triangle is not valid";


        //16. Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.
        static string isAlphabetVowel(char ch)
        {
            ch = Char.ToLower(ch);

            return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') ?
                   "The alphabet is a vowel." :
                   "The alphabet is a consonant.";
        }


        //17. Write a C# Sharp program to calculate profit and loss on a transaction.
        static string calculateProfit(double profit, double cost)
        {
            double result = (profit - cost);

            return result switch
            {
                _ when result > 0 => "You can book your profit amount : " + result,
                _ when result < 0 => "You have incurred a loss of: " + Math.Abs(result),
                _ => "No profit or loss."
            };

        }


        //18. Write a C# Sharp program to calculate and print the electricity bill of a
        //customer.From the keyboard, the customer's name, ID, and unit consumed
        //should be taken and displayed along with the total amount due.
        static void printElectricity()
        {
            Console.Write("Enter the customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter the customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter the units consumed: ");
            int unitsConsumed = int.Parse(Console.ReadLine());

            double unitCharge =
                unitsConsumed switch
                {
                    _ when unitsConsumed <= 199 => 1.20,
                    _ when unitsConsumed >= 200 && unitsConsumed < 400 => 1.50,
                    _ when unitsConsumed >= 400 && unitsConsumed < 600 => 1.80,
                    _ when unitsConsumed >= 600 => 1.80,
                    _ => 0
                };


            double charges = unitsConsumed * unitCharge;
            double surchargeAmount = 0;

            if (charges > 400)
            {
                surchargeAmount = charges * 0.15;
            }

            double netPaid = charges + surchargeAmount;

            Console.WriteLine("\nCustomer IDNO: " + customerId);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Unit Consumed: " + unitsConsumed);
            Console.WriteLine("Amount Charges @Rs. " + unitCharge + " per unit: " + charges.ToString("F2"));
            Console.WriteLine("Surcharge Amount: " + surchargeAmount.ToString("F2"));
            Console.WriteLine("Net Amount Paid By the Customer: " + netPaid.ToString("F2"));

        }


        //19. Write a program in C# Sharp to accept a grade and declare the equivalent
        static string getGradeDiscrip(char grade)
        =>
            grade switch
            {
                'e' => "Excellent",
                'v' => "Very Good",
                'g' => "Good",
                'a' => "Average",
                'f' => "Fail",
                _ => "Invalid grade"
            };


        enum DayOfWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        //20. Write a C# Sharp program to read any day number as an integer and
        //display the name of the day as a word.
        static string getDayName(int dayNumber)
         =>
            (Enum.IsDefined(typeof(DayOfWeek), dayNumber)) ?
                 ((DayOfWeek)dayNumber).ToString() :
                 "Invalid day number";




        //21. Write a program in C# Sharp to read any digit, display in the word.
        static string convertNumberToLetter(int n1)
        {
            if (n1 < 0 || n1 > 99)
                return "Invalid number";

            if (n1 <= 20)
                return ((DigitWord)n1).ToString();

            int tens = n1 / 10;
            int ones = n1 % 10;

            string words = ((TensDigitWord)tens).ToString();

            if (ones > 0)
                words += " " + ((DigitWord)ones).ToString();

            return words;
        }

        enum DigitWord
        {
            Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Eleven, Twelve, Thirteen, Fourteen, Fifteen, Sixteen, Seventeen, Eighteen, Nineteen, twenty
        }

        enum TensDigitWord
        {
            Twenty = 2, Thirty = 3, Forty = 4, Fifty = 5, Sixty = 6, Seventy = 7, Eighty = 8, Ninety = 9
        }



        //22. Write C# Sharp program to read any Month Number in integer and display
        //Month name.
        static string getMonthName(int n1)
        =>
            (Enum.IsDefined(typeof(Month), n1)) ?
                ((Month)n1).ToString() :
                "Invalid month number";


        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }



        //23. Write a program in C# Sharp to read any Month Number in integer and
        //display the number of days for this month.
        static Dictionary<int, int> monthDays = new Dictionary<int, int>
        {
            { 1, 31 },
            { 2, 28 },
            { 3, 31 },
            { 4, 30 },
            { 5, 31 },
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 }
        };

        static string getNumberMonth(int n1)
        =>
           (monthDays.TryGetValue(n1, out int days)) ?
            $"Month has {days} days" :
            "Invalid month number";


        //24. Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.
        static void calculateGeometricalShape()
        {
            Console.WriteLine("Geometry Calculator");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Calculate the area of a circle");
            Console.WriteLine("2. Calculate the area of a rectangle");
            Console.WriteLine("3. Calculate the area of a triangle");
            Console.WriteLine("4. Calculate the area of a square");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            Action calculateArea = null;

            switch (choice)
            {
                case 1:
                    calculateArea = calculateCircleArea;
                    break;
                case 2:
                    calculateArea = calculateRectangleArea;
                    break;
                case 3:
                    calculateArea = calculateTriangleArea;
                    break;
                case 4:
                    calculateArea = calculateSquareArea;
                    break;
                case 5:
                    Console.WriteLine("End!");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            calculateArea?.Invoke();
        }


        static void calculateCircleArea()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle is: {area}");
        }

        static void calculateRectangleArea()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"The area of the rectangle is: {area}");
        }

        static void calculateTriangleArea()
        {
            Console.Write("Enter the base length of the triangle: ");
            double baseLength = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double height = double.Parse(Console.ReadLine());

            double area = 0.5 * baseLength * height;
            Console.WriteLine($"The area of the triangle is: {area}");
        }


        static void calculateSquareArea()
        {
            Console.Write("Enter the side length of the square: ");
            double sideLength = double.Parse(Console.ReadLine());

            double area = sideLength * sideLength;
            Console.WriteLine($"The area of the square is: {area}");
        }




        //1. Write a program in C# Sharp to input a string and print it.
        static void inputAndPrintString()
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            Console.WriteLine("The string you entered is: " + input);
        }

        //2. Write a C# Sharp program to find the length of a string without using a library function.
        static void lengthForString()
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Length of the string is: " + input.Length);

            //or
            //int length = 0;
            //foreach (char c in input)
            //{
            //    length++;
            //}
            //Console.WriteLine("Length of the string is: " + input.Length);
        }


        //3. Write a C# Sharp program to separate individual characters from a string
        static void separateCharacters(string input)
        {

            var characters = input.ToCharArray();

            string result = string.Join(" ", characters);

            Console.WriteLine("The characters of the string are:");
            Console.WriteLine(result);
        }

        //4. Write a program in C# Sharp to print individual characters of the string in
        //reverse order
        static void reverseWords(string input)
        {
            char[] charArray = input.ToCharArray();
            string reversedString = string.Join(" ", charArray.Reverse());

            Console.WriteLine("Reversed string: " + reversedString);
        }

        //5. Write a program in C# Sharp to count the total number of words in a string.
        static void countWords(string input)
        {
            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Total number of words in the string is: " + words.Length);
        }

        //6. Write a program in C# Sharp to compare two strings without using a string
        //library functions.
        static string compareStrings(string s1, string s2)
        {
            if (s1.Equals(s2))
                return "The length of both strings are equal and also, both strings are equal.";
            else if (s1.Length == s2.Length)
                return "The length of both strings are equal";
            else return "both not equal";
        }

        //7. Write a program in C# Sharp to count the number of alphabets, digits and
        //special characters in a string.
        static void countAlphabetsAndDigitAndChar(string input)
        {

            int alphabetCount = countCharacters(input, char.IsLetter);
            int digitCount = countCharacters(input, char.IsDigit);
            int specialCharCount = countCharacters(input, (c) => !char.IsLetterOrDigit(c));

            Console.WriteLine("Number of Alphabets in the string is: " + alphabetCount);
            Console.WriteLine("Number of Digits in the string is: " + digitCount);
            Console.WriteLine("Number of Special characters in the string is: " + specialCharCount);

        }

        static int countCharacters(string input, Func<char, bool> predicate)
        {
            return input.Count(predicate);
        }


        //8. Write a program in C# Sharp to copy one string to another string.
        static void copyString(string input)
        {
            string copiedString = (input);

            Console.WriteLine("The First string is: " + input);
            Console.WriteLine("The Second string is: " + copiedString);
            Console.WriteLine("Number of characters copied: " + copiedString.Length);

        }



        //8. Write a program in C# Sharp to copy one string to another string.
        static void countVowelAndConsonantChars(string input)
        {
            int vowelCount = input.Count(c => !char.IsWhiteSpace(c) && "AEIOUaeiou".Contains(c));
            int consonantCount = input.Count(c => !char.IsWhiteSpace(c) && !"AEIOUaeiou".Contains(c));

            Console.WriteLine("The total number of vowel in the string is: " + vowelCount);
            Console.WriteLine("The total number of consonant in the string is: " + consonantCount);

        }


        //10. Write a C# Sharp program to find the maximum number of characters in a
        //string
        static void highestLetterRepeat(string input)
        {
            var charCounts = input
                         .GroupBy(c => c)
                         .OrderByDescending(group => group.Count());

            char mostRepeatedChar = charCounts.First().Key;
            int maxCount = charCounts.First().Count();

            Console.WriteLine("The Highest frequency of character '" + mostRepeatedChar + "' appears number of times: " + maxCount);

        }


        //11. Write a C# Sharp program to sort a string array in ascending order.
        static void sortLetters(string input)
        {
            string sortedString = string.Join(" ", input.OrderBy(ch => ch));

            Console.WriteLine($"After sorting the string appears like: {sortedString}");
        }

        //12. Write a C# Sharp program to read a string through the
        //keyboard and sort it using bubble sort.
        static void sortStringByBubble()
        {
            Console.Write("Input number of strings: ");
            int numStrings = int.Parse(Console.ReadLine());

            string[] strings = new string[numStrings];

            Console.Write($"Input {numStrings} strings below : ");
            for (int i = 0; i < numStrings; i++)
            {
                strings[i] = Console.ReadLine();
            }

            bubbleSort(strings);

            Console.WriteLine("After sorting the array appears like: ");
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

        }

        static void bubbleSort(string[] array)
        {
            int n = array.Length;
            bool flag;

            do
            {
                flag = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (string.Compare(array[i], array[i + 1], StringComparison.Ordinal) > 0)
                    {
                        swap(ref array[i], ref array[i + 1]);
                        flag = true;
                    }
                }

                n--;
            } while (flag);
        }

        static void swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }


        //13. Write a program in C# Sharp to extract a substring from a given string
        //without using the library function.
        static void extractSubstring()
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            Console.Write("Input the position to start extraction: ");
            int startPosition = int.Parse(Console.ReadLine());

            Console.Write("Input the length of substring: ");
            int substringLength = int.Parse(Console.ReadLine());

            if (startPosition < 0 || startPosition >= input.Length)
                throw new ArgumentException("Invalid start position");

            if (substringLength < 0 || substringLength > input.Length - startPosition)
                throw new ArgumentException("Invalid substring length");

            char[] chars = new char[substringLength];

            for (int i = 0; i < substringLength; i++)
            {
                chars[i] = input[startPosition + i];
            }

            Console.WriteLine("The substring retrieved from the string is: " + new string(chars));

        }


        //14. Write a C# Sharp program to check whether a given substring is present in
        //the given string.
        static void checkSubstring()
        {
            Console.Write("Input the string: ");
            string input = Console.ReadLine();

            Console.Write("Input the substring to search: ");
            string substring = Console.ReadLine();

            bool isSubstringPresent = input.Contains(substring);

            if (isSubstringPresent)
            {
                Console.WriteLine("The substring exists in the string");
            }
            else
            {
                Console.WriteLine("The substring does not exist in the string");
            }

        }


        //15. Write a C# Sharp program to read a sentence and replace lowercase
        //characters with uppercase and vice-versa.
        static void convertCase(string input)
        {
            string converter = new string(input.Select((x) =>
                                   (
                                        char.IsLower(x) ?
                                        char.ToUpper(x) :
                                        char.ToLower(x)
                                    )
                                ).ToArray());
            Console.WriteLine($"After conversion, the string is: {converter}");

        }

        //16. Write a program in C# Sharp to check the username and password.
        static void checkUserAndPassword()
        {
            string username = "", password = "";
            bool flag = true;

            do
            {

                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username == "abcd" && password == "1234")
                {
                    Console.WriteLine("Password entered successfully!");
                    flag = false;
                }

            } while (flag);

        }


        //17. Write a program in C# Sharp to search for the position
        //of a substring within a string.
        static void positionOfSubstring()
        {
            Console.Write("Input a String: ");
            string input = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            string substring = Console.ReadLine();

            Console.WriteLine($" Found '{substring}' in 'this is a string' at position " + input.IndexOf(substring));
        }

        //18. Write a C# Sharp program to check whether a character is an alphabet
        //and not and if so, check for the case.
        static string isAlaphabet(char c)
        {
            if (!char.IsLetter(c))
            {
                return ("Its not a letter");
            }

            return ($"The character is {(char.IsUpper(c) ? "Uppercase" : "Lowercase")}.");
        }

        //19. Write a program in C# Sharp to find the number of times a substring
        //appears in a given string.
        static void countSubstringOccurrences()
        {
            Console.Write("Input the original string: ");
            string input = Console.ReadLine();

            Console.Write("Input the string to be searched for: ");
            string search = Console.ReadLine();

            int count = Enumerable.Range(0, input.Length - search.Length + 1)
                .Count(i => input.Substring(i, search.Length).Equals(search));

            Console.WriteLine($"The string '{search}' occurs {count} times");
        }

        //20. Write a program in C# Sharp to insert a substring before the first
        //occurrence of a string.
        static void subStringInseriton()
        {
            Console.Write("Input the original string: ");
            string input = Console.ReadLine();

            Console.Write("Input the string to be searched for: ");
            string search = Console.ReadLine();

            Console.Write("Input the string to be inserted: ");
            string insert = Console.ReadLine();

            string sentence = input.Insert(input.IndexOf(search), $" {insert} ");
            Console.WriteLine("The modified string is : " + sentence);
        }

        //21. Write a C# Sharp program to compare (less than, greater than, equal to)
        //two substrings.
        static void compartionSubstring()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            Console.Write("Enter the starting index of the first substring: ");
            int startIndex1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the first substring: ");
            int length1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the starting index of the second substring: ");
            int startIndex2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second substring: ");
            int length2 = int.Parse(Console.ReadLine());

            string substring1 = str1.Substring(startIndex1, length1);
            string substring2 = str2.Substring(startIndex2, length2);

            int comparison = String.Compare(substring1, substring2);

            if (comparison < 0)
            {
                Console.WriteLine($"Substring '{substring1}' in '{str1}' is less than substring '{substring2}' in '{str2}'.");
            }
            else if (comparison > 0)
            {
                Console.WriteLine($"Substring '{substring1}' in '{str1}' is greater than substring '{substring2}' in '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Substring '{substring1}' in '{str1}' is equal to substring '{substring2}' in '{str2}'.");
            }

        }


        //22. Write a C# Sharp program to compare two substrings that only differ in
        //case. The first comparison ignores case and the second comparison
        //considers case.
        static void comparisonIgnoreCasing()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            Console.Write("Enter the starting index of the first substring: ");
            int startIndex1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the first substring: ");
            int length1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the starting index of the second substring: ");
            int startIndex2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second substring: ");
            int length2 = int.Parse(Console.ReadLine());

            string substring1 = str1.Substring(startIndex1, length1);
            string substring2 = str2.Substring(startIndex2, length2);

            compareSubstrings(
                str1,
                str2,
                substring1,
                substring2,
                StringComparison.OrdinalIgnoreCase,
                "Ignore case:");

            compareSubstrings(
                str1,
                str2,
                substring1,
                substring2,
                StringComparison.Ordinal,
                "Honor case:");

        }

        static void compareSubstrings(
            string str1,
            string str2,
            string substring1,
            string substring2,
            StringComparison comparisonType,
            string message)
        {
            int resultIgnoreCase = string.Compare(substring1, substring2, comparisonType);

            string resultMessage = (resultIgnoreCase == 0)
                ? $"Substring '{substring1}' in '{str1}' is equal to substring '{substring2}' in '{str2}'."
                : (resultIgnoreCase < 0)
                    ? $"Substring '{substring1}' in '{str1}' is less than substring '{substring2}' in '{str2}'."
                    : $"Substring '{substring1}' in '{str1}' is greater than substring '{substring2}' in '{str2}'.";

            Console.WriteLine(message);
            Console.WriteLine(resultMessage);
            Console.WriteLine();
        }

        //23. Write a C# Sharp program to compare two substrings using different
        //cultures and ignore the substring case.
        public static void compartionTurkeyWord()
        {

            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            Console.Write("Enter the starting index of the first substring: ");
            int startIndex1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the first substring: ");
            int length1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the starting index of the second substring: ");
            int startIndex2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second substring: ");
            int length2 = int.Parse(Console.ReadLine());

            string substring1 = str1.Substring(startIndex1, length1);
            string substring2 = str2.Substring(startIndex2, length2);

            compareSubstrings(
                str1,
                str2,
                substring1,
                substring2,
                new CultureInfo("tr-TR"),
                "Ignore case, Turkish culture:");

            compareSubstrings(str1,
                str2,
                substring1,
                substring2,
                CultureInfo.InvariantCulture,
                "Ignore case, invariant culture:");

        }

        static void compareSubstrings(
            string str1,
            string str2,
            string substring1,
            string substring2,
            CultureInfo culture,
            string message)
        {
            int resultIgnoreCase = string.Compare(substring1, substring2, true, culture);

            string resultMessage = (resultIgnoreCase == 0)
                ? $"Substring '{substring1}' in '{str1}' is equal to substring '{substring2}' in '{str2}'."
                : $"Substring '{substring1}' in '{str1}' is not equal to substring '{substring2}' in '{str2}'.";

            Console.WriteLine(message);
            Console.WriteLine(resultMessage);
            Console.WriteLine();
        }


        //24. Write a C# Sharp program to compare the last names of two people. It
        //then lists them in alphabetical order.
        static void orderLastNameAlphabet()
        {
            string[] names = { "John Peterson", "Michel Jhonson" };

            Console.WriteLine("Sorted alphabetically by last name:");

            var sortedNames = names.OrderBy((x) => x.Split(' ').Last());

            foreach (string name in sortedNames)
            {
                Console.WriteLine(name);
            }

        }



        //25. Write a C# Sharp program to compare four sets of words by using each
        //member of the string comparison enumeration.The comparisons use the
        //conventions of the English(United States) and Sami(Upper Sweden)
        //cultures.
        static void compareWordsConvertions()
        {
            string word1 = "case";
            string word2 = "Case";

            CultureInfo enUSCulture = new CultureInfo("en-US");
            CultureInfo samiCulture = new CultureInfo("se-SE");

            StringComparison[] comparisons = {
            StringComparison.CurrentCulture,
            StringComparison.CurrentCultureIgnoreCase,
            StringComparison.InvariantCulture,
            StringComparison.InvariantCultureIgnoreCase,
            StringComparison.Ordinal,
            StringComparison.OrdinalIgnoreCase
        };

            Console.WriteLine("Comparison Results:");

            foreach (StringComparison comparison in comparisons)
            {
                bool isComparision = string.Equals(word1, word2, comparison);

                Console.WriteLine($"{comparison} : {(isComparision)}");
            }
        }


        //1. Write a program in C# Sharp to display the first 10 natural numbers.
        static void displayFirst10Number()
        {
            var naturalNumbers = Enumerable.Range(1, 10);
            string numbersString = string.Join(" ", naturalNumbers);

            Console.WriteLine(numbersString);
        }


        //2. Write a C# Sharp program to find the sum of the first 10 natural numbers.
        static void displayFirst10NumberAndSum()
        {
            int n = 10;
            int sum = Enumerable.Range(1, n).Sum();

            Console.WriteLine("The first {0} natural numbers are:", n);
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, n)));

            Console.WriteLine("The sum is: " + sum);
        }


        //3. Write a C# Sharp program that displays the sum of n natural numbers.
        static void displayNumberNatural()
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = Enumerable.Range(1, n).Sum();

            Console.WriteLine("The first {0} natural numbers are:", n);
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, n)));

            Console.WriteLine("The sum of natural numbers up to {0} terms: {1}", n, sum);

        }

        //4. Write a C# Sharp program to read 10 numbers and find their average and sum.
        static void read10AndPrintSumAndAvg()
        {
            const int count = 10; // Number of input numbers

            Console.WriteLine("Enter the 10 numbers:");

            int[] numbers = Enumerable.Range(1, count)
                                      .Select(_ => int.Parse(Console.ReadLine()))
                                      .ToArray();

            int sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine("The sum of {0} numbers is: {1}", count, sum);
            Console.WriteLine("The average is: {0}", average);

        }


        //5. Write a C# Sharp program to display the cube of an integer up to given number.
        static void displayCubeForNumber()
        {
            Console.Write("Input number of terms: ");
            int numberOfTerms = int.Parse(Console.ReadLine());

            List<int> cubes = Enumerable.Range(1, numberOfTerms).Select(x => x * x * x).ToList();

            List<string> result = cubes
                .Zip(cubes, (number, cube) => $"Number is: {number} and cube of {number} is: {cube}").ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }


        //6. Write a program in C# Sharp to display the multiplication table of a given integer.
        static void multipTable()
        {
            Console.Write("Input the number (Table to be calculated) : ");
            int number = int.Parse(Console.ReadLine());

            string[] table = Enumerable.Range(1, 10)
            .Select(x => $"{number} X {x} = {number * x}")
            .ToArray();

            foreach (var item in table)
            {
                Console.WriteLine(item);
            }

        }


        //7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
        static void multipTableVertically()
        {
            Console.Write("Input the number (Table to be calculated) : ");
            int n = int.Parse(Console.ReadLine());

            Enumerable.Range(1, 8)
             .ToList()
             .ForEach(x =>
             {
                 var tableRow = Enumerable.Range(1, n)
                     .Select(y => $"{y}x{x} = {x * y}")
                     .ToArray();

                 Console.WriteLine(string.Join(", ", tableRow));
             });

        }

        //8. Write a C# Sharp program to display the n terms of odd natural numbers
        //and their sums.
        static void sumOddNumber()
        {
            Console.Write("Input number of terms: ");
            int n = int.Parse(Console.ReadLine());
            List<int> oddNumber = Enumerable.Range(1, n * 2 - 1).Where(x => x % 2 != 0).ToList();

            Console.WriteLine($"The odd numbers are: {string.Join(" ", oddNumber)}");
            Console.WriteLine($"The Sum of odd Natural Number upto {n} terms: {oddNumber.Sum()}");

        }


        //9. Write a program in C# Sharp to display a right angle triangle with an
        //asterisk.
        static void printTriangle()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Enumerable.Range(1, rows)
                .Select(row => new string('*', row))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        //10. Write a program in C# Sharp to display a pattern like a right angle triangle
        //with a number.
        static void printTriangleNumber()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Enumerable.Range(1, rows)
                .Select(row => string.Join(" ", Enumerable.Range(1, row)))
                .ToList()
                .ForEach(Console.WriteLine);
        }


        //11. Write a program in C# Sharp to make such a pattern like a right angle
        //triangle with a number which repeats a number in a row.
        static void printTriangleRepeateNumber()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());


            Enumerable.Range(1, rows)
                .Select(x => string.Join(" ", Enumerable.Repeat(x, x)))
                .ToList()
                .ForEach(Console.WriteLine);
        }



        //12. Write a C# Sharp program to make such a pattern like a right angle
        //triangle with the number increased by 1.
        static void printTriangleNumberWithIncreased()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int count = 1;
            Enumerable.Range(count, rows)
                .Select(row => string.Join(" ", Enumerable.Range(count++, row)))
                .ToList()
                .ForEach(Console.WriteLine);

        }

        //13. Write a program in C# Sharp to make such a pattern like a pyramid with
        //numbers increasing by 1.
        static void printPyramidByNumber()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                string spaces = new string(' ', rows - i);
                string line = string.Join(" ", Enumerable.Range(number, i).ToArray());
                Console.WriteLine(spaces + line);
                number += i;
            }
        }


        //14. Write a program in C# Sharp to make such a pattern like a pyramid with an
        //asterisk.
        static void printPyramidAsterisk()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                string spaces = new string(' ', rows - i);
                string line = string.Join(" ", Enumerable.Repeat("*", i));
                Console.WriteLine(spaces + line);
                number += i;
            }
        }


        //15. Write a C# Sharp program to calculate the factorial of a given number.
        static void calculateFactorial()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }

            long factorial = getFactorial(number);

            Console.WriteLine("The Factorial of {0} is: {1}", number, factorial);

        }

        static long getFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * getFactorial(number - 1);
        }



        //16. Write a program in C# Sharp to display the n terms of even natural number
        //and their sum.
        static void evenNumberSum()
        {
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            List<int> evenNumbers = Enumerable.Range(1, n).Select(x => x * 2).ToList();
            int sum = evenNumbers.Sum();

            Console.WriteLine("The even numbers are: " + string.Join(" ", evenNumbers));
            Console.WriteLine("The Sum of even Natural Numbers up to {0} terms: {1}", n, sum);

        }


        //17. Write a program in C# Sharp to make such a pattern like a pyramid with a
        //number which will repeat the number in the same row.
        static void printPyramidRepeatNumber()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                string spaces = new string(' ', rows - i);
                string line = string.Join(" ", Enumerable.Repeat(i, i));
                Console.WriteLine(spaces + line);
                number += i;
            }
        }

        //18. Write a program in C# Sharp to find the sum of the series [1-X^2/2!+X^4/4!- .........].
        static void calculateSeriesSum()
        {
            Console.Write("Input the Value of x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input the number of terms: ");
            int numTerms = int.Parse(Console.ReadLine());



            double sum = Enumerable.Range(0, numTerms)
                .Select(i => Math.Pow(-1, i) * Math.Pow(x, 2 * i) / getFactorial(2 * i))
                .Sum();

            Console.WriteLine("The sum = " + sum);
            Console.WriteLine("Number of terms = " + numTerms);
            Console.WriteLine("Value of x = " + x);
        }


        //19. Write a program in C# Sharp to display the n terms of harmonic series and
        //their sum.
        static void calculateHarmonicSeries()
        {
            Console.Write("Input the number of terms: ");
            int num = int.Parse(Console.ReadLine());

            double result = Enumerable.Range(1, num)
                           .Select(term => 1.0 / term).Sum();

            Enumerable.Range(1, num)
                .Select(x => "1/" + x + " + ")
                .ToList()
                .ForEach(Console.Write);

            Console.WriteLine();
            Console.WriteLine("Sum of Series upto {0} terms: {1}", num, result);

        }


        //20. Write a program in C# Sharp to display the pattern like pyramid using an
        //asterisk and each row contain an odd number of an asterisks.
        static void printPyramidWithOddAsterisk()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= rows; i+=2)
            {
                string spaces = new string(' ', rows - i);
                string line = string.Join(" ", Enumerable.Repeat("*", i));
                Console.WriteLine(spaces + line);
                number += i;
            }
        }


        //21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
        static void sumSeries()
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            // Calculate the sum of the series
            int sum = 0;
            int term = 9;

            for (int i = 0; i < n; i++)
            {
                Console.Write(term + " ");
                sum += term;
                term = term * 10 + 9;
            }

            Console.WriteLine("\nThe sum of the series = " + sum);

        }

        //22. Write a program in C# Sharp to print Floyd's Triangle.
        static void printFloydsTriangle()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());


            Enumerable.Range(1, rows)
                .Select(row => string.Concat(Enumerable.Range(1, row).Select(col => col % 2).Reverse()))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        //23. Write a program in C# Sharp to display the sum of the series [1+x+x^2/2!+x^3/3!+....].
        static void calculateEquation()
        {
            Console.Write("Input the value of x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i < terms; i++)
            {
                double numerator = Math.Pow(x, i);
                double factorial = getFactorial(i);
                sum += numerator / factorial;
            }

            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("Number of terms = {0}", terms);
            Console.WriteLine("The value of x = {0}", x);
        }

        //24. Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....].
        static void calculateSeriesSum2()
        {
            Console.Write("Input the value of x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            double sum = 0;
            int exponent = 1;

            for (int i = 0; i < terms; i++)
            {
                if (i % 2 == 0)
                {
                    sum += Math.Pow(x, exponent);
                }
                else
                {
                    sum -= Math.Pow(x, exponent);
                }

                exponent += 2;
            }

            Console.WriteLine("The sum = {0}", sum);
            Console.WriteLine("Number of terms = {0}", terms);
            Console.WriteLine("The value of x = {0}", x);
        }

        //25. Write a C# Sharp program that displays the n terms of square natural
        //numbers and their sum.
        static void sumSquareNumbers()
        {
            Console.Write("Input the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            int[] squareNumbers = Enumerable.Range(1, terms)
                .Select(n => n * n)
                .ToArray();

            Console.WriteLine("The square natural numbers up to {0} terms are: {1}", terms, string.Join(" ", squareNumbers));

            Console.WriteLine("The sum of square natural numbers up to {0} terms = {1}", terms, squareNumbers.Sum());


        }



    }
}
