//HintName: G.Models.CustomerSpecificReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reranker that is specific to the customer.
    /// </summary>
    public sealed partial class CustomerSpecificReranker
    {
        /// <summary>
        /// When type is `customer_reranker`, you can specify the `reranker_name` of a reranker. `reranker_id` is deprecated.<br/>
        /// The retrieval engine will then rerank results using that reranker.<br/>
        /// Default Value: customer_reranker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the reranker. The multilingual reranker that may be used by Scale customers is rnk_272725719.<br/>
        /// Do not specify the MMR reranker ID here, and instead, use the MMR reranker object type.<br/>
        /// **Deprecated**: Use `reranker_name` instead.<br/>
        /// Example: rnk_272725719
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reranker_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RerankerId { get; set; }

        /// <summary>
        /// The name of the reranker. Do not specify the MMR reranker name here. Instead, use the MMR reranker object type.<br/>
        /// Example: Rerank_Multilingual_v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reranker_name")]
        public string? RerankerName { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("limit")]
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
        [global::Newtonsoft.Json.JsonProperty("cutoff")]
        public float? Cutoff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.CustomerSpecificReranker? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CustomerSpecificReranker>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CustomerSpecificReranker?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CustomerSpecificReranker?>(serializer.Deserialize<global::G.CustomerSpecificReranker>(jsonReader));
        }

    }
}