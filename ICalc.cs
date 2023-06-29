using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public interface ICalc
    {
        public int Less(int valueToCompare);
        public int Greater(int valueToCompare);
    }
}
