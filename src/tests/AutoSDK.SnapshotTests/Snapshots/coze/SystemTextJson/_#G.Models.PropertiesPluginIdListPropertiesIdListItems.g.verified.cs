//HintName: G.Models.PropertiesPluginIdListPropertiesIdListItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesPluginIdListPropertiesIdListItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PluginId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPluginIdListPropertiesIdListItems" /> class.
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="pluginId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesPluginIdListPropertiesIdListItems(
            string apiId,
            string pluginId)
        {
            this.ApiId = apiId ?? throw new global::System.ArgumentNullException(nameof(apiId));
            this.PluginId = pluginId ?? throw new global::System.ArgumentNullException(nameof(pluginId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPluginIdListPropertiesIdListItems" /> class.
        /// </summary>
        public PropertiesPluginIdListPropertiesIdListItems()
        {
        }
    }
}