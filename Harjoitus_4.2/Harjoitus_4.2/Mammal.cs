using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4._2
{
    class Mammal
    {
        protected string mType = "PERSON";
        public string Name
        {
            get { return mType; }
            set { mType = value; }
        }

        public Mammal()
        {
        }

        public string GetMType()
        {
            return mType;
        }

    }

}
