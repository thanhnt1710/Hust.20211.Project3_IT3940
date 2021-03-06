using Hust.IT3940.AppCore.Entity;
using Hust.IT3940.AppCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hust.IT3940.Api.Controllers
{
    public class RequestController : BaseController<Request>
    {
        IBaseService<Request> _baseService;
        //public ServiceResult ServiceResult;

        public RequestController(IBaseService<Request> baseService) : base(baseService)
        {
            _baseService = baseService;
            //ServiceResult = new ServiceResult();
        }
    }
}
