//HintName: G.Models.ApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An API key used to authenticate and authorize requests to the Vectara platform.
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
        /// Customer-level roles for this API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiKeyRoleJsonConverter))]
        public global::G.ApiKeyRole? ApiKeyRole { get; set; }

        /// <summary>
        /// Corpus-specific role assignments for this API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpus_roles")]
        public global::System.Collections.Generic.IList<global::G.CorpusRole>? CorpusRoles { get; set; }

        /// <summary>
        /// Agent-specific role assignments for this API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_roles")]
        public global::System.Collections.Generic.IList<global::G.AgentRole>? AgentRoles { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the API key.
        /// </param>
        /// <param name="name">
        /// The human-readable name of the API key.
        /// </param>
        /// <param name="secretKey">
        /// The key used in API requests. The key should be kept secure.
        /// </param>
        /// <param name="enabled">
        /// If this API key is enabled.
        /// </param>
        /// <param name="apiRoles">
        /// Customer-level roles for this API key.
        /// </param>
        /// <param name="apiKeyRole">
        /// Role of the API key. A serving API key can only perform query type requests on its corpora. A serving and indexing key can perform both indexing and query type requests on its corpora.<br/>
        /// A personal API key has all the same permissions as the creator of the API key.
        /// </param>
        /// <param name="corpusRoles">
        /// Corpus-specific role assignments for this API key.
        /// </param>
        /// <param name="agentRoles">
        /// Agent-specific role assignments for this API key.
        /// </param>
        /// <param name="apiPolicy">
        /// What actions a principal can take on the Vectara platform.
        /// </param>
        public ApiKey(
            string? id,
            string? name,
            string? secretKey,
            bool? enabled,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::G.ApiKeyRole? apiKeyRole,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles,
            global::G.ApiPolicy? apiPolicy)
        {
            this.Id = id;
            this.Name = name;
            this.SecretKey = secretKey;
            this.Enabled = enabled;
            this.ApiRoles = apiRoles;
            this.ApiKeyRole = apiKeyRole;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
            this.ApiPolicy = apiPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }
    }
}