﻿using System.Collections.Generic;

namespace GAP.WebAPICore.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Grades> Grades { get; set; }
    }
}
