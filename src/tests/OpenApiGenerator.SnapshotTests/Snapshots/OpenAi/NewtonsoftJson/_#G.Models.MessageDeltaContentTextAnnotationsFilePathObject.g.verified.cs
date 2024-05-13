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
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `file_path`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public MessageDeltaContentTextAnnotationsFilePathObjectType Type { get; set; } = default!;

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_path")]
        public MessageDeltaContentTextAnnotationsFilePathObjectFilePath? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index")]
        public int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index")]
        public int EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}