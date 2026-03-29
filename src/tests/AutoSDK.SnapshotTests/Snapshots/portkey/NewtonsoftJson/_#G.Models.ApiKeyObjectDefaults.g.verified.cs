//HintName: G.Models.ApiKeyObjectDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyObjectDefaults
    {
        /// <summary>
        /// Example: {"environment":"development","team":"backend"}
        /// </summary>
        /// <example>{"environment":"development","team":"backend"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Example: config-abc
        /// </summary>
        /// <example>config-abc</example>
        [global::Newtonsoft.Json.JsonProperty("config_id")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyObjectDefaults" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Example: {"environment":"development","team":"backend"}
        /// </param>
        /// <param name="configId">
        /// Example: config-abc
        /// </param>
        public ApiKeyObjectDefaults(
            object? metadata,
            string? configId)
        {
            this.Metadata = metadata;
            this.ConfigId = configId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyObjectDefaults" /> class.
        /// </summary>
        public ApiKeyObjectDefaults()
        {
        }
    }
}