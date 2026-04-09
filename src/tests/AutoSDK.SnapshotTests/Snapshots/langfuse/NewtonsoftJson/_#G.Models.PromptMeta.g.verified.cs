//HintName: G.Models.PromptMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptTypeJsonConverter))]
        public global::G.PromptType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Versions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUpdatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdatedAt { get; set; } = default!;

        /// <summary>
        /// Config object of the most recent prompt version that matches the filters (if any are provided)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public object LastConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMeta" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="versions"></param>
        /// <param name="labels"></param>
        /// <param name="tags"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="lastConfig">
        /// Config object of the most recent prompt version that matches the filters (if any are provided)
        /// </param>
        public PromptMeta(
            string name,
            global::G.PromptType type,
            global::System.Collections.Generic.IList<int> versions,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<string> tags,
            global::System.DateTime lastUpdatedAt,
            object lastConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastConfig = lastConfig ?? throw new global::System.ArgumentNullException(nameof(lastConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMeta" /> class.
        /// </summary>
        public PromptMeta()
        {
        }
    }
}