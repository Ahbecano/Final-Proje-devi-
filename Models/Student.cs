using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OgrenciNotFormUygulamasi.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public double Average => Score;

        public string Status => Score >= 50 ? "Geçti" : "Kaldı";
    }
}
