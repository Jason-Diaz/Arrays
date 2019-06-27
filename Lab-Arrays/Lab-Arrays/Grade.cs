using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Arrays
{
    class Grade : IComparable<Grade>
    {
        public double score { get; set; }
        public string description { get; set; }

        public Grade(double v1, string v2)
        {
            score = v1;
            description = v2;
        }

       

        public int CompareTo(Grade obj)
        {
            if(score < obj.score)
            {
                return -1;
            }

            if(score > obj.score)
            {
                return 1;
            }

            return 0;
        
        }

        public string toString()
        {
            return "score: " + score + " description: " + description;
        }
    }
}
