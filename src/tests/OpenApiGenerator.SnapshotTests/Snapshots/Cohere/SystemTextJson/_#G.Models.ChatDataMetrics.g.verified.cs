//HintName: G.Models.ChatDataMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatDataMetrics
    {
        /// <summary>
        /// The sum of all turns of valid train examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_train_turns")]
        public double NumTrainTurns { get; set; }

        /// <summary>
        /// The sum of all turns of valid eval examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_eval_turns")]
        public double NumEvalTurns { get; set; }

        /// <summary>
        /// The preamble of this dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preamble")]
        public string? Preamble { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}