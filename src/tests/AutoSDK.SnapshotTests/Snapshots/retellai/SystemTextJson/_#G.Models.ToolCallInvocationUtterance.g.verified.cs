//HintName: G.Models.ToolCallInvocationUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallInvocationUtterance
    {
        /// <summary>
        /// This is a tool call invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallInvocationUtteranceRoleJsonConverter))]
        public global::G.ToolCallInvocationUtteranceRole Role { get; set; }

        /// <summary>
        /// Tool call id, globally unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Name of the function in this tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Arguments for this tool call, it's a stringified JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Optional thought signature from Google Gemini thinking models. This is used internally to maintain reasoning chain in multi-turn function calling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thought_signature")]
        public string? ThoughtSignature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationUtterance" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Tool call id, globally unique.
        /// </param>
        /// <param name="name">
        /// Name of the function in this tool call.
        /// </param>
        /// <param name="arguments">
        /// Arguments for this tool call, it's a stringified JSON object.
        /// </param>
        /// <param name="role">
        /// This is a tool call invocation.
        /// </param>
        /// <param name="thoughtSignature">
        /// Optional thought signature from Google Gemini thinking models. This is used internally to maintain reasoning chain in multi-turn function calling.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallInvocationUtterance(
            string toolCallId,
            string name,
            string arguments,
            global::G.ToolCallInvocationUtteranceRole role,
            string? thoughtSignature)
        {
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.ThoughtSignature = thoughtSignature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationUtterance" /> class.
        /// </summary>
        public ToolCallInvocationUtterance()
        {
        }
    }
}