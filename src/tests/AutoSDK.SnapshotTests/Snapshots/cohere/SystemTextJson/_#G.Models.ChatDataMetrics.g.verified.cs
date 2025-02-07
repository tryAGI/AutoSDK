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
        public double? NumTrainTurns { get; set; }

        /// <summary>
        /// The sum of all turns of valid eval examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_eval_turns")]
        public double? NumEvalTurns { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDataMetrics" /> class.
        /// </summary>
        /// <param name="numTrainTurns">
        /// The sum of all turns of valid train examples.
        /// </param>
        /// <param name="numEvalTurns">
        /// The sum of all turns of valid eval examples.
        /// </param>
        /// <param name="preamble">
        /// The preamble of this dataset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDataMetrics(
            double? numTrainTurns,
            double? numEvalTurns,
            string? preamble)
        {
            this.NumTrainTurns = numTrainTurns;
            this.NumEvalTurns = numEvalTurns;
            this.Preamble = preamble;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDataMetrics" /> class.
        /// </summary>
        public ChatDataMetrics()
        {
        }
    }
}