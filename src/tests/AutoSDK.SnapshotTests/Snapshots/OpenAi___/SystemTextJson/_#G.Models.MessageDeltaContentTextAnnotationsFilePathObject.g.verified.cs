//HintName: G.Models.MessageDeltaContentTextAnnotationsFilePathObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFilePathObject
    {
        /// <summary>
        /// The index of the annotation in the text content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `file_path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter))]
        public global::G.MessageDeltaContentTextAnnotationsFilePathObjectType Type { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public global::G.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the annotation in the text content part.
        /// </param>
        /// <param name="type">
        /// Always `file_path`.
        /// </param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="filePath"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentTextAnnotationsFilePathObject(
            int index,
            global::G.MessageDeltaContentTextAnnotationsFilePathObjectType type,
            string? text,
            global::G.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? filePath,
            int? startIndex,
            int? endIndex)
        {
            this.Index = index;
            this.Type = type;
            this.Text = text;
            this.FilePath = filePath;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFilePathObject()
        {
        }
    }
}