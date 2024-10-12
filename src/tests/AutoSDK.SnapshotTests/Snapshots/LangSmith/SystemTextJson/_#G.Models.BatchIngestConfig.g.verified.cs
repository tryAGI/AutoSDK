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
        public bool? UseMultipartEndpoint { get; set; } = true;

        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_qsize_trigger")]
        public int? ScaleUpQsizeTrigger { get; set; } = 1000;

        /// <summary>
        /// Default Value: 16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_nthreads_limit")]
        public int? ScaleUpNthreadsLimit { get; set; } = 16;

        /// <summary>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_nempty_trigger")]
        public int? ScaleDownNemptyTrigger { get; set; } = 4;

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_limit")]
        public int? SizeLimit { get; set; } = 100;

        /// <summary>
        /// Default Value: 20971520
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_limit_bytes")]
        public int? SizeLimitBytes { get; set; } = 20971520;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}