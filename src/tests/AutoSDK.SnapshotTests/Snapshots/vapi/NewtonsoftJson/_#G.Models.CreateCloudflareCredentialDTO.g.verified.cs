//HintName: G.Models.CreateCloudflareCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCloudflareCredentialDTO
    {
        /// <summary>
        /// Credential provider. Only allowed value is cloudflare
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateCloudflareCredentialDTOProviderJsonConverter))]
        public global::G.CreateCloudflareCredentialDTOProvider Provider { get; set; }

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
        /// This is the bucket plan that can be provided to store call artifacts in R2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketPlan")]
        public global::G.CloudflareR2BucketPlan? BucketPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateCloudflareCredentialDTO" /> class.
        /// </summary>
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
        /// <param name="bucketPlan">
        /// This is the bucket plan that can be provided to store call artifacts in R2
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateCloudflareCredentialDTO(
            global::G.CreateCloudflareCredentialDTOProvider provider,
            string? accountId,
            string? apiKey,
            string? accountEmail,
            double? fallbackIndex,
            global::G.CloudflareR2BucketPlan? bucketPlan,
            string? name)
        {
            this.Provider = provider;
            this.AccountId = accountId;
            this.ApiKey = apiKey;
            this.AccountEmail = accountEmail;
            this.FallbackIndex = fallbackIndex;
            this.BucketPlan = bucketPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudflareCredentialDTO" /> class.
        /// </summary>
        public CreateCloudflareCredentialDTO()
        {
        }
    }
}