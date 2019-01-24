﻿/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：导航加载视图                                                    
*│　作    者：yilezhu                                             
*│　版    本：1.0                                                 
*│　创建时间：2019/1/23 22:25:37                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Czar.Cms.ViewModels.Menu                                   
*│　类    名： MenuNavView                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Czar.Cms.ViewModels.Menu
{
    public class MenuNavView
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string href { get; set; }
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool spread { get; set; }
        /// <summary>
        /// 是否新开窗口
        /// </summary>
        public string target { get; set; }
    }
}
