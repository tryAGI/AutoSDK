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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_info_list")]
        public global::System.Collections.Generic.IList<global::G.ApiInfo>? ApiInfoList { get; set; }

        /// <summary>
        /// 插件描述
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 插件图片url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        public string? PluginId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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