namespace ShadowHome.Core.Common.Config
{
    public class DBOptions
    {
        public SqlSugar.DbType DbType { get; set; }
        public bool IsAutoCloseConnection { get; set; }
        public string ConnectionString { get; set; }
    }
}
