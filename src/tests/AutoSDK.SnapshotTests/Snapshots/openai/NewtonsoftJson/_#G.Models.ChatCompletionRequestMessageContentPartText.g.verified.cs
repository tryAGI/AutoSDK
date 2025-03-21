//HintName: G.Models.ChatCompletionRequestMessageContentPartText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [text inputs](/docs/guides/text-generation).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartText
    {
        /// <summary>
        /// The text content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionRequestMessageContentPartTextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        public ChatCompletionRequestMessageContentPartText(
            string text,
            global::G.ChatCompletionRequestMessageContentPartTextType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartText" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartText()
        {
        }
    }
}