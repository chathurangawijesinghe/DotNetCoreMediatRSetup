using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kaddis.Framework.Core.Application.SiteMap.Queries.GetSiteMap;
using Kaddis.Framework.Facades.ICommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kaddis.Framework.APIs.Resources.Controllers
{
    public class SiteMapController : BaseController
    {
        private readonly ICommonFacade commonFacade;

        public SiteMapController(ICommonFacade commonFacade)
        {
            this.commonFacade = commonFacade;
        }

        [HttpGet]
        public async Task<ActionResult<SiteMapDto>> GetAll()
        {
            //return Ok(await Mediator.Send(new GetSiteMapQuery()));
            return await commonFacade.GetSiteMapAsync();
        }
    }
}