//HintName: G.Models.LangfuseCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LangfuseCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LangfuseCredentialProviderJsonConverter))]
        public global::G.LangfuseCredentialProvider Provider { get; set; }

        /// <summary>
        /// The public key for Langfuse project. Eg: pk-lf-...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; } = default!;

        /// <summary>
        /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiUrl { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseCredential" /> class.
        /// </summary>
        /// <param name="publicKey">
        /// The public key for Langfuse project. Eg: pk-lf-...
        /// </param>
        /// <param name="apiKey">
        /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
        /// </param>
        /// <param name="apiUrl">
        /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public LangfuseCredential(
            string publicKey,
            string apiKey,
            string apiUrl,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.LangfuseCredentialProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseCredential" /> class.
        /// </summary>
        public LangfuseCredential()
        {
        }
    }
}