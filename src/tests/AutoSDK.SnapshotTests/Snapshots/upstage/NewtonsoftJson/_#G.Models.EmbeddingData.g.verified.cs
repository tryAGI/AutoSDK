//HintName: G.Models.EmbeddingData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingData
    {
        /// <summary>
        /// The object type, always "embedding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbeddingDataObjectJsonConverter))]
        public global::G.EmbeddingDataObject? Object { get; set; }

        /// <summary>
        /// The embedding vector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// The index of the embedding in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, always "embedding".
        /// </param>
        /// <param name="embedding">
        /// The embedding vector.
        /// </param>
        /// <param name="index">
        /// The index of the embedding in the list.
        /// </param>
        public EmbeddingData(
            global::G.EmbeddingDataObject? @object,
            global::System.Collections.Generic.IList<double>? embedding,
            int? index)
        {
            this.Object = @object;
            this.Embedding = embedding;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        public EmbeddingData()
        {
        }
    }
}