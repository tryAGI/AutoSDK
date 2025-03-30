//HintName: G.Models.FactualConsistencyScoreSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The factual consistency of the generation.
    /// </summary>
    public sealed partial class FactualConsistencyScoreSpan
    {
        /// <summary>
        /// This value is always `fcs`.
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
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualConsistencyScoreSpan" /> class.
        /// </summary>
        /// <param name="type">
        /// This value is always `fcs`.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// When the span started.
        /// </param>
        /// <param name="score">
        /// The probability that the summary is factually consistent with the results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FactualConsistencyScoreSpan(
            string? type,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            float? score)
        {
            this.Type = type;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactualConsistencyScoreSpan" /> class.
        /// </summary>
        public FactualConsistencyScoreSpan()
        {
        }
    }
}