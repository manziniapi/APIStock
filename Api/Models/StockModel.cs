using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Api.Models
{
    [DataContract]
    public class StockModel
    {
        [DataMember(Name = "íd")]
        public string Id { get; set; }
        [DataMember(Name = "expirationdate")]
        public string ExpirationDate { get; set; }
        [DataMember(Name = "expirationopened")]
        public string ExpirationOpened { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "dateopened")]
        public string DateOpened { get; set; }
    }
}