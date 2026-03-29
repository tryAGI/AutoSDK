//HintName: G.Models.CustomCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomCredentialProviderJsonConverter))]
        public global::G.CustomCredentialProvider Provider { get; set; }

        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthenticationPlan5JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthenticationPlan5 AuthenticationPlan { get; set; }

        /// <summary>
        /// This is the encryption plan for encrypting sensitive data. Currently supports public-key encryption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptionPlan")]
        public global::G.PublicKeyEncryptionPlan? EncryptionPlan { get; set; }

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
        /// This is the authentication session for the credential. Available for credentials that have an authentication plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSession")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Oauth2AuthenticationSession AuthenticationSession { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCredential" /> class.
        /// </summary>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
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
        /// <param name="authenticationSession">
        /// This is the authentication session for the credential. Available for credentials that have an authentication plan.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="encryptionPlan">
        /// This is the encryption plan for encrypting sensitive data. Currently supports public-key encryption.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomCredential(
            global::G.AuthenticationPlan5 authenticationPlan,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.Oauth2AuthenticationSession authenticationSession,
            global::G.CustomCredentialProvider provider,
            global::G.PublicKeyEncryptionPlan? encryptionPlan,
            string? name)
        {
            this.Provider = provider;
            this.AuthenticationPlan = authenticationPlan;
            this.EncryptionPlan = encryptionPlan;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthenticationSession = authenticationSession ?? throw new global::System.ArgumentNullException(nameof(authenticationSession));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCredential" /> class.
        /// </summary>
        public CustomCredential()
        {
        }
    }
}