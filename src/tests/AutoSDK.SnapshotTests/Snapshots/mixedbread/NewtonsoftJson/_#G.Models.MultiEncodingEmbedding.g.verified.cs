//HintName: G.Models.MultiEncodingEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiEncodingEmbedding
    {
        /// <summary>
        /// The encoded embedding data by encoding format.Returned, if more than one encoding format is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MultipleEncodingsEmbeddingItem Embedding { get; set; } = default!;

        /// <summary>
        /// The index of the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The object type of the embedding.<br/>
        /// Default Value: embedding_dict
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiEncodingEmbedding" /> class.
        /// </summary>
        /// <param name="embedding">
        /// The encoded embedding data by encoding format.Returned, if more than one encoding format is used.
        /// </param>
        /// <param name="index">
        /// The index of the embedding.
        /// </param>
        /// <param name="object">
        /// The object type of the embedding.<br/>
        /// Default Value: embedding_dict
        /// </param>
        public MultiEncodingEmbedding(
            global::G.MultipleEncodingsEmbeddingItem embedding,
            int index,
            string? @object)
        {
            this.Embedding = embedding ?? throw new global::System.ArgumentNullException(nameof(embedding));
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiEncodingEmbedding" /> class.
        /// </summary>
        public MultiEncodingEmbedding()
        {
        }
    }
}