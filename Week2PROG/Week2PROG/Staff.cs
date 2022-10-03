using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2PROG
{
    internal class Staff : Item, Iinterface
    {
        public void IsMagicItem()
        {
            Power = 10;
        }
    }
}
