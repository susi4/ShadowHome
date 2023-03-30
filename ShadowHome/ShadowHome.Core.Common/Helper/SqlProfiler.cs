using SqlSugar;
using System;

namespace ShadowHome.Core.Common.Helper
{
    public class SqlProfiler
    {
        /// <summary>
        /// 格式化参数拼接成完整的SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static string ParameterFormat(string sql, SugarParameter[] pars)
        {
            //应逆向替换，否则由于 SqlSugar 多个表的过滤器问题导致替换不完整  如 @TenantId1  @TenantId10
            for (int i = pars.Length - 1; i >= 0; i--)
            {
                if (pars[i].DbType == System.Data.DbType.String
                    || pars[i].DbType == System.Data.DbType.DateTime
                    || pars[i].DbType == System.Data.DbType.Date
                    || pars[i].DbType == System.Data.DbType.Time
                    || pars[i].DbType == System.Data.DbType.DateTime2
                    || pars[i].DbType == System.Data.DbType.DateTimeOffset
                    || pars[i].DbType == System.Data.DbType.Guid
                    || pars[i].DbType == System.Data.DbType.VarNumeric
                    || pars[i].DbType == System.Data.DbType.AnsiStringFixedLength
                    || pars[i].DbType == System.Data.DbType.StringFixedLength)
                {
                    sql = sql.Replace(pars[i].ParameterName, $"'{pars[i].Value?.ToString()}'");
                }
                else if (pars[i].DbType == System.Data.DbType.Boolean)
                {
                    sql = sql.Replace(pars[i].ParameterName, Convert.ToBoolean(pars[i].Value) ? "1" : "0");
                }
                else
                {
                    sql = sql.Replace(pars[i].ParameterName, pars[i].Value?.ToString());
                }
            }

            return sql;
        }

        /// <summary>
        /// 格式化参数拼接成完整的SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static string ParameterFormat(string sql, object pars)
        {
            SugarParameter[] param = (SugarParameter[])pars;
            return ParameterFormat(sql, param);
        }
    }
}
