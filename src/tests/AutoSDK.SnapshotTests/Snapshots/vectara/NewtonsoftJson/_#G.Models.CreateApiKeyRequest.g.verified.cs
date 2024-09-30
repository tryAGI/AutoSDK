//HintName: G.Models.CreateApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// The human-readable name of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Role of the API key. <br/>
        /// A serving API key can only perform query type requests on its corpora. A serving and<br/>
        /// indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiKeyRole ApiKeyRole { get; set; } = default!;

        /// <summary>
        /// Corpora this API key has roles on if it is not a Personal API key.<br/>
        /// This property should be null or missing if this `api_key_role` is<br/>
        /// `personal`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpus_keys")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}