using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp mẫu đơn
    /// </summary>
    public class Template
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// Được sử dụng bởi ai
        /// </summary>
        public int? UseBy { get; set; }

        /// <summary>
        /// Tiêu đề mẫu đơn
        /// </summary>
        public string TemplateTitle { get; set; }

        /// <summary>
        /// Nội dung mẫu đơn
        /// </summary>
        public FileStream TemplateFile { get; set; }

        #endregion
    }
}
