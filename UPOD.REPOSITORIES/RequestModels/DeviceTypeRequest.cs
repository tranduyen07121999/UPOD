﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPOD.REPOSITORIES.RequestModels
{
    public class DeviceTypeRequest
    {
        public Guid? service_id { get; set; }
        public string? devicetype_name { get; set; }
        public string? desciption { get; set; }
    }
}
