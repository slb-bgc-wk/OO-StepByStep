﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduction()
        {
            return base.SelfIntroduction() + " I am a student.";
        }
    }
}
