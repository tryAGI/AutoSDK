//HintName: G.Models.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The available capabilities of the model.
    /// </summary>
    public sealed partial class ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_completion")]
        public bool? ChatCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_with_image")]
        public bool? ChatWithImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public bool? Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public bool? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_with_image")]
        public bool? EmbeddingWithImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenize")]
        public bool? Tokenize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detokenize")]
        public bool? Detokenize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calling")]
        public bool? ToolCalling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public bool? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities" /> class.
        /// </summary>
        /// <param name="chatCompletion"></param>
        /// <param name="chatWithImage"></param>
        /// <param name="completion"></param>
        /// <param name="embedding"></param>
        /// <param name="embeddingWithImage"></param>
        /// <param name="tokenize"></param>
        /// <param name="detokenize"></param>
        /// <param name="rerank"></param>
        /// <param name="toolCalling"></param>
        /// <param name="reasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities(
            bool? chatCompletion,
            bool? chatWithImage,
            bool? completion,
            bool? embedding,
            bool? embeddingWithImage,
            bool? tokenize,
            bool? detokenize,
            bool? rerank,
            bool? toolCalling,
            bool? reasoning)
        {
            this.ChatCompletion = chatCompletion;
            this.ChatWithImage = chatWithImage;
            this.Completion = completion;
            this.Embedding = embedding;
            this.EmbeddingWithImage = embeddingWithImage;
            this.Tokenize = tokenize;
            this.Detokenize = detokenize;
            this.Rerank = rerank;
            this.ToolCalling = toolCalling;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities" /> class.
        /// </summary>
        public ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities()
        {
        }
    }
}