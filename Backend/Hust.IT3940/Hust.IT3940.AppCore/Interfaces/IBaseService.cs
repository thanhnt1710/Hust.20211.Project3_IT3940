using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Interfaces
{
    /// <summary>
    /// interface tầng Core 
    /// </summary>
    /// <typeparam name="Entity">entity tùy chỉnh</typeparam>
    public interface IBaseService<Entity>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>Kết quả hàm GetAll() BaseRepository</returns>
        IEnumerable<Entity> GetAll();

        /// <summary>
        /// Lấy thông tin theo khóa chính
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Kết quả hàm GetById() BaseRepository</returns>
        Entity GetById(Guid entityId);
    }
}
