//HintName: G.Models.ApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// The ID of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The human-readable name of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The key used in API requests. The key should be kept secure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// If this API key is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Role of the API key. <br/>
        /// A serving API key can only perform query type requests on its corpora. A serving and<br/>
        /// indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_role")]
        public global::G.ApiKeyRole? ApiKeyRole { get; set; }

        /// <summary>
        /// What actions a principal can take on the Vectara platform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_policy")]
        public global::G.ApiPolicy? ApiPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}