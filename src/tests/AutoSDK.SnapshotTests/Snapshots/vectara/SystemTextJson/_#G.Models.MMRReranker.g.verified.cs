//HintName: G.Models.MMRReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MMRReranker
    {
        /// <summary>
        /// When the type is `mmr`, you can specify the `diversity_bias`, and the<br/>
        /// the retrieval engine will use the MMR reranker.<br/>
        /// Default Value: mmr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The diversity bias. Higher values indicate more diversity.<br/>
        /// Example: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity_bias")]
        public float? DiversityBias { get; set; }

        /// <summary>
        /// Specifies the maximum number of results to be returned after the reranking process. <br/>
        /// When a reranker is applied, it performs the following steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results based on their new scores.<br/>
        /// 3. Returns the top N results, where N is the value specified by this limit.<br/>
        /// Note: This limit is applied per reranking stage. In a chain of rerankers, <br/>
        /// each reranker can have its own limit, potentially reducing the number of <br/>
        /// results at each stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Specifies the minimum score threshold for results to be included after the reranking process.<br/>
        /// When a reranker is applied with a cutoff, it performs the following steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Applies the cutoff, removing any results with scores below the specified threshold.<br/>
        /// 3. Returns the remaining results, sorted by their new scores.<br/>
        /// Note: This cutoff is applied per reranking stage. In a chain of rerankers,<br/>
        /// each reranker can have its own cutoff, potentially further reducing the number of<br/>
        /// results at each stage. If both 'limit' and 'cutoff' are specified, the cutoff<br/>
        /// is applied first, followed by the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cutoff")]
        public float? Cutoff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MMRReranker" /> class.
        /// </summary>
        /// <param name="type">
        /// When the type is `mmr`, you can specify the `diversity_bias`, and the<br/>
        /// the retrieval engine will use the MMR reranker.<br/>
        /// Default Value: mmr
        /// </param>
        /// <param name="diversityBias">
        /// The diversity bias. Higher values indicate more diversity.<br/>
        /// Example: 0.3F
        /// </param>
        /// <param name="limit">
        /// Specifies the maximum number of results to be returned after the reranking process. <br/>
        /// When a reranker is applied, it performs the following steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results based on their new scores.<br/>
        /// 3. Returns the top N results, where N is the value specified by this limit.<br/>
        /// Note: This limit is applied per reranking stage. In a chain of rerankers, <br/>
        /// each reranker can have its own limit, potentially reducing the number of <br/>
        /// results at each stage.
        /// </param>
        /// <param name="cutoff">
        /// Specifies the minimum score threshold for results to be included after the reranking process.<br/>
        /// When a reranker is applied with a cutoff, it performs the following steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Applies the cutoff, removing any results with scores below the specified threshold.<br/>
        /// 3. Returns the remaining results, sorted by their new scores.<br/>
        /// Note: This cutoff is applied per reranking stage. In a chain of rerankers,<br/>
        /// each reranker can have its own cutoff, potentially further reducing the number of<br/>
        /// results at each stage. If both 'limit' and 'cutoff' are specified, the cutoff<br/>
        /// is applied first, followed by the limit.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MMRReranker(
            string? type,
            float? diversityBias,
            int? limit,
            float? cutoff)
        {
            this.Type = type;
            this.DiversityBias = diversityBias;
            this.Limit = limit;
            this.Cutoff = cutoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MMRReranker" /> class.
        /// </summary>
        public MMRReranker()
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
        public static global::G.MMRReranker? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MMRReranker),
                jsonSerializerContext) as global::G.MMRReranker;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MMRReranker? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MMRReranker>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.MMRReranker?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.MMRReranker),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.MMRReranker;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.MMRReranker?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.MMRReranker?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}