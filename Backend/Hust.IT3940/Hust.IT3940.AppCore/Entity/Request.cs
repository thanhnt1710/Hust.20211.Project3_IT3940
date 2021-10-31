using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Lớp Yêu cầu
    /// </summary>
    public class Request : BaseEntity
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid RequestId { get; set; }

        /// <summary>
        /// Id bên gửi
        /// </summary>
        public Guid SourceId { get; set; }

        /// <summary>
        /// Id bên nhận
        /// </summary>
        public Guid DestinationId { get; set; }

        /// <summary>
        /// Id biểu mẫu gửi
        /// </summary>
        public Guid FormRequestId { get; set; }

        /// <summary>
        /// Id biểu mẫu trả về
        /// </summary>
        public Guid FromResponseId { get; set; }

        /// <summary>
        /// Trạng thái yêu cầu
        /// 1-Yêu câu; 2-Trả về,Chấp nhận; 3-Trả về,Từ chối; 4-Hoàn thành
        /// </summary>
        public int? Status { get; set; }

        #endregion
    }
}
