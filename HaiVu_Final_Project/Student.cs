using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiVu_Final_Project
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student() {  }
        public Student(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {            
            return $"{this.Name}{string.Join("|", this.Scores)}";
        }
    }
}
