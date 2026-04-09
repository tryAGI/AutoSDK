//HintName: G.Models.CloudflareCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudflareCredential
    {
        /// <summary>
        /// Credential provider. Only allowed value is cloudflare
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CloudflareCredentialProviderJsonConverter))]
        public global::G.CloudflareCredentialProvider Provider { get; set; }

        /// <summary>
        /// Cloudflare Account Id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Cloudflare API Key / Token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Cloudflare Account Email.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountEmail")]
        public string? AccountEmail { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackIndex")]
        public double? FallbackIndex { get; set; }

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
        /// This is the bucket plan that can be provided to store call artifacts in R2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketPlan")]
        public global::G.CloudflareR2BucketPlan? BucketPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudflareCredential" /> class.
        /// </summary>
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
        /// <param name="provider">
        /// Credential provider. Only allowed value is cloudflare
        /// </param>
        /// <param name="accountId">
        /// Cloudflare Account Id.
        /// </param>
        /// <param name="apiKey">
        /// Cloudflare API Key / Token.
        /// </param>
        /// <param name="accountEmail">
        /// Cloudflare Account Email.
        /// </param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="bucketPlan">
        /// This is the bucket plan that can be provided to store call artifacts in R2
        /// </param>
        public CloudflareCredential(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.CloudflareCredentialProvider provider,
            string? accountId,
            string? apiKey,
            string? accountEmail,
            double? fallbackIndex,
            string? name,
            global::G.CloudflareR2BucketPlan? bucketPlan)
        {
            this.Provider = provider;
            this.AccountId = accountId;
            this.ApiKey = apiKey;
            this.AccountEmail = accountEmail;
            this.FallbackIndex = fallbackIndex;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.BucketPlan = bucketPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudflareCredential" /> class.
        /// </summary>
        public CloudflareCredential()
        {
        }
    }
}