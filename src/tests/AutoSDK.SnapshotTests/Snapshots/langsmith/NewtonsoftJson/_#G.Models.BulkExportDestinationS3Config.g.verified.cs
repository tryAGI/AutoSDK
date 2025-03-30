//HintName: G.Models.BulkExportDestinationS3Config.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportDestinationS3Config
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket_name")]
        public string? BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Config" /> class.
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="prefix"></param>
        /// <param name="bucketName"></param>
        /// <param name="region"></param>
        public BulkExportDestinationS3Config(
            string? endpointUrl,
            string? prefix,
            string? bucketName,
            string? region)
        {
            this.EndpointUrl = endpointUrl;
            this.Prefix = prefix;
            this.BucketName = bucketName;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Config" /> class.
        /// </summary>
        public BulkExportDestinationS3Config()
        {
        }
    }
}