using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.AppCore.Const
{
    /// <summary>
    /// Lớp chứa hằng Code
    /// </summary>
    public static class Code
    {
        //Thành công
        public const string CodeSuccess = "Code-100";

        //Lỗi khi thao tác với database tại tầng DataAccess hoặc lỗi DataBase
        public const string CodeErrorData = "Code-200";

        //Lỗi Exception
        public const string CodeErrorException = "Code-300";
    }
}
