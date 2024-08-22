//HintName: G.Models.UpsertOrgOrWorkspaceTTLSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base upsert TTL settings model.
    /// </summary>
    public sealed partial class UpsertOrgOrWorkspaceTTLSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_trace_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.TraceTier3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TraceTier3 DefaultTraceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}