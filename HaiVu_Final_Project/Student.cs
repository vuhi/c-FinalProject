using System;
using System.Collections.Generic;

namespace HaiVu_Final_Project
{
    public class Student : ICloneable 
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Student()
        {
            this.Name = "";
            this.Scores = new List<int>();
        }
        public Student(string name, List<int> scores = null )
        {
            this.Name = name;
            this.Scores = scores != null ? scores : new List<int>();
        }

        public override string ToString()
        {            
            return $"{this.Name}|{string.Join("|", this.Scores)}";
        }

        public object Clone()
        {
            return new Student(this.Name, this.Scores);
        }
    }
}
