using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp Biểu mẫu
    /// </summary>
    public class Form : BaseEntity
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid FormId { get; set; }

        /// <summary>
        /// Nội dung mô tả biểu mẫu
        /// </summary>
        public string ContentText { get; set; }

        /// <summary>
        /// File nội dung
        /// </summary>
        public FileStream ContentFile { get; set; }

        /// <summary>
        /// Mô tả thêm biểu mẫu
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
