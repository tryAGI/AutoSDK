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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestMessageContentPartDocumentTypeJsonConverter))]
        public global::G.ChatCompletionRequestMessageContentPartDocumentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionRequestMessageContentPartDocumentDocument Document { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartDocument" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
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