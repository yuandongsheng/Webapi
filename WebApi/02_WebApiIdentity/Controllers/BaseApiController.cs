using _02_WebApiIdentity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _02_WebApiIdentity.Controllers
{
    [RequestAuthorize]
    public class BaseApiController : ApiController
    {
    }
}
