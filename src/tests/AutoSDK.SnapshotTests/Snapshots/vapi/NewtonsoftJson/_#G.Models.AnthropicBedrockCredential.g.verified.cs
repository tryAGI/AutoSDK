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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.AnthropicBedrockCredentialProvider Provider { get; set; }

        /// <summary>
        /// AWS region where Bedrock is configured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnthropicBedrockCredentialRegion Region { get; set; } = default!;

        /// <summary>
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationPlan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan> AuthenticationPlan { get; set; } = default!;

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
        /// Stores the external ID (generated or user-provided) for future AssumeRole calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationArtifact")]
        public global::G.AWSStsAuthenticationArtifact? AuthenticationArtifact { get; set; }

        /// <summary>
        /// Cached authentication session from AssumeRole (temporary credentials).<br/>
        /// Managed by the system, auto-refreshed when expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationSession")]
        public global::G.AWSStsAuthenticationSession? AuthenticationSession { get; set; }

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