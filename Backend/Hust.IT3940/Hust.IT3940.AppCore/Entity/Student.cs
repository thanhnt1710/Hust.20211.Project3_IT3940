using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp sinh viên
    /// </summary>
    public class Student
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid StudentId { get; set; }

        /// <summary>
        /// Mã sinh viên
        /// </summary>
        public string StudentCode { get; set; }

        /// <summary>
        /// Tên sinh viên
        /// </summary>
        public string StudentName { get; set; }

        #endregion
    }
}
