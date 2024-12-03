//HintName: G.Models.FinetuneDatasetMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneDatasetMetrics
    {
        /// <summary>
        /// The number of tokens of valid examples that can be used for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainable_token_count")]
        public double? TrainableTokenCount { get; set; }

        /// <summary>
        /// The overall number of examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_examples")]
        public double? TotalExamples { get; set; }

        /// <summary>
        /// The number of training examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_examples")]
        public double? TrainExamples { get; set; }

        /// <summary>
        /// The size in bytes of all training examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_size_bytes")]
        public double? TrainSizeBytes { get; set; }

        /// <summary>
        /// Number of evaluation examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_examples")]
        public double? EvalExamples { get; set; }

        /// <summary>
        /// The size in bytes of all eval examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_size_bytes")]
        public double? EvalSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker_data_metrics")]
        public global::G.RerankerDataMetrics? RerankerDataMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_data_metrics")]
        public global::G.ChatDataMetrics? ChatDataMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classify_data_metrics")]
        public global::G.ClassifyDataMetrics? ClassifyDataMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDatasetMetrics" /> class.
        /// </summary>
        /// <param name="trainableTokenCount">
        /// The number of tokens of valid examples that can be used for training.
        /// </param>
        /// <param name="totalExamples">
        /// The overall number of examples.
        /// </param>
        /// <param name="trainExamples">
        /// The number of training examples.
        /// </param>
        /// <param name="trainSizeBytes">
        /// The size in bytes of all training examples.
        /// </param>
        /// <param name="evalExamples">
        /// Number of evaluation examples.
        /// </param>
        /// <param name="evalSizeBytes">
        /// The size in bytes of all eval examples.
        /// </param>
        /// <param name="rerankerDataMetrics"></param>
        /// <param name="chatDataMetrics"></param>
        /// <param name="classifyDataMetrics"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FinetuneDatasetMetrics(
            double? trainableTokenCount,
            double? totalExamples,
            double? trainExamples,
            double? trainSizeBytes,
            double? evalExamples,
            double? evalSizeBytes,
            global::G.RerankerDataMetrics? rerankerDataMetrics,
            global::G.ChatDataMetrics? chatDataMetrics,
            global::G.ClassifyDataMetrics? classifyDataMetrics)
        {
            this.TrainableTokenCount = trainableTokenCount;
            this.TotalExamples = totalExamples;
            this.TrainExamples = trainExamples;
            this.TrainSizeBytes = trainSizeBytes;
            this.EvalExamples = evalExamples;
            this.EvalSizeBytes = evalSizeBytes;
            this.RerankerDataMetrics = rerankerDataMetrics;
            this.ChatDataMetrics = chatDataMetrics;
            this.ClassifyDataMetrics = classifyDataMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDatasetMetrics" /> class.
        /// </summary>
        public FinetuneDatasetMetrics()
        {
        }
    }
}