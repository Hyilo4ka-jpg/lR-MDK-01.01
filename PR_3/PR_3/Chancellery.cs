using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3
{
    public class Chancellery : Product
    {
        public override double GetDiscount()
        {
            if (Quantity_ >= 20 && Quantity_ <= 150)
            {
                return 10;
            }

            else if (Quantity_ > 150 && Quantity_ <= 300)
            {
                return 30;
            }

            else if (Quantity_ > 300)
            {
                return 50;
            }
            return 0;
        }
    }
}