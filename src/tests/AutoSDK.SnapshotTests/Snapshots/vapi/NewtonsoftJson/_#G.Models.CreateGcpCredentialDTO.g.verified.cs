//HintName: G.Models.CreateGcpCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGcpCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateGcpCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.<br/>
        /// The schema is identical to the JSON that GCP outputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gcpKey", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GcpKey GcpKey { get; set; } = default!;

        /// <summary>
        /// This is the region of the GCP resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucketPlan")]
        public global::G.BucketPlan? BucketPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateGcpCredentialDTO" /> class.
        /// </summary>
        /// <param name="gcpKey">
        /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.<br/>
        /// The schema is identical to the JSON that GCP outputs.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="region">
        /// This is the region of the GCP resource.
        /// </param>
        /// <param name="bucketPlan"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateGcpCredentialDTO(
            global::G.GcpKey gcpKey,
            global::G.CreateGcpCredentialDTOProvider provider,
            double? fallbackIndex,
            string? region,
            global::G.BucketPlan? bucketPlan,
            string? name)
        {
            this.Provider = provider;
            this.FallbackIndex = fallbackIndex;
            this.GcpKey = gcpKey ?? throw new global::System.ArgumentNullException(nameof(gcpKey));
            this.Region = region;
            this.BucketPlan = bucketPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGcpCredentialDTO" /> class.
        /// </summary>
        public CreateGcpCredentialDTO()
        {
        }
    }
}