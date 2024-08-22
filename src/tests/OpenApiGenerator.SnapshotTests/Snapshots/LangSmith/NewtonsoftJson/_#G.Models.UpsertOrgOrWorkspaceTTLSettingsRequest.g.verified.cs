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
        [global::Newtonsoft.Json.JsonProperty("default_trace_tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TraceTier3 DefaultTraceTier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}