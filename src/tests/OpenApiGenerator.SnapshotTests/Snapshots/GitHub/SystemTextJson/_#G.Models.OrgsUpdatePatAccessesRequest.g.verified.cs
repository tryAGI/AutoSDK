//HintName: G.Models.OrgsUpdatePatAccessesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdatePatAccessesRequest
    {
        /// <summary>
        /// Action to apply to the fine-grained personal access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OrgsUpdatePatAccessesRequestActionJsonConverter))]
        public global::G.OrgsUpdatePatAccessesRequestAction Action { get; set; }

        /// <summary>
        /// The IDs of the fine-grained personal access tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pat_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> PatIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}