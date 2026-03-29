//HintName: G.Models.DocumentCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation referencing a specific document that was provided in the request.
    /// </summary>
    public sealed partial class DocumentCitation
    {
        /// <summary>
        /// The character index in the message content where this citation begins.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// The character index in the message content where this citation ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the document being cited, corresponding to a document provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCitation" /> class.
        /// </summary>
        /// <param name="startIndex">
        /// The character index in the message content where this citation begins.
        /// </param>
        /// <param name="endIndex">
        /// The character index in the message content where this citation ends.
        /// </param>
        /// <param name="documentId">
        /// The ID of the document being cited, corresponding to a document provided in the request.
        /// </param>
        public DocumentCitation(
            int startIndex,
            int endIndex,
            string documentId)
        {
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCitation" /> class.
        /// </summary>
        public DocumentCitation()
        {
        }
    }
}