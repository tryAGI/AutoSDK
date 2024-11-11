//HintName: G.Models.WordSearchMatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordSearchMatch
    {
        /// <summary>
        /// The matched word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The total amount of times the word is in the transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// An array of timestamps
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> Timestamps { get; set; } = default!;

        /// <summary>
        /// An array of all index locations for that word within the `words` array of the completed transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Indexes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchMatch" /> class.
        /// </summary>
        /// <param name="text">
        /// The matched word
        /// </param>
        /// <param name="count">
        /// The total amount of times the word is in the transcript
        /// </param>
        /// <param name="timestamps">
        /// An array of timestamps
        /// </param>
        /// <param name="indexes">
        /// An array of all index locations for that word within the `words` array of the completed transcript
        /// </param>
        public WordSearchMatch(
            string text,
            int count,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> timestamps,
            global::System.Collections.Generic.IList<int> indexes)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Count = count;
            this.Timestamps = timestamps ?? throw new global::System.ArgumentNullException(nameof(timestamps));
            this.Indexes = indexes ?? throw new global::System.ArgumentNullException(nameof(indexes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchMatch" /> class.
        /// </summary>
        public WordSearchMatch()
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
        public static global::G.WordSearchMatch? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WordSearchMatch>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WordSearchMatch?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WordSearchMatch?>(serializer.Deserialize<global::G.WordSearchMatch>(jsonReader));
        }

    }
}