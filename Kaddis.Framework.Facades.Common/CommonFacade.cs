using Kaddis.Framework.Core.Application.SiteMap.Queries.GetSiteMap;
using Kaddis.Framework.Facades.ICommon;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Kaddis.Framework.Facades.Common
{
    public class CommonFacade : ICommonFacade
    {
        private IMediator _mediator;

        public CommonFacade(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<SiteMapDto> GetSiteMapAsync()
        {
            var test = _mediator.Send(new GetSiteMapQuery());

            return await test;
        }

    }
}
