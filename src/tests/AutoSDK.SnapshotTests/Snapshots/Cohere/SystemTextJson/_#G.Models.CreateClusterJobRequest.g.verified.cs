//HintName: G.Models.CreateClusterJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClusterJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_dataset_id")]
        public string? InputDatasetId { get; set; }

        /// <summary>
        /// Defaults to `10`. Parameter for HDBSCAN. Only clusters with this number of elements will be returned with a positive cluster number.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_cluster_size")]
        public int? MinClusterSize { get; set; }

        /// <summary>
        /// Parameter for UMAP. A scalar governing how to balance global vs local structure in the data.<br/>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_neighbors")]
        public int? NNeighbors { get; set; }

        /// <summary>
        /// Parameter for UMAP. A boolean governing whether the embeddings from UMAP (that will be clustered with HDBSCAN) are deterministic.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deterministic")]
        public bool? IsDeterministic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_descriptions")]
        public bool? GenerateDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterJobRequest" /> class.
        /// </summary>
        /// <param name="embeddingsUrl"></param>
        /// <param name="inputDatasetId"></param>
        /// <param name="minClusterSize">
        /// Defaults to `10`. Parameter for HDBSCAN. Only clusters with this number of elements will be returned with a positive cluster number.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="nNeighbors">
        /// Parameter for UMAP. A scalar governing how to balance global vs local structure in the data.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="isDeterministic">
        /// Parameter for UMAP. A boolean governing whether the embeddings from UMAP (that will be clustered with HDBSCAN) are deterministic.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="generateDescriptions"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateClusterJobRequest(
            string embeddingsUrl,
            string? inputDatasetId,
            int? minClusterSize,
            int? nNeighbors,
            bool? isDeterministic,
            bool? generateDescriptions)
        {
            this.EmbeddingsUrl = embeddingsUrl ?? throw new global::System.ArgumentNullException(nameof(embeddingsUrl));
            this.InputDatasetId = inputDatasetId;
            this.MinClusterSize = minClusterSize;
            this.NNeighbors = nNeighbors;
            this.IsDeterministic = isDeterministic;
            this.GenerateDescriptions = generateDescriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterJobRequest" /> class.
        /// </summary>
        public CreateClusterJobRequest()
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
        public static global::G.CreateClusterJobRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CreateClusterJobRequest),
                jsonSerializerContext) as global::G.CreateClusterJobRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateClusterJobRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateClusterJobRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CreateClusterJobRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CreateClusterJobRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CreateClusterJobRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateClusterJobRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CreateClusterJobRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}