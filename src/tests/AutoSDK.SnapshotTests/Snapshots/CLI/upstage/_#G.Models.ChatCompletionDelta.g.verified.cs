//HintName: G.Models.ChatCompletionDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionDelta
    {
        /// <summary>
        /// The role of the author of this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionDeltaRoleJsonConverter))]
        public global::G.ChatCompletionDeltaRole? Role { get; set; }

        /// <summary>
        /// The content chunk of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Tool call chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCallChunk>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDelta" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the author of this message.
        /// </param>
        /// <param name="content">
        /// The content chunk of the message.
        /// </param>
        /// <param name="toolCalls">
        /// Tool call chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionDelta(
            global::G.ChatCompletionDeltaRole? role,
            string? content,
            global::System.Collections.Generic.IList<global::G.ToolCallChunk>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDelta" /> class.
        /// </summary>
        public ChatCompletionDelta()
        {
        }
    }
}