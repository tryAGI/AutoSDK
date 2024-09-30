//HintName: G.Models.ListApiKeysResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListApiKeysResponse
    {
        /// <summary>
        /// List of API keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public global::System.Collections.Generic.IList<global::G.ApiKey>? ApiKeys { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}