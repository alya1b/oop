using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLaba2
{
    class Global
    {
        public static List<Worker> FileData = new List<Worker>();
        public static IStrategy ParsingStrategy;
        public static string[] Field = { "name", "department", "cathedra", "date", "degree", "gender" };
        public static Dictionary<string, string> ActiveFilter = new Dictionary<string, string>();
    }
}
