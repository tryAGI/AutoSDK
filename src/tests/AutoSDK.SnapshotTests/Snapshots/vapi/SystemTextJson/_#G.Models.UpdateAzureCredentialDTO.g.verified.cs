//HintName: G.Models.UpdateAzureCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAzureCredentialDTO
    {
        /// <summary>
        /// This is the service being used in Azure.<br/>
        /// Default Value: speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateAzureCredentialDTOServiceJsonConverter))]
        public global::G.UpdateAzureCredentialDTOService? Service { get; set; }

        /// <summary>
        /// This is the region of the Azure resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateAzureCredentialDTORegionJsonConverter))]
        public global::G.UpdateAzureCredentialDTORegion? Region { get; set; }

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
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketPlan")]
        public global::G.AzureBlobStorageBucketPlan? BucketPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureCredentialDTO" /> class.
        /// </summary>
        /// <param name="service">
        /// This is the service being used in Azure.<br/>
        /// Default Value: speech
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAzureCredentialDTO(
            global::G.UpdateAzureCredentialDTOService? service,
            global::G.UpdateAzureCredentialDTORegion? region,
            string? apiKey,
            double? fallbackIndex,
            string? name,
            global::G.AzureBlobStorageBucketPlan? bucketPlan)
        {
            this.Service = service;
            this.Region = region;
            this.ApiKey = apiKey;
            this.FallbackIndex = fallbackIndex;
            this.Name = name;
            this.BucketPlan = bucketPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureCredentialDTO" /> class.
        /// </summary>
        public UpdateAzureCredentialDTO()
        {
        }
    }
}