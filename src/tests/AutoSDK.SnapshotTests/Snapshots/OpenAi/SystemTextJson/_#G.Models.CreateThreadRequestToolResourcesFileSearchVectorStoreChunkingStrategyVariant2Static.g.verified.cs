//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static
    {
        /// <summary>
        /// The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunk_size_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxChunkSizeTokens { get; set; }

        /// <summary>
        /// The number of tokens that overlap between chunks. The default value is `400`.<br/>
        /// Note that the overlap must not exceed half of `max_chunk_size_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_overlap_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkOverlapTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static" /> class.
        /// </summary>
        /// <param name="maxChunkSizeTokens">
        /// The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
        /// </param>
        /// <param name="chunkOverlapTokens">
        /// The number of tokens that overlap between chunks. The default value is `400`.<br/>
        /// Note that the overlap must not exceed half of `max_chunk_size_tokens`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static(
            int maxChunkSizeTokens,
            int chunkOverlapTokens)
        {
            this.MaxChunkSizeTokens = maxChunkSizeTokens;
            this.ChunkOverlapTokens = chunkOverlapTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static" /> class.
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static()
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
        public static global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static),
                jsonSerializerContext) as global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}