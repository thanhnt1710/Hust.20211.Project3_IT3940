using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Interfaces
{
    /// <summary>
    /// Interface tầng liên kết cơ sở dữ liệu
    /// </summary>
    /// <typeparam name="Entity">entity tùy chỉnh</typeparam>
    public interface IBaseRepository<Entity>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>List obj kết quả</returns>
        IEnumerable<Entity> GetAll();

        /// <summary>
        /// Lấy thông tin theo khóa chính
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>obj entity lấy được theo Id</returns>
        Entity GetById(Guid entityId);
    }
}
