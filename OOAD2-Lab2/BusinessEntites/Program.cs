﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class Program : Entity
    {
        public int År { get; set; }
        public List<Alumn> Alumner { get; set; }
        public List<Student> Studenter { get; set; }
        public List<Personal> Anställda { get; set; }


    }
}
