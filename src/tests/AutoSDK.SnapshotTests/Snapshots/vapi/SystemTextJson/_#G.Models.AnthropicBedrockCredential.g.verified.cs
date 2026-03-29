//HintName: G.Models.AnthropicBedrockCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicBedrockCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnthropicBedrockCredentialProviderJsonConverter))]
        public global::G.AnthropicBedrockCredentialProvider Provider { get; set; }

        /// <summary>
        /// AWS region where Bedrock is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnthropicBedrockCredentialRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnthropicBedrockCredentialRegion Region { get; set; }

        /// <summary>
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan> AuthenticationPlan { get; set; }

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
        /// Stores the external ID (generated or user-provided) for future AssumeRole calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationArtifact")]
        public global::G.AWSStsAuthenticationArtifact? AuthenticationArtifact { get; set; }

        /// <summary>
        /// Cached authentication session from AssumeRole (temporary credentials).<br/>
        /// Managed by the system, auto-refreshed when expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSession")]
        public global::G.AWSStsAuthenticationSession? AuthenticationSession { get; set; }

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
        /// Initializes a new instance of the <see cref="AnthropicBedrockCredential" /> class.
        /// </summary>
        /// <param name="region">
        /// AWS region where Bedrock is configured.
        /// </param>
        /// <param name="authenticationPlan">
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
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
        /// <param name="authenticationArtifact">
        /// Stores the external ID (generated or user-provided) for future AssumeRole calls.
        /// </param>
        /// <param name="authenticationSession">
        /// Cached authentication session from AssumeRole (temporary credentials).<br/>
        /// Managed by the system, auto-refreshed when expired.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicBedrockCredential(
            global::G.AnthropicBedrockCredentialRegion region,
            global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan> authenticationPlan,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.AnthropicBedrockCredentialProvider provider,
            global::G.AWSStsAuthenticationArtifact? authenticationArtifact,
            global::G.AWSStsAuthenticationSession? authenticationSession,
            string? name)
        {
            this.Provider = provider;
            this.Region = region;
            this.AuthenticationPlan = authenticationPlan;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthenticationArtifact = authenticationArtifact;
            this.AuthenticationSession = authenticationSession;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBedrockCredential" /> class.
        /// </summary>
        public AnthropicBedrockCredential()
        {
        }
    }
}