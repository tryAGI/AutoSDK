//HintName: G.Models.UpdateGcpCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGcpCredentialDTO
    {
        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.<br/>
        /// The schema is identical to the JSON that GCP outputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gcpKey")]
        public global::G.GcpKey? GcpKey { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGcpCredentialDTO" /> class.
        /// </summary>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="gcpKey">
        /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.<br/>
        /// The schema is identical to the JSON that GCP outputs.
        /// </param>
        /// <param name="region">
        /// This is the region of the GCP resource.
        /// </param>
        /// <param name="bucketPlan"></param>
        public UpdateGcpCredentialDTO(
            double? fallbackIndex,
            string? name,
            global::G.GcpKey? gcpKey,
            string? region,
            global::G.BucketPlan? bucketPlan)
        {
            this.FallbackIndex = fallbackIndex;
            this.Name = name;
            this.GcpKey = gcpKey;
            this.Region = region;
            this.BucketPlan = bucketPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGcpCredentialDTO" /> class.
        /// </summary>
        public UpdateGcpCredentialDTO()
        {
        }
    }
}