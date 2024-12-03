//HintName: G.Models.ChatCompletionRequestMessageContentPartText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartText
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestMessageContentPartTextTypeJsonConverter))]
        public global::G.ChatCompletionRequestMessageContentPartTextType Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartText" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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