//HintName: G.Models.ChatCompletionRequestMessageContentPartFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [file inputs](/docs/guides/text) for text generation.
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionRequestMessageContentPartFileFile File { get; set; } = default!;

        /// <summary>
        /// The type of the content part. Always `file`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionRequestMessageContentPartFileType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFile" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type">
        /// The type of the content part. Always `file`.
        /// </param>
        public ChatCompletionRequestMessageContentPartFile(
            global::G.ChatCompletionRequestMessageContentPartFileFile file,
            global::G.ChatCompletionRequestMessageContentPartFileType type)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFile" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartFile()
        {
        }
    }
}