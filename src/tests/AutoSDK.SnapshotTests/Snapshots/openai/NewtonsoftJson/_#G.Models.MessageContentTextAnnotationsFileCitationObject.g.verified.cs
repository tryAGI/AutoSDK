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
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_citation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageContentTextAnnotationsFileCitationObjectFileCitation FileCitation { get; set; } = default!;

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
        /// Always `file_citation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageContentTextAnnotationsFileCitationObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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