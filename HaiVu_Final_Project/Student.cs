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
        public int[] Scores { get; set; }

        public Student() {  }
        public Student(string name, int[] scores = null )
        {
            this.Name = name;
            this.Scores = scores != null ? scores : Array.Empty<int>();
        }

        public override string ToString()
        {            
            return $"{this.Name}|{string.Join("|", this.Scores)}";
        }
    }
}
