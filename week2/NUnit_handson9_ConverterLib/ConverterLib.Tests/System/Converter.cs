using ConverterLib.Tests;

namespace System
{
    internal class Converter : ConverterLib.Converter
    {
        private IDollarToEuroExchangeRateFeed @object;

        public Converter(IDollarToEuroExchangeRateFeed @object)
        {
            this.@object = @object;
        }
    }
}