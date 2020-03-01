using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo004
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.ResetColor();
            Console.WriteLine("Hola mundo cruel y avanzado");            
            Console.ReadKey();
            Console.Clear();
            //Console.BackgroundColor = System.ConsoleColor.DarkGray;
            //Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            /*Console.BackgroundColor = System.ConsoleColor.DarkGreen;
            Console.ForegroundColor = System.ConsoleColor.Green;
            */
            Console.ForegroundColor = System.ConsoleColor.Yellow;
            

            Console.WriteLine("\n\a \\a=Timbre \r \\r=Otra línea.  \\n=nueva línea");
            Console.WriteLine("\n\t \\t=Texto tabulado");
            Console.WriteLine("\n \'Texto entrecomillado (1)\'");
            Console.WriteLine("\n \"Texto entrecomillado (2)\"");
            Console.WriteLine("\n \\ Secuencia e escape \\");

            
            Console.WriteLine("\n\n\t\tTIPOS DE DATOS");
            //System.Console.ResetColor();

            Console.WriteLine("\nBoolean: {0} y {1}", Boolean.FalseString, Boolean.TrueString);
            Console.WriteLine("\nByte: {0} y {1}", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("\nSByte: {0} y {1}", SByte.MinValue, SByte.MaxValue);  
            Console.WriteLine("\nChar: {0} y {1}", Char.MinValue, Char.MaxValue);
            Console.WriteLine("\nDateTime: {0} y {1}", DateTime.MinValue, DateTime.MaxValue);
            Console.WriteLine("\nDecimal: {0} y {1}", Decimal.MinValue, Decimal.MaxValue);
            Console.WriteLine("\nDouble: {0} y {1}", Double.MinValue, Double.MaxValue);
            Console.WriteLine("\nInt16: {0} y {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("\nInt32: {0} y {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("\nInt64: {0} y {1}", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("\nSingle: {0} y {1}", Single.MinValue, Single.MaxValue);
            Console.WriteLine("\nUInt16: {0} y {1}", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("\nUInt32: {0} y {1}", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("\nUInt64: {0} y {1}", UInt64.MinValue, UInt64.MaxValue);
        }
    }
}
