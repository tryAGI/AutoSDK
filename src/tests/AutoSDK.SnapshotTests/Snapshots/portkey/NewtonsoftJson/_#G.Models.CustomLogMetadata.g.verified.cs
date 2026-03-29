//HintName: G.Models.CustomLogMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLogMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_name")]
        public string? SpanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additionalProperties")]
        public string? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLogMetadata" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="spanName"></param>
        /// <param name="additionalProperties"></param>
        public CustomLogMetadata(
            string? traceId,
            string? spanId,
            string? spanName,
            string? additionalProperties)
        {
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.SpanName = spanName;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLogMetadata" /> class.
        /// </summary>
        public CustomLogMetadata()
        {
        }
    }
}