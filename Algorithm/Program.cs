using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Console.ReadLine();
        }

        #region ExpressionsMatter
        //Task
        //Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
        //In other words, try every combination of a, b, c with[*+()] , and return the Maximum Obtained

        //        Consider an Example :
        //With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:

        //1 * (2 + 3) = 5
        //1 * 2 * 3 = 6
        //1 + 2 * 3 = 7
        //(1 + 2) * 3 = 9
        //So the maximum value that you can obtain is 9.
        public static int ExpressionsMatter(int a, int b, int c)
        {
            return new[] { a * (b + c), a * b * c, a + b * c, (a + b) * c, a + b + c }.Max();
        }

        #endregion


        #region String character count
        public static int StrCount(string str, string letter) => str.Count(x => x.ToString() == letter);

        #endregion

        #region calcFunc
        ////        Write a function called calculate that takes 3 values.The first and third values are numbers.
        //        The second value is a character.If the character is "+" , "-", "*", or "/", 
        //        the function will return the result of the corresponding mathematical function on the two numbers.
        //            If the string is not one of the specified characters,
        //            the function should return null (throw an ArgumentException in C#).

        ////        calculate(2,"+", 4); //Should return 6
        ////        calculate(6,"-", 1.5); //Should return 4.5
        ////        calculate(-4,"*", 8); //Should return -32
        ////        calculate(49,"/", -7); //Should return -7
        ////        calculate(8,"m", 2); //Should return null
        ////        calculate(4,"/",0) //should return null
        ////Keep in mind, you cannot divide by zero.If an attempt to divide by zero is made, return null (throw an ArgumentException in C#).
        public static double Execute(double num1, char op, double num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0) throw new ArgumentException();
                    return num1 / num2;
                default:
                    throw new ArgumentException();
                  
            }
        }

        #endregion
        #region phonenumber
        // Write a function that accepts an array of 10 integers(between 0 and 9),
        //that returns a string of those numbers in the form of a phone number.
        //Example:
        //Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
        //The returned format must be correct in order to complete this challenge.
        //Don't forget the space after the closing parentheses!

        public static string CreatePhoneNumber(int[] numbers)
        {

            string result = string.Join(string.Empty, numbers);
            string phoneNum;
            string phoneFormat = "(000) 000-0000";
            phoneNum = long.Parse(result).ToString(phoneFormat);

            return phoneNum;
        }

        #endregion
    }


}
