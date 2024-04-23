using System.Runtime.Serialization;

namespace SoapService.Models
{
    [DataContract]
    public class SimplifyDataContract
    {
        [DataMember]
        public double firstno { get; set; }

        [DataMember]
        public double secondno { get; set; }

        [DataMember]
        public double Result { get; set; }
    }
}
