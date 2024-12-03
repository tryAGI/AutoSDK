//HintName: G.Models.BatchIngestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Batch ingest config.
    /// </summary>
    public sealed partial class BatchIngestConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_multipart_endpoint")]
        public bool? UseMultipartEndpoint { get; set; }

        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_qsize_trigger")]
        public int? ScaleUpQsizeTrigger { get; set; }

        /// <summary>
        /// Default Value: 16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_nthreads_limit")]
        public int? ScaleUpNthreadsLimit { get; set; }

        /// <summary>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_nempty_trigger")]
        public int? ScaleDownNemptyTrigger { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_limit")]
        public int? SizeLimit { get; set; }

        /// <summary>
        /// Default Value: 20971520
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_limit_bytes")]
        public int? SizeLimitBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchIngestConfig" /> class.
        /// </summary>
        /// <param name="useMultipartEndpoint">
        /// Default Value: true
        /// </param>
        /// <param name="scaleUpQsizeTrigger">
        /// Default Value: 1000
        /// </param>
        /// <param name="scaleUpNthreadsLimit">
        /// Default Value: 16
        /// </param>
        /// <param name="scaleDownNemptyTrigger">
        /// Default Value: 4
        /// </param>
        /// <param name="sizeLimit">
        /// Default Value: 100
        /// </param>
        /// <param name="sizeLimitBytes">
        /// Default Value: 20971520
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchIngestConfig(
            bool? useMultipartEndpoint,
            int? scaleUpQsizeTrigger,
            int? scaleUpNthreadsLimit,
            int? scaleDownNemptyTrigger,
            int? sizeLimit,
            int? sizeLimitBytes)
        {
            this.UseMultipartEndpoint = useMultipartEndpoint;
            this.ScaleUpQsizeTrigger = scaleUpQsizeTrigger;
            this.ScaleUpNthreadsLimit = scaleUpNthreadsLimit;
            this.ScaleDownNemptyTrigger = scaleDownNemptyTrigger;
            this.SizeLimit = sizeLimit;
            this.SizeLimitBytes = sizeLimitBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchIngestConfig" /> class.
        /// </summary>
        public BatchIngestConfig()
        {
        }
    }
}