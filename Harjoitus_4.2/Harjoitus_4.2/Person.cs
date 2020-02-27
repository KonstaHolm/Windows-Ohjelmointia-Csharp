using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4._2
{
    class Person : Mammal
    {
        
        protected int mAge;
        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }
        public string Name
        {
            get { return mType; }
            set { mType = value + "!!!"; }
        }

        public Person()
        {
        }

    }

}
