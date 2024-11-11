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
        [global::Newtonsoft.Json.JsonProperty("trainable_token_count")]
        public double? TrainableTokenCount { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FinetuneDatasetMetrics? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FinetuneDatasetMetrics>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.FinetuneDatasetMetrics?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.FinetuneDatasetMetrics?>(serializer.Deserialize<global::G.FinetuneDatasetMetrics>(jsonReader));
        }

    }
}