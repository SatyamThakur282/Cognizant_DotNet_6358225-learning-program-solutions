using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    public interface IDollarToEuroExchangeRateFeed
    {
        double GetExchangeRate(); // returns the current conversion rate
    }

}
