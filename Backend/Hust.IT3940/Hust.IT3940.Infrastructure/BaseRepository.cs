using Dapper;
using Hust.IT3940.AppCore.Interfaces;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.IT3940.Infrastructure
{
    /// <summary>
    /// Lớp base thực thi interface Tầng liên kết csdl
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    public class BaseRepository<Entity> : IBaseRepository<Entity>
    {

        #region Declare
        IConfiguration _configuration;
        //Chuoi ket noi
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection = null;
        protected string _tableName;

        /// <summary>
        /// Hàm khởi tạo: Khoi tao cac thong tin can thiet 
        /// </summary>
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            //Khai báo thông tin kêt nối tới db
            _connectionString = _configuration.GetConnectionString("LocalHostConnectionString");
            //Khởi tạo kết nối 
            _dbConnection = new MySqlConnection(_connectionString);
            //Ten bang 
            _tableName = typeof(Entity).Name;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>List obj kết quả</returns>
        public IEnumerable<Entity> GetAll()
        {
            //Buid chuoi cau lenh SQL
            var entities = _dbConnection.Query<Entity>($"Proc_Get{_tableName}s", commandType: CommandType.StoredProcedure);
            //Tra ve du lieu
            return entities;
        }

        /// <summary>
        /// Lấy thông tin theo khóa chính
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>obj entity lấy được theo Id</returns>
        public Entity GetById(Guid entityId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add($"@{_tableName}Id", entityId);
            var entity = _dbConnection.QueryFirstOrDefault<Entity>($"Proc_Get{_tableName}ById", param: parameters, commandType: CommandType.StoredProcedure);
            return entity;
        }
        #endregion
    }
}
