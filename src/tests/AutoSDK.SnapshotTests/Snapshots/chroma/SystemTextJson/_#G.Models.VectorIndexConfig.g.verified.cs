//HintName: G.Models.VectorIndexConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorIndexConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_function")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.EmbeddingFunctionConfiguration?>))]
        public global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? EmbeddingFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.HnswIndexConfig>))]
        public global::G.OneOf<object, global::G.HnswIndexConfig>? Hnsw { get; set; }

        /// <summary>
        /// Key to source the vector from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_key")]
        public string? SourceKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.Space2?>))]
        public global::G.OneOf<object, global::G.Space2?>? Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spann")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.SpannIndexConfig>))]
        public global::G.OneOf<object, global::G.SpannIndexConfig>? Spann { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        /// <param name="embeddingFunction"></param>
        /// <param name="hnsw"></param>
        /// <param name="sourceKey">
        /// Key to source the vector from
        /// </param>
        /// <param name="space"></param>
        /// <param name="spann"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorIndexConfig(
            global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? embeddingFunction,
            global::G.OneOf<object, global::G.HnswIndexConfig>? hnsw,
            string? sourceKey,
            global::G.OneOf<object, global::G.Space2?>? space,
            global::G.OneOf<object, global::G.SpannIndexConfig>? spann)
        {
            this.EmbeddingFunction = embeddingFunction;
            this.Hnsw = hnsw;
            this.SourceKey = sourceKey;
            this.Space = space;
            this.Spann = spann;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorIndexConfig" /> class.
        /// </summary>
        public VectorIndexConfig()
        {
        }
    }
}