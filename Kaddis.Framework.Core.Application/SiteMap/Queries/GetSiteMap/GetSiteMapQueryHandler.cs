using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kaddis.Framework.Core.Application.SiteMap.Queries.GetSiteMap
{
    public class GetSiteMapQueryHandler : IRequestHandler<GetSiteMapQuery, SiteMapDto>
    {
        public async Task<SiteMapDto> Handle(GetSiteMapQuery request, CancellationToken cancellationToken)
        {
            SiteMapDto siteMapDto = new SiteMapDto();
            siteMapDto.SiteMapItems.Add(new SiteMapItemDto() { Id = 1, Name = "Item 1" });
            siteMapDto.SiteMapItems.Add(new SiteMapItemDto() { Id = 2, Name = "Sub Item 1" });
            siteMapDto.SiteMapItems.Add(new SiteMapItemDto() { Id = 3, Name = "Item 2" });
            siteMapDto.SiteMapItems.Add(new SiteMapItemDto() { Id = 4, Name = "Sub Item 2" });

            return siteMapDto;
        }
    }
}
