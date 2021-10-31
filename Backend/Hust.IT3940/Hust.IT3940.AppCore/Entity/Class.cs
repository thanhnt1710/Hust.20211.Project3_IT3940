using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp lớp học
    /// </summary>
    public class Class
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid ClassId { get; set; }

        /// <summary>
        /// Mã lớp
        /// </summary>
        public string ClassCode { get; set; }

        /// <summary>
        /// Id giảng viên dạy lớp 
        /// </summary>
        public Guid LecturerId { get; set; }
        #endregion
    }
}
