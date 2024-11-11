//HintName: G.Models.UserFunctionReranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserFunctionReranker
    {
        /// <summary>
        /// When the type is `userfn`, you can define custom reranking functions using document-level metadata,<br/>
        /// part-level metadata, or scores generated from the request-level metadata.<br/>
        /// Default Value: userfn
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The user defined function.<br/>
        /// Example: get('$.score') * get('$.document_metadata.boost')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_function")]
        public string? UserFunction { get; set; }

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
        /// Initializes a new instance of the <see cref="UserFunctionReranker" /> class.
        /// </summary>
        /// <param name="type">
        /// When the type is `userfn`, you can define custom reranking functions using document-level metadata,<br/>
        /// part-level metadata, or scores generated from the request-level metadata.<br/>
        /// Default Value: userfn
        /// </param>
        /// <param name="userFunction">
        /// The user defined function.<br/>
        /// Example: get('$.score') * get('$.document_metadata.boost')
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
        public UserFunctionReranker(
            string? type,
            string? userFunction,
            int? limit,
            float? cutoff)
        {
            this.Type = type;
            this.UserFunction = userFunction;
            this.Limit = limit;
            this.Cutoff = cutoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFunctionReranker" /> class.
        /// </summary>
        public UserFunctionReranker()
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
        public static global::G.UserFunctionReranker? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UserFunctionReranker>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.UserFunctionReranker?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.UserFunctionReranker?>(serializer.Deserialize<global::G.UserFunctionReranker>(jsonReader));
        }

    }
}