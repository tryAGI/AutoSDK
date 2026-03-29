//HintName: G.Models.VonageCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VonageCredential
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vonageApplicationPrivateKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VonageApplicationPrivateKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VonageCredentialProviderJsonConverter))]
        public global::G.VonageCredentialProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiSecret { get; set; }

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
        /// This is the Vonage Application ID for the credential.<br/>
        /// Only relevant for Vonage credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vonageApplicationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VonageApplicationId { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VonageCredential" /> class.
        /// </summary>
        /// <param name="vonageApplicationPrivateKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiSecret">
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
        /// <param name="vonageApplicationId">
        /// This is the Vonage Application ID for the credential.<br/>
        /// Only relevant for Vonage credentials.
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VonageCredential(
            string vonageApplicationPrivateKey,
            string apiSecret,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string vonageApplicationId,
            string apiKey,
            global::G.VonageCredentialProvider provider,
            string? name)
        {
            this.VonageApplicationPrivateKey = vonageApplicationPrivateKey ?? throw new global::System.ArgumentNullException(nameof(vonageApplicationPrivateKey));
            this.Provider = provider;
            this.ApiSecret = apiSecret ?? throw new global::System.ArgumentNullException(nameof(apiSecret));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.VonageApplicationId = vonageApplicationId ?? throw new global::System.ArgumentNullException(nameof(vonageApplicationId));
            this.Name = name;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VonageCredential" /> class.
        /// </summary>
        public VonageCredential()
        {
        }
    }
}