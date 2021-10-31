using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Enum
{
    /// <summary>
    /// Enum trạng thái 1 yêu cầu 
    /// </summary>
    public enum StatusRequest
    {
        /// <summary>
        /// Yêu cầu
        /// </summary>
        Request = 0,

        /// <summary>
        /// Trả về, Chấp nhận (đã được xử lý)
        /// </summary>
        ResponseSuccess = 1,

        /// <summary>
        /// Trả về, Từ chối (bị từ chối xử lý)
        /// </summary>
        ResponseFailed = 2,

        /// <summary>
        /// Hoàn thành yêu cầu
        /// </summary>
        Complete = 3,
    }

    /// <summary>
    /// Enum đối tượng sử dụng mẫu form
    /// </summary>
    public enum UseFrom
    {
        /// <summary>
        /// Sinh viên
        /// </summary>
        Student = 1,

        /// <summary>
        /// Giảng viên
        /// </summary>
        Lecturer = 2,

        /// <summary>
        /// Phòng ban
        /// </summary>
        Department = 3
    }
}
