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
        [global::Newtonsoft.Json.JsonProperty("api_keys")]
        public global::System.Collections.Generic.IList<global::G.ApiKey>? ApiKeys { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponse" /> class.
        /// </summary>
        /// <param name="apiKeys">
        /// List of API keys.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        public ListApiKeysResponse(
            global::System.Collections.Generic.IList<global::G.ApiKey>? apiKeys,
            global::G.ListMetadata? metadata)
        {
            this.ApiKeys = apiKeys;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponse" /> class.
        /// </summary>
        public ListApiKeysResponse()
        {
        }
    }
}