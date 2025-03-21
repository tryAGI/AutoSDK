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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_path", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageContentTextAnnotationsFilePathObjectFilePath FilePath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Always `file_path`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageContentTextAnnotationsFilePathObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        /// <param name="endIndex"></param>
        /// <param name="filePath"></param>
        /// <param name="startIndex"></param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="type">
        /// Always `file_path`.
        /// </param>
        public MessageContentTextAnnotationsFilePathObject(
            int endIndex,
            global::G.MessageContentTextAnnotationsFilePathObjectFilePath filePath,
            int startIndex,
            string text,
            global::G.MessageContentTextAnnotationsFilePathObjectType type)
        {
            this.EndIndex = endIndex;
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.StartIndex = startIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
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