//HintName: G.Models.Chapter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chapter of the audio file
    /// </summary>
    public sealed partial class Chapter
    {
        /// <summary>
        /// An ultra-short summary (just a few words) of the content spoken in the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gist", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gist { get; set; } = default!;

        /// <summary>
        /// A single sentence summary of the content spoken during the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headline", Required = global::Newtonsoft.Json.Required.Always)]
        public string Headline { get; set; } = default!;

        /// <summary>
        /// A one paragraph summary of the content spoken during the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// The starting time, in milliseconds, for the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The starting time, in milliseconds, for the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        /// <param name="gist">
        /// An ultra-short summary (just a few words) of the content spoken in the chapter
        /// </param>
        /// <param name="headline">
        /// A single sentence summary of the content spoken during the chapter
        /// </param>
        /// <param name="summary">
        /// A one paragraph summary of the content spoken during the chapter
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, for the chapter
        /// </param>
        /// <param name="end">
        /// The starting time, in milliseconds, for the chapter
        /// </param>
        public Chapter(
            string gist,
            string headline,
            string summary,
            int start,
            int end)
        {
            this.Gist = gist ?? throw new global::System.ArgumentNullException(nameof(gist));
            this.Headline = headline ?? throw new global::System.ArgumentNullException(nameof(headline));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        public Chapter()
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
        public static global::G.Chapter? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Chapter>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Chapter?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Chapter?>(serializer.Deserialize<global::G.Chapter>(jsonReader));
        }

    }
}