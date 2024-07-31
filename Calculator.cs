using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Hala1
{
    public class Calculator
    {
        public static void Main(string[] args)

        { double num2 = 0, num1 = 0, result = 0, result1 = 1;
            String dec = "";
            string oper = "";
            do
            {
                try
                {

                    Console.WriteLine("enter first number");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose a calculation from *,+,_,%,/,!");
                    oper = Console.ReadLine();
                    if (oper != "!")
                    {
                        Console.WriteLine("enter second number");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                switch (oper)
                {
                    case "*":
                        for (int i = 0; i < num1; i++)
                        {
                            result += num2;
                        }
                        Console.WriteLine(num1+"*" +num2+"= "+ result);
                        break;
                    case "+":
                        Console.WriteLine(num1 + "+" + num2 + "= " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
                        break;
                    case "/":
                        if (num2 == 0) { Console.WriteLine("Divide by 0 is not allowed "); }
                        else
                        {
                            Console.WriteLine(num1 + "/" + num2 + "=" + num1 / num2);
                        }
                      
                        break;
                    case "!":
                        for (int i = 2; i <= num1; i++)
                        {
                            result1 *= i;
                        }
                        Console.WriteLine(num1 + "! = " + result1);
                        break;
                    case "%":
                        int div = (int)num1 / (int)num2;
                        double mult = div * num2;
                        double mod = num1 - mult;
                        Console.WriteLine( num1 +"%"+ num2 +"=" + mod);
                        break;
                    default:
                        Console.WriteLine(" The arithmetic operation is not defined");
                        break;

                }
                do
                {
                    Console.WriteLine("choose c to continue or e to end ");
                    dec = Console.ReadLine();
                } while (dec != "c" && dec != "e");
            } while (dec == "c");
            }



            }} 
        
    
