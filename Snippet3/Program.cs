using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet3
{   
    class IntlliSenseDemo:TimeZone
    {
        public override string DaylightName
        {
            get { throw new Exception("the method or operation is not implemented."); 
            }
        }
        public override System.Globalization.DaylightTime GetDaylightChanges (int year)
        { 
            throw new Exception("the method or operation is not implemented.");
        }
        public override TimeSpan GetUtcOffset(DateTime time)
        {
            throw new Exception ("the method or operation is not implemented.");
        }

        public override string StandardName
        {
            get
            {
                throw new Exception("the method or operation is not implemented.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
