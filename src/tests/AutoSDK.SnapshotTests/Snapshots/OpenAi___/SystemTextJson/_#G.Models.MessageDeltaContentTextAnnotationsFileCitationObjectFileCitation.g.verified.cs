//HintName: G.Models.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation
    {
        /// <summary>
        /// The ID of the specific File the citation is from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The specific quote in the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote")]
        public string? Quote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the specific File the citation is from.
        /// </param>
        /// <param name="quote">
        /// The specific quote in the file.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation(
            string? fileId,
            string? quote)
        {
            this.FileId = fileId;
            this.Quote = quote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation()
        {
        }
    }
}