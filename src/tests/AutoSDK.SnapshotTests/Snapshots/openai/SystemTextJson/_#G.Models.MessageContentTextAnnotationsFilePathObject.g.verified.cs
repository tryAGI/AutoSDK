//HintName: G.Models.MessageContentTextAnnotationsFilePathObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
    /// </summary>
    public sealed partial class MessageContentTextAnnotationsFilePathObject
    {
        /// <summary>
        /// Always `file_path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageContentTextAnnotationsFilePathObjectTypeJsonConverter))]
        public global::G.MessageContentTextAnnotationsFilePathObjectType Type { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageContentTextAnnotationsFilePathObjectFilePath FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `file_path`.
        /// </param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="filePath"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentTextAnnotationsFilePathObject(
            string text,
            global::G.MessageContentTextAnnotationsFilePathObjectFilePath filePath,
            int startIndex,
            int endIndex,
            global::G.MessageContentTextAnnotationsFilePathObjectType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        public MessageContentTextAnnotationsFilePathObject()
        {
        }
    }
}