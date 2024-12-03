//HintName: G.Models.RerankerDataMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankerDataMetrics
    {
        /// <summary>
        /// The number of training queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_train_queries")]
        public double? NumTrainQueries { get; set; }

        /// <summary>
        /// The sum of all relevant passages of valid training examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_train_relevant_passages")]
        public double? NumTrainRelevantPassages { get; set; }

        /// <summary>
        /// The sum of all hard negatives of valid training examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_train_hard_negatives")]
        public double? NumTrainHardNegatives { get; set; }

        /// <summary>
        /// The number of evaluation queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_eval_queries")]
        public double? NumEvalQueries { get; set; }

        /// <summary>
        /// The sum of all relevant passages of valid eval examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_eval_relevant_passages")]
        public double? NumEvalRelevantPassages { get; set; }

        /// <summary>
        /// The sum of all hard negatives of valid eval examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_eval_hard_negatives")]
        public double? NumEvalHardNegatives { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerDataMetrics" /> class.
        /// </summary>
        /// <param name="numTrainQueries">
        /// The number of training queries.
        /// </param>
        /// <param name="numTrainRelevantPassages">
        /// The sum of all relevant passages of valid training examples.
        /// </param>
        /// <param name="numTrainHardNegatives">
        /// The sum of all hard negatives of valid training examples.
        /// </param>
        /// <param name="numEvalQueries">
        /// The number of evaluation queries.
        /// </param>
        /// <param name="numEvalRelevantPassages">
        /// The sum of all relevant passages of valid eval examples.
        /// </param>
        /// <param name="numEvalHardNegatives">
        /// The sum of all hard negatives of valid eval examples.
        /// </param>
        public RerankerDataMetrics(
            double? numTrainQueries,
            double? numTrainRelevantPassages,
            double? numTrainHardNegatives,
            double? numEvalQueries,
            double? numEvalRelevantPassages,
            double? numEvalHardNegatives)
        {
            this.NumTrainQueries = numTrainQueries;
            this.NumTrainRelevantPassages = numTrainRelevantPassages;
            this.NumTrainHardNegatives = numTrainHardNegatives;
            this.NumEvalQueries = numEvalQueries;
            this.NumEvalRelevantPassages = numEvalRelevantPassages;
            this.NumEvalHardNegatives = numEvalHardNegatives;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerDataMetrics" /> class.
        /// </summary>
        public RerankerDataMetrics()
        {
        }
    }
}