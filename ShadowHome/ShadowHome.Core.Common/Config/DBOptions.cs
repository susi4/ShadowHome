namespace ShadowHome.Core.Common.Config
{
    public class DBOptions
    {
        public string DbType { get; set; }
        public bool IsAutoCloseConnection { get; set; }
        public string ConnectionString { get; set; }
    }
}
