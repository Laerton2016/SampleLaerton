﻿using System;
using System.Collections.Generic;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Models
{
    public partial class MappingPaymentToken : IPersistenceBase
    {
        public string TokenRequestorId { get; set; }
        public string TokenReferenceId { get; set; }
        public string Bin { get; set; }
        public short Panlength { get; set; }
        public string Panciphered { get; set; }
        public string PanexpirationDateCiphered { get; set; }
        public short TokenLength { get; set; }
        public string PaymentToken { get; set; }
        public long RangeCounter { get; set; }
        public short TokenReferenceIdlength { get; set; }
        public string TokenExpirationDate { get; set; }
        public short Atc { get; set; }
        public decimal EventCounter { get; set; }
        public DateTime TimerEventExpiration { get; set; }
        public string Last4DigitsPan { get; set; }
        public string CodeValidation { get; set; }
        public short TokenLocation { get; set; }
        public string EmvkeyIndex { get; set; }
        public string PcikeyIndex { get; set; }
        public string AccountAndCardHolderDataAndDeviceDataCiphered { get; set; }

        public TokenRequestorRegistration TokenRequestor { get; set; }
    }
}
