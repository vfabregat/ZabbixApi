﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixApi.Entities
{
    public abstract class EntityBase
    {
        public virtual string Id { get; set; }
    }
}