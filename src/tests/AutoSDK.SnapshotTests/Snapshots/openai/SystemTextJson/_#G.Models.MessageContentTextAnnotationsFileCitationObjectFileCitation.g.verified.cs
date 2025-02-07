//HintName: G.Models.MessageContentTextAnnotationsFileCitationObjectFileCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextAnnotationsFileCitationObjectFileCitation
    {
        /// <summary>
        /// The ID of the specific File the citation is from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFileCitationObjectFileCitation" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the specific File the citation is from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentTextAnnotationsFileCitationObjectFileCitation(
            string fileId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFileCitationObjectFileCitation" /> class.
        /// </summary>
        public MessageContentTextAnnotationsFileCitationObjectFileCitation()
        {
        }
    }
}