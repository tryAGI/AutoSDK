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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdatedAt { get; set; }

        /// <summary>
        /// Config object of the most recent prompt version that matches the filters (if any are provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object LastConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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