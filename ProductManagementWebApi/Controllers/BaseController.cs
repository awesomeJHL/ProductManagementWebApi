using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {
    }
}