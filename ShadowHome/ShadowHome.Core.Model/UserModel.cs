using SqlSugar;
using System;

namespace ShadowHome.Core.Model
{
    /// <summary>
    /// 孕检_操作日志
    ///</summary>
    [SugarTable("YJ_QX_CHUSHENGQXZD")]
    public class YJ_QX_CHUSHENGQXZDModel
    {
        /// <summary>
        /// ID主键 
        ///</summary>
        [SugarColumn(ColumnName = "ID", IsPrimaryKey = true)]
        public string Id { get; set; }
        /// <summary>
        /// 租户ID 
        ///</summary>
        [SugarColumn(ColumnName = "ZUHUID")]
        public string Zuhuid { get; set; }
        /// <summary>
        /// 租户名称 
        ///</summary>
        [SugarColumn(ColumnName = "ZUHUMC")]
        public string Zuhumc { get; set; }
        /// <summary>
        /// 组织机构ID 
        ///</summary>
        [SugarColumn(ColumnName = "ZUZHIJGID")]
        public string Zuzhijgid { get; set; }
        /// <summary>
        /// 组织机构名称 
        ///</summary>
        [SugarColumn(ColumnName = "ZUZHIJGMC")]
        public string Zuzhijgmc { get; set; }
        /// <summary>
        /// 家庭档案Id 
        ///</summary>
        [SugarColumn(ColumnName = "JIATINGDAID")]
        public string Jiatingdaid { get; set; }
        /// <summary>
        /// 出生缺陷ID 
        ///</summary>
        [SugarColumn(ColumnName = "CHUSHENGQXID")]
        public string Chushengqxid { get; set; }
        /// <summary>
        /// 无脑畸形（Q00）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "WUNAOJX")]
        public string Wunaojx { get; set; }
        /// <summary>
        /// 脊柱裂（Q05） 
        ///</summary>
        [SugarColumn(ColumnName = "JIZHULIE")]
        public string Jizhulie { get; set; }
        /// <summary>
        /// 脑膨出（Q01）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "NAOPENGCHU")]
        public string Naopengchu { get; set; }
        /// <summary>
        /// 先天性脑积水（Q03）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "XIANTIANXNJS")]
        public string Xiantianxnjs { get; set; }
        /// <summary>
        /// 腭裂（Q35）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "ELIE")]
        public string Elie { get; set; }
        /// <summary>
        /// 唇裂[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "CHUNLIE")]
        public string Chunlie { get; set; }
        /// <summary>
        /// 唇裂合并腭裂（Q37）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "CHUNLIEHBEL")]
        public string Chunliehbel { get; set; }
        /// <summary>
        /// 小耳（包括无耳）（Q17.2,Q16.0）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "XIAOE")]
        public string Xiaoe { get; set; }
        /// <summary>
        /// 外耳其他畸形(小耳、无耳除外)(Q17)[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "WAIEQTJX")]
        public string Waieqtjx { get; set; }
        /// <summary>
        /// 食道闭锁或狭窄（Q39）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "SHIDAOBSHXZ")]
        public string Shidaobshxz { get; set; }
        /// <summary>
        /// 直肠肛门闭锁或狭窄（包括无肛）（Q42）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "ZHICHANGGMBSHXZ")]
        public string Zhichanggmbshxz { get; set; }
        /// <summary>
        /// 尿道下裂（Q54）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "NIAODAOXL")]
        public string Niaodaoxl { get; set; }
        /// <summary>
        /// 膀胱外翻（Q64.1）[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "PANGGUANGWF")]
        public string Pangguangwf { get; set; }
        /// <summary>
        /// 马蹄内翻足[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "MATINFZ")]
        public string Matinfz { get; set; }
        /// <summary>
        /// 马蹄内翻足（Q66.0）[YJ0082](多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "MATINFZDM")]
        public string Matinfzdm { get; set; }
        /// <summary>
        /// 马蹄内翻足名称（Q66.0）(多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "MATINFZMC")]
        public string Matinfzmc { get; set; }
        /// <summary>
        /// 多趾[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "DUOZHI")]
        public string Duozhi { get; set; }
        /// <summary>
        /// ?多指(趾)代码（Q69）[YJ0083](多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "DUOZHIZDM")]
        public string Duozhizdm { get; set; }
        /// <summary>
        /// ?多指(趾)名称 (多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "DUOZHIZMC")]
        public string Duozhizmc { get; set; }
        /// <summary>
        /// 并趾[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "BINGZHI")]
        public string Bingzhi { get; set; }
        /// <summary>
        /// 并指(趾)代码（Q70）[YJ0083](多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "BINGZHIZDM")]
        public string Bingzhizdm { get; set; }
        /// <summary>
        /// 并指(趾)名称（Q70） (多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "BINGZHIZMC")]
        public string Bingzhizmc { get; set; }
        /// <summary>
        /// 肢体短缩[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "ZHITIDS")]
        public string Zhitids { get; set; }
        /// <summary>
        /// 肢体短缩上肢代码[YJ0082](多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "ZHITIDSSZDM")]
        public string Zhitidsszdm { get; set; }
        /// <summary>
        /// 肢体短缩上肢名称(多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "ZHITIDSSZMC")]
        public string Zhitidsszmc { get; set; }
        /// <summary>
        /// 肢体短缩下肢代码[YJ0082](多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "ZHITIDSXZDM")]
        public string Zhitidsxzdm { get; set; }
        /// <summary>
        /// 肢体短缩下肢名称(多个‘|’隔开) 
        ///</summary>
        [SugarColumn(ColumnName = "ZHITIDSXZMC")]
        public string Zhitidsxzmc { get; set; }
        /// <summary>
        /// 先天性膈疝（Q79.0） 
        ///</summary>
        [SugarColumn(ColumnName = "XIANTIANXGS")]
        public string Xiantianxgs { get; set; }
        /// <summary>
        /// 脐膨出（Q79.2） 
        ///</summary>
        [SugarColumn(ColumnName = "QIPENGCHU")]
        public string Qipengchu { get; set; }
        /// <summary>
        /// 腹裂（Q79.3） 
        ///</summary>
        [SugarColumn(ColumnName = "FULIE")]
        public string Fulie { get; set; }
        /// <summary>
        /// 联体双胎（Q89.4） 
        ///</summary>
        [SugarColumn(ColumnName = "LIANTIST")]
        public string Liantist { get; set; }
        /// <summary>
        /// 唐氏综合症（21-三体综合症） 
        ///</summary>
        [SugarColumn(ColumnName = "TANGSHIZHZ")]
        public string Tangshizhz { get; set; }
        /// <summary>
        /// 先天性心脏病 
        ///</summary>
        [SugarColumn(ColumnName = "XIANTIANXXZB")]
        public string Xiantianxxzb { get; set; }
        /// <summary>
        /// 先天性心脏病描述 
        ///</summary>
        [SugarColumn(ColumnName = "XIANTIANXXZBMS")]
        public string Xiantianxxzbms { get; set; }
        /// <summary>
        /// 其他[YJ0004]（1:有,2:无） 
        ///</summary>
        [SugarColumn(ColumnName = "QITA")]
        public string Qita { get; set; }
        /// <summary>
        /// 诊断其他 
        ///</summary>
        [SugarColumn(ColumnName = "ZHENDUANQT")]
        public string Zhenduanqt { get; set; }
        /// <summary>
        /// 诊断描述 
        ///</summary>
        [SugarColumn(ColumnName = "ZHENDUANMS")]
        public string Zhenduanms { get; set; }
        /// <summary>
        /// 创建人ID 
        ///</summary>
        [SugarColumn(ColumnName = "CHUANGJIANRID")]
        public string Chuangjianrid { get; set; }
        /// <summary>
        /// 创建人姓名 
        ///</summary>
        [SugarColumn(ColumnName = "CHUANGJIANRXM")]
        public string Chuangjianrxm { get; set; }
        /// <summary>
        /// 创建系统ID 
        ///</summary>
        [SugarColumn(ColumnName = "CHUANGJIANXTID")]
        public string Chuangjianxtid { get; set; }
        /// <summary>
        /// 创建时间 
        ///</summary>
        [SugarColumn(ColumnName = "CHUANGJIANSJ")]
        public DateTime Chuangjiansj { get; set; }
        /// <summary>
        /// 修改人ID 
        ///</summary>
        [SugarColumn(ColumnName = "XIUGAIRID")]
        public string Xiugairid { get; set; }
        /// <summary>
        /// 修改人姓名 
        ///</summary>
        [SugarColumn(ColumnName = "XIUGAIRXM")]
        public string Xiugairxm { get; set; }
        /// <summary>
        /// 修改系统ID 
        ///</summary>
        [SugarColumn(ColumnName = "XIUGAIXTID")]
        public string Xiugaixtid { get; set; }
        /// <summary>
        /// 修改时间 
        ///</summary>
        [SugarColumn(ColumnName = "XIUGAISJ")]
        public DateTime Xiugaisj { get; set; }
        /// <summary>
        /// 作废标志 
        ///</summary>
        [SugarColumn(ColumnName = "ZUOFEIBZ")]
        public short Zuofeibz { get; set; }
        /// <summary>
        /// 数据来源[YJ0084] 
        ///</summary>
        [SugarColumn(ColumnName = "SHUJULY")]
        public string Shujuly { get; set; }
    }
}

