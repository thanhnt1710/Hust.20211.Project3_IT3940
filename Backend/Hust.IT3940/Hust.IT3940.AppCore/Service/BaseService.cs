using Hust.IT3940.AppCore.Entity;
using Hust.IT3940.AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Service
{
    /// <summary>
    /// Lớp thực thi interface tầng Core
    /// </summary>
    /// <typeparam name="Entity">enitity tùy chỉnh</typeparam>
    public class BaseService<Entity> : IBaseService<Entity>
    {
        #region Declare
        IBaseRepository<Entity> _baseRepository;
        ServiceResult _serviceResult;

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="baseRepository"></param>
        public BaseService(IBaseRepository<Entity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>Kết quả hàm GetAll() BaseRepository</returns>
        public IEnumerable<Entity> GetAll()
        {
            return _baseRepository.GetAll();
        }

        /// <summary>
        /// Lấy thông tin theo khóa chính
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Kết quả hàm GetById() BaseRepository</returns>
        public Entity GetById(Guid entityId)
        {
            return _baseRepository.GetById(entityId);
        }
        #endregion
    }
}
