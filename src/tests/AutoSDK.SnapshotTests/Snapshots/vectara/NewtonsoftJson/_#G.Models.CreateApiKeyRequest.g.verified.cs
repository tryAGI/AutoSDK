//HintName: G.Models.CreateApiKeyRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new API key for authenticating with the platform.
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// The human-readable name of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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
        public global::G.ApiKeyRole? ApiKeyRole { get; set; }

        /// <summary>
        /// Deprecated: Use corpus_roles instead. Corpora this API key has roles on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corpus_keys")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? CorpusKeys { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of the API key.
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
        public CreateApiKeyRequest(
            string name,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::G.ApiKeyRole? apiKeyRole,
            global::System.Collections.Generic.IList<global::G.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::G.AgentRole>? agentRoles)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiRoles = apiRoles;
            this.ApiKeyRole = apiKeyRole;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }
    }
}