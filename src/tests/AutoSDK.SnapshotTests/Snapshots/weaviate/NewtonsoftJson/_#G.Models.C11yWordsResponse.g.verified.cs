//HintName: G.Models.C11yWordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of available words and contexts.
    /// </summary>
    public sealed partial class C11yWordsResponse
    {
        /// <summary>
        /// Weighted results for all words
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concatenatedWord")]
        public global::G.C11yWordsResponseConcatenatedWord? ConcatenatedWord { get; set; }

        /// <summary>
        /// Weighted results for per individual word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("individualWords")]
        public global::System.Collections.Generic.IList<global::G.C11yWordsResponseIndividualWord>? IndividualWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponse" /> class.
        /// </summary>
        /// <param name="concatenatedWord">
        /// Weighted results for all words
        /// </param>
        /// <param name="individualWords">
        /// Weighted results for per individual word
        /// </param>
        public C11yWordsResponse(
            global::G.C11yWordsResponseConcatenatedWord? concatenatedWord,
            global::System.Collections.Generic.IList<global::G.C11yWordsResponseIndividualWord>? individualWords)
        {
            this.ConcatenatedWord = concatenatedWord;
            this.IndividualWords = individualWords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yWordsResponse" /> class.
        /// </summary>
        public C11yWordsResponse()
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
        public static global::G.C11yWordsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.C11yWordsResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.C11yWordsResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.C11yWordsResponse?>(serializer.Deserialize<global::G.C11yWordsResponse>(jsonReader));
        }

    }
}