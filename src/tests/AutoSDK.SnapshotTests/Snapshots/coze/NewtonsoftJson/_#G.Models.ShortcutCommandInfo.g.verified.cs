//HintName: G.Models.ShortcutCommandInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShortcutCommandInfo
    {
        /// <summary>
        /// multi的指令时，该指令由哪个节点执行 没配置不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 快捷指令
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("command")]
        public string? Command { get; set; }

        /// <summary>
        /// 组件列表（参数列表）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("components")]
        public global::System.Collections.Generic.IList<global::G.ShortcutCommandComponent>? Components { get; set; }

        /// <summary>
        /// 快捷指令描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 快捷指令icon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 快捷指令id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 快捷指令按钮名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 指令query模版
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_template")]
        public string? QueryTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool")]
        public global::G.ShortcutCommandToolInfo? Tool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandInfo" /> class.
        /// </summary>
        /// <param name="agentId">
        /// multi的指令时，该指令由哪个节点执行 没配置不返回
        /// </param>
        /// <param name="command">
        /// 快捷指令
        /// </param>
        /// <param name="components">
        /// 组件列表（参数列表）
        /// </param>
        /// <param name="description">
        /// 快捷指令描述
        /// </param>
        /// <param name="iconUrl">
        /// 快捷指令icon
        /// </param>
        /// <param name="id">
        /// 快捷指令id
        /// </param>
        /// <param name="name">
        /// 快捷指令按钮名称
        /// </param>
        /// <param name="queryTemplate">
        /// 指令query模版
        /// </param>
        /// <param name="tool"></param>
        public ShortcutCommandInfo(
            string? agentId,
            string? command,
            global::System.Collections.Generic.IList<global::G.ShortcutCommandComponent>? components,
            string? description,
            string? iconUrl,
            string? id,
            string? name,
            string? queryTemplate,
            global::G.ShortcutCommandToolInfo? tool)
        {
            this.AgentId = agentId;
            this.Command = command;
            this.Components = components;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.Name = name;
            this.QueryTemplate = queryTemplate;
            this.Tool = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandInfo" /> class.
        /// </summary>
        public ShortcutCommandInfo()
        {
        }
    }
}