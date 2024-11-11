//HintName: G.Models.LogLikelihoodResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogLikelihoodResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Probabilities for tokens in the request prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TokenLikelihood> PromptTokens { get; set; } = default!;

        /// <summary>
        /// Probabilities for tokens in the request completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TokenLikelihood> CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Probabilities for tokens in the request raw_prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TokenLikelihood> RawPromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogLikelihoodResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptTokens">
        /// Probabilities for tokens in the request prompt
        /// </param>
        /// <param name="completionTokens">
        /// Probabilities for tokens in the request completion
        /// </param>
        /// <param name="rawPromptTokens">
        /// Probabilities for tokens in the request raw_prompt
        /// </param>
        /// <param name="meta"></param>
        public LogLikelihoodResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.TokenLikelihood> promptTokens,
            global::System.Collections.Generic.IList<global::G.TokenLikelihood> completionTokens,
            global::System.Collections.Generic.IList<global::G.TokenLikelihood> rawPromptTokens,
            global::G.ApiMeta? meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptTokens = promptTokens ?? throw new global::System.ArgumentNullException(nameof(promptTokens));
            this.CompletionTokens = completionTokens ?? throw new global::System.ArgumentNullException(nameof(completionTokens));
            this.RawPromptTokens = rawPromptTokens ?? throw new global::System.ArgumentNullException(nameof(rawPromptTokens));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogLikelihoodResponse" /> class.
        /// </summary>
        public LogLikelihoodResponse()
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
        public static global::G.LogLikelihoodResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LogLikelihoodResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.LogLikelihoodResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LogLikelihoodResponse?>(serializer.Deserialize<global::G.LogLikelihoodResponse>(jsonReader));
        }

    }
}