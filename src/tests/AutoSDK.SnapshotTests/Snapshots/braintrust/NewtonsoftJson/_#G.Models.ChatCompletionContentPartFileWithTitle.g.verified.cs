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
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionContentPartFileFile File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter))]
        public global::G.ChatCompletionContentPartFileWithTitleType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileWithTitle" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type"></param>
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