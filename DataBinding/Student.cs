using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    internal class Student
    {
        private int id;
        private string name;
        private Major major;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Major Major { get => major; set => major = value; }
    }
}
