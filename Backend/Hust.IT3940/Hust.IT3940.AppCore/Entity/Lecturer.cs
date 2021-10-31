using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp giảng viên
    /// </summary>
    public class Lecturer
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid LecturerId { get; set; }

        /// <summary>
        /// Mã giảng viên
        /// </summary>
        public string LecturerCode { get; set; }

        /// <summary>
        /// Tên giảng viên
        /// </summary>
        public string LecturerName { get; set; }
        #endregion
    }
}
