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
        /// The sum of all turns of valid eval examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_eval_turns")]
        public double? NumEvalTurns { get; set; }

        /// <summary>
        /// The sum of all turns of valid train examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_train_turns")]
        public double? NumTrainTurns { get; set; }

        /// <summary>
        /// The preamble of this dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preamble")]
        public string? Preamble { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDataMetrics" /> class.
        /// </summary>
        /// <param name="numEvalTurns">
        /// The sum of all turns of valid eval examples.
        /// </param>
        /// <param name="numTrainTurns">
        /// The sum of all turns of valid train examples.
        /// </param>
        /// <param name="preamble">
        /// The preamble of this dataset.
        /// </param>
        public ChatDataMetrics(
            double? numEvalTurns,
            double? numTrainTurns,
            string? preamble)
        {
            this.NumEvalTurns = numEvalTurns;
            this.NumTrainTurns = numTrainTurns;
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