﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EM.Common
{
 
    /// <summary>
    /// 学校类别
    /// </summary>
    public enum SchoolType
    {
        [Description("综合")]
        A = 1,
        [Description("理工")]
        B,
        [Description("财经")]
        C,
        [Description("师范")]
        D,
        [Description("语言")]
        E,
        [Description("政法")]
        F,
        [Description("民族")]
        G,
        [Description("农林")]
        H,
        [Description("医药")]
        I,
        [Description("艺术")]
        J,
        [Description("体育")]
        K,
        [Description("军事")]
        L
    }

    #region 系统（账号，权限）
    /// <summary>
    /// 账号状态枚举
    /// </summary>
    public enum AccountStatus
    {
        [Description("正常")]
        Allow = 1,
        [Description("禁止")]
        Deny,
    }

    /// <summary>
    /// 权限类型枚举
    /// </summary>
    public enum RightType
    {
        [Description("查询")]
        View = 1,
        [Description("增删改")]
        Form,
    }

    /// <summary>
    /// 权限所属系统枚举
    /// </summary>
    public enum SystemType
    {
        [Description("浙江报销系统")]
        ZJ = 1,
        [Description("易捷报销系统")]
        YJ,
        [Description("共用作业")]
        All,
    }

    public enum CateTypeEnum
    {
       [Description("无")]
        None=0,
        [Description("有关绩效")]
        KPIAbout,
        [Description("年度额度")]
        YearlyLimit,
        [Description("季度额度")]
        SeasonlyLimit,
        [Description("其他")]
        Other
    }
    

    //额度季节
    public enum SeasonTypeEnum
    {
        [Description("全年")]
        FullYear=0,
       [Description("第一季度")]
        Spring,
       [Description("第二季度")]
       Summer,
       [Description("第三季度")]
       Autumn,
       [Description("第四季度")]
        Winter
    }

    public enum ExpenseAccountDateType
    {
        [Description("单据日期")]
        OccurDate,
        [Description("录入日期")]
        ApplyDate,
        [Description("创建日期")]
        CreateDate,
        [Description("更新日期")]
        ModifyDate,
        [Description("通过日期")]
        ApproveDate 
    }

    public enum ExpenseAccountFileStatus
    {
        [Description("无关联")]//说明新增之后还没刷新报销单号的
        NoRelated = 1,
        [Description("正常")]
        Default = 2,
        [Description("已删除")]
        Deleted
    }

    public enum ExpenseAccountApproveStatus
    {
        [Description("草稿箱")]
        Created = 1,
        [Description("待确认")]
        WaitingApprove ,
        [Description("退回")]
        FailApproved,
        [Description("已确认")]
        PassApproved,

    }
    /// <summary>
    /// 角色分类-表示操作的是老板，录入员，还是系统管理员,仅分类不一样
    /// </summary>
    public enum RoleType
    {

        [Description("系统管理员")]
        Admin=0,
        [Description("公司总经理")]
        CompanyManager,
        [Description("分公司录入员")]
        Staff,
        [Description("区域录入员")]
        Area,
        [Description("业绩录入员")]
        Performance
    }
    /// <summary>
    /// 分类列表的使用来源
    /// </summary>
    public enum CateDropType
    {
        [Description("查询下拉，包含子类和父类")]
        Search=1,
        [Description("表单下拉，仅包含子类")]
        Form,
        [Description("报表汇总，仅包含父类")]
        Report
    }
    /// <summary>
    /// 分类列表的使用来源
    /// </summary>
    public enum CompanyType
    {
        [Description("区域")]
        Area = 1,
        [Description("城市公司")]
        City,
        [Description("分公司")]
        Other,
        [Description("所有分公司")]
        All
    }


    /// <summary>
    /// 列表类型
    /// </summary>
    public enum ExcelRowType
    {
        H1 = 1,
        H2,
        H3,
        B1,
        //数字格式
        D2
    }
    /// <summary>
    /// FeedBack优先级
    /// </summary>
    public enum FeedBackPriority
    {
        L0,
        L1,
        L2,
        L3,
        L4,
        L5,
    }
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageType
    {
        [Description("提示信息")]
        Alert = 1,
        [Description("系统通知")]
        Notification,
    }

    #endregion


    public enum SelectType
    {
        [Description("用户下拉")]
        User,   
        [Description("分类下拉")]
        Cate,
        [Description("公司下拉")]
        Company,
        [Description("季度下拉")]
        Season,
        
    }

    /// <summary>
    /// 用来前端显示信息状态
    /// </summary>
    public enum AlertedStstusType
    {
        [Description("已发送")]
        Alerted,
        [Description("待发送")]
        Waiting,

    }


    public enum SystemMessageDateTimeType
    {
        [Description("创建日期")]
        CreateDate,
        [Description("发送日期")]
        AlertedDate,
        [Description("提醒日期")]
        AlertDate,
    }

    /// <summary>
    /// 数据查看权限
    /// </summary>
    public enum RoleViewRightType
    {
        [Description("查看自己创建的")]
        Owner,
        [Description("查看自己创建的和同一公司的")]
        OwnerAndCompany,
        [Description("查看所有数据")]
        All=99,
    }



}
