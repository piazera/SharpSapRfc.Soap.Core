namespace SharpSapRfc.Soap.Configuration
{
    public class SapSoapRfcDestination
    {
        public string RfcUrl { get; set; }
        public string WsdlUrl { get; set; }
        public int Client { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Timeout { get; set; }
    }
}
