//HintName: G.Models.ChatCompletionRequestMessageContentPartDocumentDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartDocumentDocument
    {
        /// <summary>
        /// The JSON document data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// Optional unique identifier for the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartDocumentDocument" /> class.
        /// </summary>
        /// <param name="data">
        /// The JSON document data.
        /// </param>
        /// <param name="id">
        /// Optional unique identifier for the document.
        /// </param>
        public ChatCompletionRequestMessageContentPartDocumentDocument(
            object data,
            string? id)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartDocumentDocument" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartDocumentDocument()
        {
        }
    }
}