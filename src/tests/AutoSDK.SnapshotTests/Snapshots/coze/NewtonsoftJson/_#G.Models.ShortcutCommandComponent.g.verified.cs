//HintName: G.Models.ShortcutCommandComponent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShortcutCommandComponent
    {
        /// <summary>
        /// 默认值 没配置时不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 是否隐藏不展示 线上bot tool类型的快捷指令不返回hide=true的component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_hide")]
        public bool? IsHide { get; set; }

        /// <summary>
        /// panel参数参数名字
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// type为select时的可选项列表 or type为file时，支持哪些类型 image、doc、table、audio、video、zip、code、txt、ppt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// 请求工具时，参数的key 对应tool的参数名称，没有则为不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_parameter")]
        public string? ToolParameter { get; set; }

        /// <summary>
        /// 输入类型 text、select、file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandComponent" /> class.
        /// </summary>
        /// <param name="defaultValue">
        /// 默认值 没配置时不返回
        /// </param>
        /// <param name="description">
        /// 参数描述
        /// </param>
        /// <param name="isHide">
        /// 是否隐藏不展示 线上bot tool类型的快捷指令不返回hide=true的component
        /// </param>
        /// <param name="name">
        /// panel参数参数名字
        /// </param>
        /// <param name="options">
        /// type为select时的可选项列表 or type为file时，支持哪些类型 image、doc、table、audio、video、zip、code、txt、ppt
        /// </param>
        /// <param name="toolParameter">
        /// 请求工具时，参数的key 对应tool的参数名称，没有则为不返回
        /// </param>
        /// <param name="type">
        /// 输入类型 text、select、file
        /// </param>
        public ShortcutCommandComponent(
            string? defaultValue,
            string? description,
            bool? isHide,
            string? name,
            global::System.Collections.Generic.IList<string>? options,
            string? toolParameter,
            string? type)
        {
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.IsHide = isHide;
            this.Name = name;
            this.Options = options;
            this.ToolParameter = toolParameter;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandComponent" /> class.
        /// </summary>
        public ShortcutCommandComponent()
        {
        }
    }
}