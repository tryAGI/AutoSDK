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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_data_metrics")]
        public global::G.ChatDataMetrics? ChatDataMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classify_data_metrics")]
        public global::G.ClassifyDataMetrics? ClassifyDataMetrics { get; set; }

        /// <summary>
        /// Number of evaluation examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_examples")]
        public double? EvalExamples { get; set; }

        /// <summary>
        /// The size in bytes of all eval examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_size_bytes")]
        public double? EvalSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reranker_data_metrics")]
        public global::G.RerankerDataMetrics? RerankerDataMetrics { get; set; }

        /// <summary>
        /// The overall number of examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_examples")]
        public double? TotalExamples { get; set; }

        /// <summary>
        /// The number of training examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_examples")]
        public double? TrainExamples { get; set; }

        /// <summary>
        /// The size in bytes of all training examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_size_bytes")]
        public double? TrainSizeBytes { get; set; }

        /// <summary>
        /// The number of tokens of valid examples that can be used for training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainable_token_count")]
        public double? TrainableTokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDatasetMetrics" /> class.
        /// </summary>
        /// <param name="chatDataMetrics"></param>
        /// <param name="classifyDataMetrics"></param>
        /// <param name="evalExamples">
        /// Number of evaluation examples.
        /// </param>
        /// <param name="evalSizeBytes">
        /// The size in bytes of all eval examples.
        /// </param>
        /// <param name="rerankerDataMetrics"></param>
        /// <param name="totalExamples">
        /// The overall number of examples.
        /// </param>
        /// <param name="trainExamples">
        /// The number of training examples.
        /// </param>
        /// <param name="trainSizeBytes">
        /// The size in bytes of all training examples.
        /// </param>
        /// <param name="trainableTokenCount">
        /// The number of tokens of valid examples that can be used for training.
        /// </param>
        public FinetuneDatasetMetrics(
            global::G.ChatDataMetrics? chatDataMetrics,
            global::G.ClassifyDataMetrics? classifyDataMetrics,
            double? evalExamples,
            double? evalSizeBytes,
            global::G.RerankerDataMetrics? rerankerDataMetrics,
            double? totalExamples,
            double? trainExamples,
            double? trainSizeBytes,
            double? trainableTokenCount)
        {
            this.ChatDataMetrics = chatDataMetrics;
            this.ClassifyDataMetrics = classifyDataMetrics;
            this.EvalExamples = evalExamples;
            this.EvalSizeBytes = evalSizeBytes;
            this.RerankerDataMetrics = rerankerDataMetrics;
            this.TotalExamples = totalExamples;
            this.TrainExamples = trainExamples;
            this.TrainSizeBytes = trainSizeBytes;
            this.TrainableTokenCount = trainableTokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDatasetMetrics" /> class.
        /// </summary>
        public FinetuneDatasetMetrics()
        {
        }
    }
}