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


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
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

    }
}