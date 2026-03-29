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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureOpenAICredentialProviderJsonConverter))]
        public global::G.AzureOpenAICredentialProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AzureOpenAICredentialRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AzureOpenAICredentialRegion Region { get; set; }

        /// <summary>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AzureOpenAICredentialModel> Models { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openAIKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenAIKey { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocpApimSubscriptionKey")]
        public string? OcpApimSubscriptionKey { get; set; }

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openAIEndpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenAIEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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