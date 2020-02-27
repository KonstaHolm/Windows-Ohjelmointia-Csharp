using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_4._2
{
    class Dog : Mammal
    {

        private string mOwner;
        public string Owner
        {
            get { return mOwner; }
            set { mOwner = value; }
        }

        public string Name
        {
            get { return mType; }
            set { mType = value + "???"; }
        }

    }
}
