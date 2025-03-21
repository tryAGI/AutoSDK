//HintName: G.Models.MessageDeltaContentTextAnnotationsFileCitationObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFileCitationObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_citation")]
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? FileCitation { get; set; }

        /// <summary>
        /// The index of the annotation in the text content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Always `file_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaContentTextAnnotationsFileCitationObjectTypeJsonConverter))]
        public global::G.MessageDeltaContentTextAnnotationsFileCitationObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFileCitationObject" /> class.
        /// </summary>
        /// <param name="endIndex"></param>
        /// <param name="fileCitation"></param>
        /// <param name="index">
        /// The index of the annotation in the text content part.
        /// </param>
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
        public MessageDeltaContentTextAnnotationsFileCitationObject(
            int index,
            int? endIndex,
            global::G.MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation? fileCitation,
            int? startIndex,
            string? text,
            global::G.MessageDeltaContentTextAnnotationsFileCitationObjectType type)
        {
            this.Index = index;
            this.EndIndex = endIndex;
            this.FileCitation = fileCitation;
            this.StartIndex = startIndex;
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFileCitationObject" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFileCitationObject()
        {
        }
    }
}