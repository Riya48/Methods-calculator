using System;

namespace Methods_calculator
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;

            while (true)
            {
             Program sq = new Program();
            Console.WriteLine("---------------------CALCULATOR----------------------");
            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.WriteLine("\t^ : Power ");
            Console.WriteLine("\t% : Percentage ");
            Console.WriteLine("\t@ : Square Root ");
            Console.WriteLine("\t# : Modulus ");
            Console.Write("Select an operand (+, -, /, *, ^, %, @, #): ");
            operand = Console.ReadLine();
                if (operand == "@")
                {

                    Console.WriteLine($"Your result for Square root: {num1}  = " + sq.Sqt(num1));
                }


                else
                {
                    Console.Write("Enter 2nd number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());



                    switch (operand)
                    {
                        case "-":
                            Console.WriteLine($"Your result for Subtract: {num1} - {num2} = " + sq.Subtract(num1, num2));
                            // Console.WriteLine(sq.Subtract(num1, num2));
                            break;
                        case "+":
                            Console.WriteLine($"Your result for Add: {num1} + {num2} = " + sq.Add(num1, num2));
                            //Console.WriteLine(sq.Add(num1, num2));
                            break;
                        case "/":
                            Console.WriteLine($"Your result for Division: {num1} / {num2} = " + sq.Division(num1, num2));
                            // Console.WriteLine(sq.Division(num1, num2));
                            break;
                        case "*":
                            Console.WriteLine($"Your result for Multiply: {num1} * {num2} = " + sq.Multiply(num1, num2));
                            //Console.WriteLine(sq.Multiply(num1, num2));
                            break;
                        case "^":

                            Console.WriteLine($"Your result for Power: {num1} ^ {num2} = " + sq.Power(num1, num2));
                            //Console.WriteLine(sq.Power(num1, num2));
                            break;
                        case "%":
                            Console.WriteLine($"Your result for Percentage: {num1} % {num2} = " + sq.Percentage(num1, num2));
                            //Console.WriteLine(sq.Percentage(num1, num2));
                            break;
                        //case "@":

                        //    Console.WriteLine($"Your result for Square root: {num1}  = " + sq.Sqt(num1));
                        //   // Console.WriteLine(sq.Sqt(num1));
                        //    break;
                        case "#":
                            Console.WriteLine($"Your result for Modulus: {num1} # {num2} = " + sq.Modulo(num1, num2));
                            //Console.WriteLine(sq.Modulo(num1,num2));
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                Console.WriteLine("\n\n Do You Want To Break Press(Y/y) or Press any Key to Continue:");
                Console.WriteLine("-----------------------------------------------------");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();

                //Console.WriteLine(sq.Square(num1,num1));
            }
            
           

        }
                //public int Square(int num1,int num2)
                //{
                //     return num1 * num2;
                //}
                // Add two integers and returns the sum  
                public int Add(int num1, int num2)
                {
                    return num1 + num2;
                }

                // Multiply two integers and retuns the result  
                public int Multiply(int num1, int num2)
                {
                    return num1 * num2;
                }
                // Subtracts small number from big number  
                public int Subtract(int num1, int num2)
                {
                    if (num1 > num2)
                    {
                        return num1 - num2;
                    }

                    return num2 - num1;

                }
                //performing Division on two float variables.  
                public float Division(float num1, float num2)
                {
                    return num1 / num2;
                }
                //performing Power on two float variables.  
                public double Power(float num1, float num2)
                {
                     double pow_ab = Math.Pow(num1, num2);
                     return pow_ab;
                }
        
                //performing Percentage on two float variables.  
                public double Percentage(float num1, float num2)
                {
                    double total = num1 + num2;
                    double percentage = (total / 2.0);
                     return percentage;
                }
        //performing Percentage on two float variables.  
        public double Sqt(double num1)
        {

           // Console.WriteLine("\n Square root of num1");
            // Input positive value, Output square root of x 
            return (Math.Sqrt(num1));

           
        }
        // Modulus two integers and retuns the result  
        public int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }



    }
}
    

    



