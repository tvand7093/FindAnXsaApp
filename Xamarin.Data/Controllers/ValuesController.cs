﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Xamarin.Data.Models;

namespace Xamarin.Data.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private AmbassadorContext context = new AmbassadorContext();

        // GET api/values
        public IEnumerable<XamarinAmbassador> Get()
        {
            var ambassadors = context.XamarinAmbassadors.ToList();
            return ambassadors;
        }

        // GET api/values/5
        public XamarinAmbassador Get(int id)
        {
            var ambassadors = context.XamarinAmbassadors.Where(x => x.Id == id).SingleOrDefault();
            return ambassadors;
        }
    }
}
