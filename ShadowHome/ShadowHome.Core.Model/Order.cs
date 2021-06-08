using SqlSugar;

namespace ShadowHome.Core.Model
{
    /// <summary>
    /// 订单_订单表
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 订单_订单表
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// 订单ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 OrderId { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public System.String OrderNo { get; set; }

        /// <summary>
        /// ERP单号
        /// </summary>
        public System.String ERPNo { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public System.Int32? UserId { get; set; }

        /// <summary>
        /// 地址ID
        /// </summary>
        public System.Int32? AddressId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public System.String Address { get; set; }

        /// <summary>
        /// 订单积分
        /// </summary>
        public System.Decimal? Integral { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public System.Decimal? Price { get; set; }

        /// <summary>
        /// 订单数量
        /// </summary>
        public System.Int32? Number { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        public System.DateTime? AddTime { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public System.DateTime? ExamineTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String Remarks { get; set; }

        /// <summary>
        /// 来源 0直接下单 1购物车下单
        /// </summary>
        public System.Int32? Source { get; set; }

        /// <summary>
        /// 状态 0待下单 1待审核 2已完成 3已驳回 4已取消
        /// </summary>
        public System.Int32? Status { get; set; }

        /// <summary>
        /// 是否推送ERP  （0未推送 1已推送）
        /// </summary>
        public System.Int32? IsPush { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        public System.String InvoiceTitle { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public System.String TaxNumber { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        public System.String Bank { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public System.String AccountNumber { get; set; }

        /// <summary>
        /// 发票地址
        /// </summary>
        public System.String InvoiceAddress { get; set; }

        /// <summary>
        /// 删除标记
        /// </summary>
        public System.Int32? IsDel { get; set; }
    }
}
