//HintName: G.Models.UpdateApiKeyObjectDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateApiKeyObjectDefaults
    {
        /// <summary>
        /// Example: {"environment":"development","team":"backend"}
        /// </summary>
        /// <example>{"environment":"development","team":"backend"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Example: config-abc
        /// </summary>
        /// <example>config-abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObjectDefaults" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Example: {"environment":"development","team":"backend"}
        /// </param>
        /// <param name="configId">
        /// Example: config-abc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyObjectDefaults(
            object? metadata,
            string? configId)
        {
            this.Metadata = metadata;
            this.ConfigId = configId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyObjectDefaults" /> class.
        /// </summary>
        public UpdateApiKeyObjectDefaults()
        {
        }
    }
}