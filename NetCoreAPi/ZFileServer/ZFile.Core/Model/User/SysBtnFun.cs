﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
namespace ZFile.Core.Model.User
{

    /// <summary>
    /// 权限-菜单对应的功能列表
    /// </summary>
    [SugarTable("Sys_BtnFun")]
    public class SysBtnFun
    {
        /// <summary>
        /// 必须填写
        /// </summary>
        [Required()]
        [StringLength(50)]
        [SugarColumn(IsPrimaryKey = true)]
        public string Guid { get; set; }


        /// <summary>
        /// 归属菜单功能
        /// </summary>
        [Required()]
        [StringLength(50)]
        public string MenuGuid { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required()]
        [StringLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// 菜单功能类型
        /// </summary>
        [Required()]
        [StringLength(20)]
        public string FunType { get; set; }

        /// <summary>
        /// 描述，可为空
        /// </summary>
        public string Summary { get; set; }
    }
}
