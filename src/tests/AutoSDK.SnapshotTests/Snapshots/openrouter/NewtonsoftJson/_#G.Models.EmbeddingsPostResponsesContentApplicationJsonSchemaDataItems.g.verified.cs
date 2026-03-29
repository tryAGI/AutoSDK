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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding Embedding { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="embedding"></param>
        /// <param name="object"></param>
        /// <param name="index"></param>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems(
            global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding embedding,
            global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject @object,
            double? index)
        {
            this.Object = @object;
            this.Embedding = embedding;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}