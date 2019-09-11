﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kaddis.Framework.Core.Application.SiteMap.Queries.GetSiteMap
{
    public class SiteMapItemDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }
    }
}
