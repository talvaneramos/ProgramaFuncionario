using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFuncionario.Utils
{
    public class ConsoleUtil
    {
        public static string LerString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int LerInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static decimal LerDecimal(string message)
        {
            Console.Write(message);
            return decimal.Parse(Console.ReadLine());
        }

        public static DateTime LerDateTime(string message)
        {
            Console.Write(message);
            return DateTime.Parse(Console.ReadLine());
        }
    }
}
