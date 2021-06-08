using SqlSugar;

namespace ShadowHome.Core.Model
{
    /// <summary>
    /// 用户_用户表
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户_用户表
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 UserId { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        public System.String CusNo { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public System.String CusName { get; set; }

        /// <summary>
        /// 用户类型(0:渠道商 1:业务经理)
        /// </summary>
        public System.Int32? UserType { get; set; }

        /// <summary>
        /// 客户类型
        /// </summary>
        public System.Int32? AccountType { get; set; }

        /// <summary>
        /// 业务经理ID(渠道商指定业务经理)
        /// </summary>
        public System.Int32? ManagerId { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public System.String Province { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public System.String Address { get; set; }

        /// <summary>
        /// 法人代表
        /// </summary>
        public System.String CusArtificialPerson { get; set; }

        /// <summary>
        /// 主要联系人
        /// </summary>
        public System.String Maincontact { get; set; }

        /// <summary>
        /// 联络电话
        /// </summary>
        public System.String Telephone { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        public System.String CusTxRegisterNo { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        public System.String CusBank { get; set; }

        /// <summary>
        /// 银行帐号
        /// </summary>
        public System.String CusBankAccount { get; set; }

        /// <summary>
        /// 客户归属
        /// </summary>
        public System.String AccountBelong { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public System.String Password { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public System.String UserIcon { get; set; }

        /// <summary>
        /// 性别 1男，2女
        /// </summary>
        public System.Int32? Sex { get; set; }

        /// <summary>
        /// 注册IP
        /// </summary>
        public System.String RegIP { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        public System.Decimal? Integral { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public System.DateTime? RegTime { get; set; }

        /// <summary>
        /// 最后登录IP
        /// </summary>
        public System.String LastIP { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public System.DateTime? LastTime { get; set; }

        /// <summary>
        /// 登录凭证
        /// </summary>
        public System.String Token { get; set; }

        /// <summary>
        /// 状态 0正常 1已禁用
        /// </summary>
        public System.Int32? Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public System.String Notes { get; set; }

        /// <summary>
        /// 微信OpenId
        /// </summary>
        public System.String WxOpenId { get; set; }

        /// <summary>
        /// 微信Unid
        /// </summary>
        public System.String WxUnid { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public System.Int32? Source { get; set; }

        /// <summary>
        /// 是否允许登录 0正常 1禁止登录
        /// </summary>
        public System.Int32 AllowLogin { get; set; }

        /// <summary>
        /// 产品权限
        /// </summary>
        public System.String ProAuth { get; set; }
    }
}
