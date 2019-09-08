using System;
using System.Collections.Generic;
using WebAspNet_Core.Interface;

namespace WebAspNet_Core.Models
{
    public partial class Otpadministration : IPersistenceBase
    {
        public string OtpadmId { get; set; }
        public string PasswordAdm { get; set; }
        public short Status { get; set; }
        public short TryPinCounter { get; set; }
        public DateTime? LastDateLogin { get; set; }
        public DateTime? LastDateBlocked { get; set; }
        public DateTime? LastDateChangePin { get; set; }
    }
}
