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
        [global::Newtonsoft.Json.JsonProperty("api_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plugin_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PluginId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPluginIdListPropertiesIdListItems" /> class.
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="pluginId"></param>
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