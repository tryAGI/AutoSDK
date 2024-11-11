//HintName: G.Models.RerankResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponseResult
    {
        /// <summary>
        /// If `return_documents` is set as `false` this will return none, if `true` it will return the documents passed in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::G.RerankResponseResultDocument? Document { get; set; }

        /// <summary>
        /// Corresponds to the index in the original list of documents to which the ranked document belongs. (i.e. if the first value in the `results` object has an `index` value of 3, it means in the list of documents passed in, the document at `index=3` had the highest relevance)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Relevance scores are normalized to be in the range `[0, 1]`. Scores close to `1` indicate a high relevance to the query, and scores closer to `0` indicate low relevance. It is not accurate to assume a score of 0.9 means the document is 2x more relevant than a document with a score of 0.45<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public float RelevanceScore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResult" /> class.
        /// </summary>
        /// <param name="document">
        /// If `return_documents` is set as `false` this will return none, if `true` it will return the documents passed in
        /// </param>
        /// <param name="index">
        /// Corresponds to the index in the original list of documents to which the ranked document belongs. (i.e. if the first value in the `results` object has an `index` value of 3, it means in the list of documents passed in, the document at `index=3` had the highest relevance)
        /// </param>
        /// <param name="relevanceScore">
        /// Relevance scores are normalized to be in the range `[0, 1]`. Scores close to `1` indicate a high relevance to the query, and scores closer to `0` indicate low relevance. It is not accurate to assume a score of 0.9 means the document is 2x more relevant than a document with a score of 0.45<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RerankResponseResult(
            int index,
            global::G.RerankResponseResultDocument? document,
            float relevanceScore = default!)
        {
            this.Index = index;
            this.Document = document;
            this.RelevanceScore = relevanceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResult" /> class.
        /// </summary>
        public RerankResponseResult()
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
        public static global::G.RerankResponseResult? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RerankResponseResult),
                jsonSerializerContext) as global::G.RerankResponseResult;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RerankResponseResult? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RerankResponseResult>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RerankResponseResult?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RerankResponseResult),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RerankResponseResult;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RerankResponseResult?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RerankResponseResult?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}