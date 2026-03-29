//HintName: G.Models.UpdateCollectionConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCollectionConfiguration
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateHnswConfiguration>))]
        public global::G.OneOf<object, global::G.UpdateHnswConfiguration>? Hnsw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spann")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, global::G.UpdateSpannConfiguration>))]
        public global::G.OneOf<object, global::G.UpdateSpannConfiguration>? Spann { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionConfiguration" /> class.
        /// </summary>
        /// <param name="embeddingFunction"></param>
        /// <param name="hnsw"></param>
        /// <param name="spann"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCollectionConfiguration(
            global::G.OneOf<object, global::G.EmbeddingFunctionConfiguration?>? embeddingFunction,
            global::G.OneOf<object, global::G.UpdateHnswConfiguration>? hnsw,
            global::G.OneOf<object, global::G.UpdateSpannConfiguration>? spann)
        {
            this.EmbeddingFunction = embeddingFunction;
            this.Hnsw = hnsw;
            this.Spann = spann;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionConfiguration" /> class.
        /// </summary>
        public UpdateCollectionConfiguration()
        {
        }
    }
}