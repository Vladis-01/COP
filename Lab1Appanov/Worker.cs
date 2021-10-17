using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Appanov
{
    public class Worker
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }

        public Worker()
        {

        }
        public Worker(string Department, string Position, string Name)
        {
            this.Position = Position;
            this.Department = Department;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
