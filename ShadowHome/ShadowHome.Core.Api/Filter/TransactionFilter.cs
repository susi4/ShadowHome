using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SqlSugar;

namespace ShadowHome.Core.Api
{
    public class TransactionFilter : IActionFilter
    {

        ISqlSugarClient _db;//你也可以换EF CORE对象 或者ADO对象都行
        public TransactionFilter(ISqlSugarClient db)//（ISqlSugarClient）需要IOC注入处理事务的对象
        {
            _db = db;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
          /*  _db.BeginTran()*/;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //if (context.Exception == null)
            //{
            //    _db.CommitTran();
            //}
            //else
            //{
            //    _db.RollBack();
            //}
        }
    }
}
