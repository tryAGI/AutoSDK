//HintName: G.Models.TuningSnapshot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Record for a single tuning step.
    /// </summary>
    public sealed partial class TuningSnapshot
    {
        /// <summary>
        /// Output only. The tuning step.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public int? Step { get; set; }

        /// <summary>
        /// Output only. The timestamp when this metric was computed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computeTime")]
        public string? ComputeTime { get; set; }

        /// <summary>
        /// Output only. The epoch this step was part of.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epoch")]
        public int? Epoch { get; set; }

        /// <summary>
        /// Output only. The mean loss of the training examples for this step.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meanLoss")]
        public float? MeanLoss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}