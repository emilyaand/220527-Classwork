﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220527_Classwork
{
    public class Group
    {
        public string No { get; set; }
        public Student[] students;

        public Group()
        {
            students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length + 1] = student;
        }
        

    }
    
}
