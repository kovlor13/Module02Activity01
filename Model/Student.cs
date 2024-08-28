using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Activity01.Model
{
    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public string FullNames => $"{Firstname} {Lastname}";
    }
 }

