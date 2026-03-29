//HintName: G.Models.SegmentTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentTelemetry
    {
        /// <summary>
        /// Aggregated information about segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SegmentInfo Info { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SegmentConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_index_searches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VectorIndexSearchesTelemetry> VectorIndexSearches { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload_field_indices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PayloadIndexTelemetry> PayloadFieldIndices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentTelemetry" /> class.
        /// </summary>
        /// <param name="info">
        /// Aggregated information about segment
        /// </param>
        /// <param name="config"></param>
        /// <param name="vectorIndexSearches"></param>
        /// <param name="payloadFieldIndices"></param>
        public SegmentTelemetry(
            global::G.SegmentInfo info,
            global::G.SegmentConfig config,
            global::System.Collections.Generic.IList<global::G.VectorIndexSearchesTelemetry> vectorIndexSearches,
            global::System.Collections.Generic.IList<global::G.PayloadIndexTelemetry> payloadFieldIndices)
        {
            this.Info = info ?? throw new global::System.ArgumentNullException(nameof(info));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.VectorIndexSearches = vectorIndexSearches ?? throw new global::System.ArgumentNullException(nameof(vectorIndexSearches));
            this.PayloadFieldIndices = payloadFieldIndices ?? throw new global::System.ArgumentNullException(nameof(payloadFieldIndices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentTelemetry" /> class.
        /// </summary>
        public SegmentTelemetry()
        {
        }
    }
}