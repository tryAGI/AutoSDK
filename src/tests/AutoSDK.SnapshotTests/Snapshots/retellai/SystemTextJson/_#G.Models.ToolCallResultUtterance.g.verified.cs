//HintName: G.Models.ToolCallResultUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallResultUtterance
    {
        /// <summary>
        /// This is the result of a tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallResultUtteranceRoleJsonConverter))]
        public global::G.ToolCallResultUtteranceRole Role { get; set; }

        /// <summary>
        /// Tool call id, globally unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Whether the tool call was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultUtterance" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Tool call id, globally unique.
        /// </param>
        /// <param name="content">
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </param>
        /// <param name="role">
        /// This is the result of a tool call.
        /// </param>
        /// <param name="successful">
        /// Whether the tool call was successful.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallResultUtterance(
            string toolCallId,
            string content,
            global::G.ToolCallResultUtteranceRole role,
            bool? successful)
        {
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultUtterance" /> class.
        /// </summary>
        public ToolCallResultUtterance()
        {
        }
    }
}