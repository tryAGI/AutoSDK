//HintName: G.Models.GenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
    /// </summary>
    public sealed partial class GenerationConfig
    {
        /// <summary>
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned from the `getModel` function. Values can range from [0.0, infinity).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Optional. The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a stop sequence. The stop sequence will not be included as part of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Note: The default value varies by model, see the `Model.top_k` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and nucleus sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits number of tokens based on the cumulative probability. Note: The default value varies by model, see the `Model.top_p` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Optional. Number of generated responses to return. Currently, this value can only be set to 1. If unset, this will default to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidateCount")]
        public int? CandidateCount { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to include in a candidate. Note: The default value varies by model, see the `Model.output_token_limit` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.GenerationConfig? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GenerationConfig),
                jsonSerializerContext) as global::G.GenerationConfig;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GenerationConfig? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GenerationConfig>(
                json,
                jsonSerializerOptions);
        }

    }
}