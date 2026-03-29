//HintName: G.Models.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The array of vector values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="embedding">
        /// The array of vector values.
        /// </param>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems(
            int? index,
            global::System.Collections.Generic.IList<double>? embedding)
        {
            this.Index = index;
            this.Embedding = embedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}