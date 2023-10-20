using SqlSugar;
using System;

namespace Cesium.DataBase
{
    public class DbContext
    {
        private SqlSugarClient _db;
        public SqlSugarClient Db
        {
            get => _db;
            private set => _db = value;
        }
        public DbContext()
        {
            string connStr = $"DataSource={Environment.CurrentDirectory}\\Application\\History";
            ConnectionConfig config = new ConnectionConfig
            {
                ConnectionString = connStr,
                DbType = DbType.Sqlite,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
            };
            _db = new SqlSugarClient(config);
        }
    }
}
