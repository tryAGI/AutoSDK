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
        public static global::G.RerankerDataMetrics? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RerankerDataMetrics>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RerankerDataMetrics?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RerankerDataMetrics?>(serializer.Deserialize<global::G.RerankerDataMetrics>(jsonReader));
        }

    }
}