//HintName: G.Models.Embedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// The encoded embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingItem Embedding1 { get; set; } = default!;

        /// <summary>
        /// The index of the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The object type of the embedding.<br/>
        /// Default Value: embedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="embedding1">
        /// The encoded embedding.
        /// </param>
        /// <param name="index">
        /// The index of the embedding.
        /// </param>
        /// <param name="object">
        /// The object type of the embedding.<br/>
        /// Default Value: embedding
        /// </param>
        public Embedding(
            global::G.EmbeddingItem embedding1,
            int index,
            string? @object)
        {
            this.Embedding1 = embedding1;
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        public Embedding()
        {
        }
    }
}