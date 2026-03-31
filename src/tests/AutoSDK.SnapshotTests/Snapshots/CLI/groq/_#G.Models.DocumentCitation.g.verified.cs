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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The character index in the message content where this citation ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The ID of the document being cited, corresponding to a document provided in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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