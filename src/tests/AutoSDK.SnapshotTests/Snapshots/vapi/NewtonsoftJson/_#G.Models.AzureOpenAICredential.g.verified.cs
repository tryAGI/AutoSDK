//HintName: G.Models.AzureOpenAICredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureOpenAICredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.AzureOpenAICredentialProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AzureOpenAICredentialRegion Region { get; set; } = default!;

        /// <summary>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AzureOpenAICredentialModel> Models { get; set; } = default!;

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAIKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string OpenAIKey { get; set; } = default!;

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ocpApimSubscriptionKey")]
        public string? OcpApimSubscriptionKey { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAIEndpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string OpenAIEndpoint { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAICredential" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="models">
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </param>
        /// <param name="openAIKey">
        /// This is not returned in the API.
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
        /// <param name="openAIEndpoint"></param>
        /// <param name="provider"></param>
        /// <param name="ocpApimSubscriptionKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public AzureOpenAICredential(
            global::G.AzureOpenAICredentialRegion region,
            global::System.Collections.Generic.IList<global::G.AzureOpenAICredentialModel> models,
            string openAIKey,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string openAIEndpoint,
            global::G.AzureOpenAICredentialProvider provider,
            string? ocpApimSubscriptionKey,
            string? name)
        {
            this.Provider = provider;
            this.Region = region;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.OpenAIKey = openAIKey ?? throw new global::System.ArgumentNullException(nameof(openAIKey));
            this.OcpApimSubscriptionKey = ocpApimSubscriptionKey;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.OpenAIEndpoint = openAIEndpoint ?? throw new global::System.ArgumentNullException(nameof(openAIEndpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAICredential" /> class.
        /// </summary>
        public AzureOpenAICredential()
        {
        }
    }
}