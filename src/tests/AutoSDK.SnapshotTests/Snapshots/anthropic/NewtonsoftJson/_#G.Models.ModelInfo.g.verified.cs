//HintName: G.Models.ModelInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// Object type.<br/>
        /// For Models, this is always `"model"`.<br/>
        /// Default Value: model
        /// </summary>
        /// <default>global::G.ModelInfoType.Model</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ModelInfoType Type { get; set; } = global::G.ModelInfoType.Model;

        /// <summary>
        /// Unique model identifier.<br/>
        /// Example: claude-3-5-sonnet-20241022
        /// </summary>
        /// <example>claude-3-5-sonnet-20241022</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A human-readable name for the model.<br/>
        /// Example: Claude 3.5 Sonnet (New)
        /// </summary>
        /// <example>Claude 3.5 Sonnet (New)</example>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the model was released. May be set to an epoch value if the release date is unknown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="type">
        /// Object type.<br/>
        /// For Models, this is always `"model"`.<br/>
        /// Default Value: model
        /// </param>
        /// <param name="id">
        /// Unique model identifier.<br/>
        /// Example: claude-3-5-sonnet-20241022
        /// </param>
        /// <param name="displayName">
        /// A human-readable name for the model.<br/>
        /// Example: Claude 3.5 Sonnet (New)
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string representing the time at which the model was released. May be set to an epoch value if the release date is unknown.
        /// </param>
        public ModelInfo(
            string id,
            string displayName,
            global::System.DateTime createdAt,
            global::G.ModelInfoType type = global::G.ModelInfoType.Model)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.CreatedAt = createdAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}