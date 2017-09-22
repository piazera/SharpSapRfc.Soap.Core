using System.Globalization;

namespace SharpSapRfc.Soap.Core
{
    public class SoapRfcValueMapper : RfcValueMapper
    {
        protected override NumberFormatInfo GetNumberFormat()
        {
            return this.PeriodDecimalNumberFormat;
        }
    }
}
