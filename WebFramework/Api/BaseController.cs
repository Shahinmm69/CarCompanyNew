using System;
using System.Collections.Generic;
using System.Text;
using WebFramework.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebFramework.Api
{
    [ApiController]
    [AllowAnonymous]
    [ApiResultFilter]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
    }
}
