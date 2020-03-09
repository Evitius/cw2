using System;
using System.Collections.Generic;
using System.Text;

namespace cw2
{
    class OwnComparer : IEqualityComparer<Student>

    {
        public bool Equals(Student x, Student y)
        {

         return StringComparer
         .InvariantCultureIgnoreCase
         .Equals($"{x.Name} {x.Surname} {x.Id}", 
         $"{y.Name} {y.Surname} {y.Id}");
         throw new NotImplementedException();
        }

        public int GetHashCode(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
