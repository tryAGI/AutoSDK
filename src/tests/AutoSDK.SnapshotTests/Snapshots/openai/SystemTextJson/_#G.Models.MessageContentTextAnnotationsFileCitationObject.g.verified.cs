//HintName: G.Models.MessageContentTextAnnotationsFileCitationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
    /// </summary>
    public sealed partial class MessageContentTextAnnotationsFileCitationObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageContentTextAnnotationsFileCitationObjectFileCitation FileCitation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Always `file_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageContentTextAnnotationsFileCitationObjectTypeJsonConverter))]
        public global::G.MessageContentTextAnnotationsFileCitationObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFileCitationObject" /> class.
        /// </summary>
        /// <param name="endIndex"></param>
        /// <param name="fileCitation"></param>
        /// <param name="startIndex"></param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="type">
        /// Always `file_citation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentTextAnnotationsFileCitationObject(
            int endIndex,
            global::G.MessageContentTextAnnotationsFileCitationObjectFileCitation fileCitation,
            int startIndex,
            string text,
            global::G.MessageContentTextAnnotationsFileCitationObjectType type)
        {
            this.EndIndex = endIndex;
            this.FileCitation = fileCitation ?? throw new global::System.ArgumentNullException(nameof(fileCitation));
            this.StartIndex = startIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFileCitationObject" /> class.
        /// </summary>
        public MessageContentTextAnnotationsFileCitationObject()
        {
        }
    }
}