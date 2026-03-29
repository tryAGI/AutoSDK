//HintName: G.Models.ChatCompletionRequestMessageContentPartDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartDocument
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestMessageContentPartDocumentTypeJsonConverter))]
        public global::G.ChatCompletionRequestMessageContentPartDocumentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionRequestMessageContentPartDocumentDocument Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartDocument" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartDocument(
            global::G.ChatCompletionRequestMessageContentPartDocumentDocument document,
            global::G.ChatCompletionRequestMessageContentPartDocumentType type)
        {
            this.Type = type;
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartDocument" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartDocument()
        {
        }
    }
}