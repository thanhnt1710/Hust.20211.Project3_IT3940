using Hust.IT3940.AppCore.Const;
using Hust.IT3940.AppCore.Entity;
using Hust.IT3940.AppCore.Interfaces;
using Hust.IT3940.AppCore.Properties;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hust.IT3940.Api.Controllers
{
    /// <summary>
    /// Lớp base controller
    /// </summary>
    /// <typeparam name="Entity">entity tùy chỉnh</typeparam>
    /// CreatedBy: ntthanh (27/09/2021)
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity> : ControllerBase
    {
        #region Declare
        IBaseService<Entity> _baseService;
        public ServiceResult _serviceResult;

        /// <summary>
        /// Hàm khởi tạo 
        /// </summary>
        /// <param name="baseService">tầng core</param>
        public BaseController(IBaseService<Entity> baseService)
        {
            _baseService = baseService;
            _serviceResult = new ServiceResult();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Lấy toàn bộ dữ liệu 
        /// </summary>
        /// <returns>
        /// 200 - thành công 
        /// 400 - Dữ liệu đầu vào không hợp lệ
        /// 500 - Exception
        /// </returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var entities = _baseService.GetAll();
                if (entities.Count() > 0)
                {
                    return Ok(entities); //Tra ve du lieu
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                _serviceResult.UserMsg = Resources.ErrorMsg;
                _serviceResult.DevMsg = e.Message;
                _serviceResult.Code = Code.CodeErrorException;
                return StatusCode(500, _serviceResult);
            }
        }

        /// <summary>
        /// Lấy thông tin entity theo khóa chính
        /// </summary>
        /// <param name="Id">khóa chính</param>
        /// <returns>
        /// 200 - thành công 
        /// 400 - Dữ liệu đầu vào không hợp lệ
        /// 500 - Exception
        /// </returns>
        [HttpGet("{Id}")]
        public IActionResult GetById([FromRoute] Guid Id)
        {
            try
            {
                var entity = _baseService.GetById(Id);
                if (entity != null)
                {
                    return Ok(entity); //Tra ve du lieu - 200
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                _serviceResult.UserMsg = Resources.ErrorMsg;
                _serviceResult.DevMsg = e.Message;
                _serviceResult.Code = Code.CodeErrorException;
                return StatusCode(500, _serviceResult);
            }
        }

        #endregion
    }
}
