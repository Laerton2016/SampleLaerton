using System;
using System.Collections.Generic;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Models
{
    public partial class TokenServiceProviderConfig :IPersistenceBase
    {
        public string TokenServiceProviderCode { get; set; }
        public string ParametersJson { get; set; }
    }
}
