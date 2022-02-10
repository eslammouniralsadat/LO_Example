using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators_Example
{
    public class Program
    {
            static void Main(string[] args)
            {
                // ----- Start Example ----- \\

                int X = 15;
                int Y = 10;
                bool a = true, Result;

                // AND operator
                Result = (X <= Y) && (X > 10); 
                Console.WriteLine("AND Operator: " + Result); // Output ==> False

                // ------------------ \\

                // OR operator
                Result = (X >= Y) || (X < 5); 
                Console.WriteLine("OR Operator: " + Result); // Output ==> True

                // ------------------ \\

                // NOT operator
                Result = !a; 
                Console.WriteLine("NOT Operator: " + Result); // Output ==> False

                // ----- Start Example ----- \\
            }
    }
}
