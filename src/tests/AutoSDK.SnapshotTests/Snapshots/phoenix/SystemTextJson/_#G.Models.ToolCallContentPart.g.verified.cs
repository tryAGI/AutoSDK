//HintName: G.Models.ToolCallContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallContentPart
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool_call"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_call";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolCallFunction ToolCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallContentPart" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="toolCall"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallContentPart(
            string toolCallId,
            global::G.ToolCallFunction toolCall,
            string type = "tool_call")
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolCall = toolCall ?? throw new global::System.ArgumentNullException(nameof(toolCall));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallContentPart" /> class.
        /// </summary>
        public ToolCallContentPart()
        {
        }
    }
}