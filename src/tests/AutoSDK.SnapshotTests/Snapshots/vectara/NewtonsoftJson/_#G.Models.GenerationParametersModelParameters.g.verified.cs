//HintName: G.Models.GenerationParametersModelParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The parameters for the model.  These are currently a Scale-only feature.<br/>
    /// See [pricing](https://vectara.com/pricing/) for more details on becoming a Scale customer.<br/>
    /// WARNING: This is an experimental feature, and breakable at any point with virtually no<br/>
    /// notice. It is meant for experimentation to converge on optimal parameters that can then<br/>
    /// be set in the prompt definitions.
    /// </summary>
    public sealed partial class GenerationParametersModelParameters
    {
        /// <summary>
        /// The maximum number of tokens to be returned by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The sampling temperature to use. Higher values make the output more random, while lower<br/>
        /// values make it more focused and deterministic.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Higher values penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Higher values penalize new tokens based on whether they appear in the text so far,<br/>
        /// increasing the model's likelihood to talk about new topics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public float? PresencePenalty { get; set; }

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
        public static global::G.GenerationParametersModelParameters? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GenerationParametersModelParameters>(
                json,
                jsonSerializerOptions);
        }

    }
}