using System;
using System.Collections.Generic;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Models
{
    public partial class TokenRequestorRegistration : IPersistenceBase
    {
        public TokenRequestorRegistration()
        {
            MappingLgpdtoken = new HashSet<MappingLgpdtoken>();
            MappingPaymentToken = new HashSet<MappingPaymentToken>();
        }

        public string TokenRequestorId { get; set; }
        public string Bin { get; set; }
        public string TokenBin { get; set; }
        public string InitialRangeBin { get; set; }
        public string FinalRangeBin { get; set; }
        public long RangeCounter { get; set; }
        public string LabelImkac { get; set; }
        public string LabelPci { get; set; }
        public string EmvkeyIndex { get; set; }
        public string PcikeyIndex { get; set; }
        public int DateExpirationTokenPolicy { get; set; }
        public int TimeEventExpirationTokenPolicy { get; set; }
        public long EventCounterMaximuPolicy { get; set; }
        public string TransactionAmountMaximumPolicy { get; set; }

        public ICollection<MappingLgpdtoken> MappingLgpdtoken { get; set; }
        public ICollection<MappingPaymentToken> MappingPaymentToken { get; set; }
    }
}
