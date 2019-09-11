using Kaddis.Framework.Core.Application.SiteMap.Queries.GetSiteMap;
using System;
using System.Threading.Tasks;

namespace Kaddis.Framework.Facades.ICommon
{
    public interface ICommonFacade
    {
        Task<SiteMapDto> GetSiteMapAsync();
    }
}
