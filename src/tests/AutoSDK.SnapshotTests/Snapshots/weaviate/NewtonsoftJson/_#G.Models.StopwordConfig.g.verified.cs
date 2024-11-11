//HintName: G.Models.StopwordConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// fine-grained control over stopword list usage
    /// </summary>
    public sealed partial class StopwordConfig
    {
        /// <summary>
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preset")]
        public global::G.StopwordConfigPreset? Preset { get; set; }

        /// <summary>
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additions")]
        public global::System.Collections.Generic.IList<string>? Additions { get; set; }

        /// <summary>
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removals")]
        public global::System.Collections.Generic.IList<string>? Removals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        /// <param name="preset">
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </param>
        /// <param name="additions">
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </param>
        /// <param name="removals">
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </param>
        public StopwordConfig(
            global::G.StopwordConfigPreset? preset,
            global::System.Collections.Generic.IList<string>? additions,
            global::System.Collections.Generic.IList<string>? removals)
        {
            this.Preset = preset;
            this.Additions = additions;
            this.Removals = removals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        public StopwordConfig()
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
        public static global::G.StopwordConfig? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StopwordConfig>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.StopwordConfig?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.StopwordConfig?>(serializer.Deserialize<global::G.StopwordConfig>(jsonReader));
        }

    }
}