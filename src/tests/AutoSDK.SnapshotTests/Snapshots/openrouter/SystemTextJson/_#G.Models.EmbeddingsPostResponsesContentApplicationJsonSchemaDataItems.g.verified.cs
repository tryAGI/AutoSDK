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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter))]
        public global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="embedding"></param>
        /// <param name="object"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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