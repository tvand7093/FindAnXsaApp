﻿using System;
using System.Collections.Generic;
#if ASPNET
    using System.ComponentModel.DataAnnotations;  
#endif
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Data.Models
{
    [DataContract]
    public class University
    {
        public University()
        {
            Ambassadors = new HashSet<XamarinAmbassador>();
        }

        [DataMember]
#if ASPNET
        [Display(Name="University name"), ScaffoldColumn(false)]
#endif
        public int Id { get; set; }

        [DataMember]
#if ASPNET
        [Display(Name = "Name"), Required]
#endif
        public String Name { get; set; }

        [DataMember]
#if ASPNET
        [Display(Name = "Website"), Required, DataType(DataType.Url)]
#endif
        public String WebSite { get; set; }

        [DataMember]
#if ASPNET
        [Display(Name = "Email"), DataType(DataType.EmailAddress)]
#endif
        public String ContactEmail { get; set; }

        [DataMember]
#if ASPNET
        [Display(Name = "Logo"), DataType(DataType.Upload)]
#endif
        public String Logo { get; set; }

        [IgnoreDataMember]
#if ASPNET
        [ScaffoldColumn(false)]
#endif
        public virtual ICollection<XamarinAmbassador> Ambassadors { get; set; }
    }
}
