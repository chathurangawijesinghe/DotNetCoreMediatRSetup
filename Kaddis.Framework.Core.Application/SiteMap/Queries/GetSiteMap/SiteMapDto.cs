using System;
using System.Collections.Generic;
using System.Text;

namespace Kaddis.Framework.Core.Application.SiteMap.Queries.GetSiteMap
{
    public class SiteMapDto
    {
        public SiteMapDto()
        {
            SiteMapItems = new List<SiteMapItemDto>();
        }

        public IList<SiteMapItemDto> SiteMapItems { get; set; }
    }
}
