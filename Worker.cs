using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLaba2
{
    class Worker
    {
        private string name;
        private string department;
        private string cathedra;
        private string date;
        private string degree;
        private string gender;

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Cathedra { get => cathedra; set => cathedra = value; }
        public string Date { get => date; set => date = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
