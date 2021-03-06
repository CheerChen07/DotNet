﻿//-----------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2012 , Hairihan TECH, Ltd. 
//-----------------------------------------------------------------

namespace DotNet.Utilities.Information
{
    /// <summary>
    /// BaseSystemInfo
    /// 这是系统的核心基础信息部分
    /// 
    /// 修改记录
    ///		2012.04.14 版本：1.0 JiRiGaLa	主键创建。
    ///		
    /// 版本：1.0
    /// 
    /// <author>
    ///		<name>JiRiGaLa</name>
    ///		<date>2012.04.14</date>
    /// </author>
    /// </summary>
    public partial class BaseSystemInfo
    {
        /// <summary>
        /// 是否启用表格数据权限
        /// 启用分级管理范围权限设置，启用逐级授权
        /// </summary>
        public static bool UsePermissionScope = false;

        /// <summary>
        /// 启用授权范围（逐级授权）
        /// </summary>
        public static bool UseAuthorizationScope = false;

        /// <summary>
        /// 启用按用户权限
        /// </summary>
        public static bool UseUserPermission = true;

        /// <summary>
        /// 启用按组织机构权限
        /// </summary>
        public static bool UseOrganizePermission = false;

        /// <summary>
        /// 启用模块菜单权限
        /// </summary>
        public static bool UseModulePermission = false;

        /// <summary>
        /// 启用操作权限
        /// </summary>
        public static bool UsePermissionItem = false;

        /// <summary>
        /// 启用行政审批流程管理
        /// </summary>
        public static bool UseWorkFlow = true;

        /// <summary>
        /// 启用数据表的约束条件限制
        /// </summary>
        public static bool UseTableScopePermission = false;

        /// <summary>
        /// 启用数据表的列权限
        /// </summary>
        public static bool UseTableColumnPermission = true;

        /// <summary>
        /// 设置手写签名
        /// </summary>
        public static bool HandwrittenSignature = true;

        /// <summary>
        /// 登录历史纪录
        /// </summary>
        public static bool RecordLogOnLog = true;

        /// <summary>
        /// 是否进行日志记录
        /// </summary>
        public static bool RecordLog = true;

        /// <summary>
        /// 是否更新访问日期信息
        /// </summary>
        public static bool UpdateVisit = true;

        /// <summary>
        /// 同时在线用户数量限制
        /// </summary>
        public static int OnLineLimit = 0;

        /// <summary>
        /// 是否检查用户IP地址
        /// </summary>
        public static bool CheckIPAddress = false;

        /// <summary>
        /// 是否登记异常
        /// </summary>
        public static bool LogException = true;

        /// <summary>
        /// 是否登记数据库操作
        /// </summary>
        public static bool LogSQL = false;

        /// <summary>
        /// 是否登记到 Windows 系统异常中
        /// </summary>
        public static bool EventLog = false;
    }
}