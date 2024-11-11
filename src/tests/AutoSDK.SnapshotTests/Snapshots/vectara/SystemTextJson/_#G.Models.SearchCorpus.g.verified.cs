//HintName: G.Models.SearchCorpus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCorpus
    {
        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The filter string to narrow the search to according to metadata attributes. The query against this<br/>
        /// corpus will be confined to document parts that match the `metadata_filter`. Only metadata<br/>
        /// set as `filter_attributes` on the corpus can be filtered. Filter syntax is similiar to<br/>
        /// a SQL where clause. See [metadata filters documentation](https://docs.vectara.com/docs/learn/metadata-search-filtering/filter-overview)<br/>
        /// for more information.<br/>
        /// Example: doc.title = 'Charlotte''s Web'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Example: 0.025F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_interpolation")]
        public float? LexicalInterpolation { get; set; }

        /// <summary>
        /// Indicates whether to consider a query against this corpus as a query or a response.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchSemanticsJsonConverter))]
        public global::G.SearchSemantics? Semantics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCorpus" /> class.
        /// </summary>
        /// <param name="customDimensions">
        /// The custom dimensions as additional weights.
        /// </param>
        /// <param name="metadataFilter">
        /// The filter string to narrow the search to according to metadata attributes. The query against this<br/>
        /// corpus will be confined to document parts that match the `metadata_filter`. Only metadata<br/>
        /// set as `filter_attributes` on the corpus can be filtered. Filter syntax is similiar to<br/>
        /// a SQL where clause. See [metadata filters documentation](https://docs.vectara.com/docs/learn/metadata-search-filtering/filter-overview)<br/>
        /// for more information.<br/>
        /// Example: doc.title = 'Charlotte''s Web'
        /// </param>
        /// <param name="lexicalInterpolation">
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Example: 0.025F
        /// </param>
        /// <param name="semantics">
        /// Indicates whether to consider a query against this corpus as a query or a response.<br/>
        /// Default Value: default
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SearchCorpus(
            global::System.Collections.Generic.Dictionary<string, double>? customDimensions,
            string? metadataFilter,
            float? lexicalInterpolation,
            global::G.SearchSemantics? semantics)
        {
            this.CustomDimensions = customDimensions;
            this.MetadataFilter = metadataFilter;
            this.LexicalInterpolation = lexicalInterpolation;
            this.Semantics = semantics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCorpus" /> class.
        /// </summary>
        public SearchCorpus()
        {
        }


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
        public static global::G.SearchCorpus? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.SearchCorpus),
                jsonSerializerContext) as global::G.SearchCorpus;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SearchCorpus? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.SearchCorpus>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.SearchCorpus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.SearchCorpus),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.SearchCorpus;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.SearchCorpus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.SearchCorpus?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}