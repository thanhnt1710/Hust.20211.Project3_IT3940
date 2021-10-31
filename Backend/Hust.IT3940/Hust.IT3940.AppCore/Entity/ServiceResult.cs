using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp chứa thông tin kết quả trả về 
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// Thông điệp cho dev
        /// </summary>
        public string DevMsg { get; set; }

        /// <summary>
        /// Thông điệp cho user
        /// </summary>
        public string UserMsg { get; set; }

        /// <summary>
        /// Dữ liệu cụ thể
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Mã 
        /// </summary>
        public string Code { get; set; }
    }
}
