//HintName: G.Models.PluginInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PluginInfo
    {
        /// <summary>
        /// 插件包含的api列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_info_list")]
        public global::System.Collections.Generic.IList<global::G.ApiInfo>? ApiInfoList { get; set; }

        /// <summary>
        /// 插件描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 插件图片url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plugin_id")]
        public string? PluginId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginInfo" /> class.
        /// </summary>
        /// <param name="apiInfoList">
        /// 插件包含的api列表
        /// </param>
        /// <param name="description">
        /// 插件描述
        /// </param>
        /// <param name="iconUrl">
        /// 插件图片url
        /// </param>
        /// <param name="name">
        /// 插件名称
        /// </param>
        /// <param name="pluginId">
        /// 插件id
        /// </param>
        public PluginInfo(
            global::System.Collections.Generic.IList<global::G.ApiInfo>? apiInfoList,
            string? description,
            string? iconUrl,
            string? name,
            string? pluginId)
        {
            this.ApiInfoList = apiInfoList;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Name = name;
            this.PluginId = pluginId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginInfo" /> class.
        /// </summary>
        public PluginInfo()
        {
        }
    }
}