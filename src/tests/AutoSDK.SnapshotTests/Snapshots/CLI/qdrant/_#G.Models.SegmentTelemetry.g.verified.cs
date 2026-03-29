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
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SegmentInfo Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SegmentConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_index_searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VectorIndexSearchesTelemetry> VectorIndexSearches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_field_indices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PayloadIndexTelemetry> PayloadFieldIndices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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