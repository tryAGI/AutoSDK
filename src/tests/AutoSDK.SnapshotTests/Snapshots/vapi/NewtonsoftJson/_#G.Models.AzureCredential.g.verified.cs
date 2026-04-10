//HintName: G.Models.AzureCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureCredential
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureCredentialProviderJsonConverter))]
        public global::G.AzureCredentialProvider Provider { get; set; }

        /// <summary>
        /// This is the service being used in Azure.<br/>
        /// Default Value: speech
        /// </summary>
        /// <default>global::G.AzureCredentialService.Speech</default>
        [global::Newtonsoft.Json.JsonProperty("service", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureCredentialServiceJsonConverter))]
        public global::G.AzureCredentialService Service { get; set; } = default!;

        /// <summary>
        /// This is the region of the Azure resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AzureCredentialRegionJsonConverter))]
        public global::G.AzureCredentialRegion? Region { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey")]
        public string? ApiKey { get; set; }

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
        /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketPlan")]
        public global::G.AzureBlobStorageBucketPlan? BucketPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCredential" /> class.
        /// </summary>
        /// <param name="service">
        /// This is the service being used in Azure.<br/>
        /// Default Value: speech
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
        /// <param name="region">
        /// This is the region of the Azure resource.
        /// </param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="bucketPlan">
        /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
        /// </param>
        public AzureCredential(
            global::G.AzureCredentialService service,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.AzureCredentialProvider provider,
            global::G.AzureCredentialRegion? region,
            string? apiKey,
            double? fallbackIndex,
            string? name,
            global::G.AzureBlobStorageBucketPlan? bucketPlan)
        {
            this.Provider = provider;
            this.Service = service;
            this.Region = region;
            this.ApiKey = apiKey;
            this.FallbackIndex = fallbackIndex;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.BucketPlan = bucketPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCredential" /> class.
        /// </summary>
        public AzureCredential()
        {
        }
    }
}