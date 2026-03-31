//HintName: G.Models.ChatCompletionContentPartFileWithTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartFileWithTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionContentPartFileFile File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter))]
        public global::G.ChatCompletionContentPartFileWithTitleType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileWithTitle" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartFileWithTitle(
            global::G.ChatCompletionContentPartFileFile file,
            global::G.ChatCompletionContentPartFileWithTitleType type)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileWithTitle" /> class.
        /// </summary>
        public ChatCompletionContentPartFileWithTitle()
        {
        }
    }
}