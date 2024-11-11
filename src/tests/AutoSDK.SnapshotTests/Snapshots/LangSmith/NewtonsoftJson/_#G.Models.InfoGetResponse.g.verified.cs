//HintName: G.Models.InfoGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The LangSmith server info.
    /// </summary>
    public sealed partial class InfoGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license_expiration_time")]
        public global::System.DateTime? LicenseExpirationTime { get; set; }

        /// <summary>
        /// Batch ingest config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_ingest_config")]
        public global::G.BatchIngestConfig? BatchIngestConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instance_flags")]
        public object? InstanceFlags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoGetResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="licenseExpirationTime"></param>
        /// <param name="batchIngestConfig">
        /// Batch ingest config.
        /// </param>
        /// <param name="instanceFlags"></param>
        public InfoGetResponse(
            string version,
            global::System.DateTime? licenseExpirationTime,
            global::G.BatchIngestConfig? batchIngestConfig,
            object? instanceFlags)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.LicenseExpirationTime = licenseExpirationTime;
            this.BatchIngestConfig = batchIngestConfig;
            this.InstanceFlags = instanceFlags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoGetResponse" /> class.
        /// </summary>
        public InfoGetResponse()
        {
        }
    }
}