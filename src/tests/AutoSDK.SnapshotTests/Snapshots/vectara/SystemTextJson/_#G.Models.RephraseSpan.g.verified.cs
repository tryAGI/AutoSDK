//HintName: G.Models.RephraseSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// During the query pipeline, the query may be rephrased to better suit the corpus.
    /// </summary>
    public sealed partial class RephraseSpan
    {
        /// <summary>
        /// This value is always `rephrase`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Time taken in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// When the span started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Query made to the corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rephrased_query")]
        public string? RephrasedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseSpan" /> class.
        /// </summary>
        /// <param name="type">
        /// This value is always `rephrase`.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// When the span started.
        /// </param>
        /// <param name="rephrasedQuery">
        /// Query made to the corpora.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RephraseSpan(
            string? type,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            string? rephrasedQuery)
        {
            this.Type = type;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.RephrasedQuery = rephrasedQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseSpan" /> class.
        /// </summary>
        public RephraseSpan()
        {
        }
    }
}