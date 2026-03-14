//HintName: G.Models.ChatCompletionStreamResponseDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A partial message update to be merged with previous chunks in a streaming response.
    /// </summary>
    public sealed partial class ChatCompletionStreamResponseDelta
    {
        /// <summary>
        /// The role of the author of this message, typically 'assistant' for responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseDelta" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the author of this message, typically 'assistant' for responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStreamResponseDelta(
            string? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseDelta" /> class.
        /// </summary>
        public ChatCompletionStreamResponseDelta()
        {
        }
    }
}