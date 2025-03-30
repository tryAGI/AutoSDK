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
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string? BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Config" /> class.
        /// </summary>
        /// <param name="endpointUrl"></param>
        /// <param name="prefix"></param>
        /// <param name="bucketName"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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