//HintName: G.Models.CreateAzureCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAzureCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAzureCredentialDTOProviderJsonConverter))]
        public global::G.CreateAzureCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the service being used in Azure.<br/>
        /// Default Value: speech
        /// </summary>
        /// <default>global::G.CreateAzureCredentialDTOService.Speech</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAzureCredentialDTOServiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAzureCredentialDTOService Service { get; set; } = global::G.CreateAzureCredentialDTOService.Speech;

        /// <summary>
        /// This is the region of the Azure resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAzureCredentialDTORegionJsonConverter))]
        public global::G.CreateAzureCredentialDTORegion? Region { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketPlan")]
        public global::G.AzureBlobStorageBucketPlan? BucketPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateAzureCredentialDTO" /> class.
        /// </summary>
        /// <param name="service">
        /// This is the service being used in Azure.<br/>
        /// Default Value: speech
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
        /// <param name="bucketPlan">
        /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAzureCredentialDTO(
            global::G.CreateAzureCredentialDTOService service,
            global::G.CreateAzureCredentialDTOProvider provider,
            global::G.CreateAzureCredentialDTORegion? region,
            string? apiKey,
            double? fallbackIndex,
            global::G.AzureBlobStorageBucketPlan? bucketPlan,
            string? name)
        {
            this.Provider = provider;
            this.Service = service;
            this.Region = region;
            this.ApiKey = apiKey;
            this.FallbackIndex = fallbackIndex;
            this.BucketPlan = bucketPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAzureCredentialDTO" /> class.
        /// </summary>
        public CreateAzureCredentialDTO()
        {
        }
    }
}