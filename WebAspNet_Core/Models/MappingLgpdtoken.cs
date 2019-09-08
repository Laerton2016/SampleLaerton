using System;
using System.Collections.Generic;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Models
{
    public partial class MappingLgpdtoken : IPersistenceBase
    {
        public string TokenRequestorId { get; set; }
        public string TokenReferenceId { get; set; }
        public string Bin { get; set; }
        public short Cpflength { get; set; }
        public string Cpfciphered { get; set; }
        public short LgpdtokenLength { get; set; }
        public string Lgpdtoken { get; set; }
        public long RangeCounter { get; set; }
        public short TokenReferenceIdlength { get; set; }
        public string TokenExpirationDate { get; set; }
        public decimal EventCounter { get; set; }
        public DateTime TimerEventExpiration { get; set; }
        public string Last4DigitsPan { get; set; }
        public string CodeValidation { get; set; }
        public short TokenLocation { get; set; }
        public string PcikeyIndex { get; set; }
        public string CardHolderDataCiphered { get; set; }

        public TokenRequestorRegistration TokenRequestor { get; set; }
    }
}
