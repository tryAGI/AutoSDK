//HintName: G.Models.Prompt2025VersionPromptBodyMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2025VersionPromptBodyMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageContentVariant2Item>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        /// <param name="toolCallId"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt2025VersionPromptBodyMessage(
            string role,
            global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageToolCall>? toolCalls,
            string? toolCallId,
            string? name,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.Prompt2025VersionPromptBodyMessageContentVariant2Item>>? content)
        {
            this.ToolCalls = toolCalls;
            this.ToolCallId = toolCallId;
            this.Name = name;
            this.Content = content;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2025VersionPromptBodyMessage" /> class.
        /// </summary>
        public Prompt2025VersionPromptBodyMessage()
        {
        }
    }
}