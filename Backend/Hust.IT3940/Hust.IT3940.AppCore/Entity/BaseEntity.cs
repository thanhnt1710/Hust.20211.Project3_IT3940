﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Entity
{
    /// <summary>
    /// Class chứa các thuộc tính chung cho tất cả class entity khác
    /// </summary>
    public class BaseEntity
    {
        #region Properties

        /// <summary>
        /// Ngày tạo 
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo 
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày chỉnh sửa  
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Người chỉnh sửa 
        /// </summary>
        public string ModifiedBy { get; set; }

        #endregion
    }
}
