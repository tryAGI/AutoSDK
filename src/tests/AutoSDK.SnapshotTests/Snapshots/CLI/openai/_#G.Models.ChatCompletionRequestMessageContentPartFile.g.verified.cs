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
        /// The type of the content part. Always `file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestMessageContentPartFileTypeJsonConverter))]
        public global::G.ChatCompletionRequestMessageContentPartFileType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionRequestMessageContentPartFileFile File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFile" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content part. Always `file`.
        /// </param>
        /// <param name="file"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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