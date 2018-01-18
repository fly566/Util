﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Forms.Configs;
using Util.Ui.Material.Forms.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Forms.TagHelpers {
    /// <summary>
    /// 单选框
    /// </summary>
    [HtmlTargetElement( "util-radio" )]
    public class RadioTagHelper : TagHelperBase {
        /// <summary>
        /// 标识，指向模板引用变量，而不是Id属性
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 控件的名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否垂直布局
        /// </summary>
        public bool Vertical { get; set; }
        /// <summary>
        /// 是否显示标签
        /// </summary>
        public bool ShowLabel { get; set; }
        /// <summary>
        /// 标签文本
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// 标签位置
        /// </summary>
        public LabelPosition Position { get; set; }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 数据源
        /// </summary>
        public string DatasSource { get; set; }
        /// <summary>
        /// 禁用
        /// </summary>
        public string Disabled { get; set; }
        /// <summary>
        /// 模型绑定
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public bool Required { get; set; }
        /// <summary>
        /// 变更事件处理函数,范例：handle()
        /// </summary>
        public string OnChange { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new RadioRender( new SelectConfig( context ) );
        }
    }
}