//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaultValue")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="defaultValue"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem(
            string key,
            string type,
            string? defaultValue)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.DefaultValue = defaultValue;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem()
        {
        }
    }
}