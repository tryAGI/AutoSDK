//HintName: G.Models.ChatToolCallDeltaEventVariant2Delta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2Delta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call")]
        public global::G.ChatToolCallDeltaEventVariant2DeltaToolCall? ToolCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2Delta" /> class.
        /// </summary>
        /// <param name="toolCall"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolCallDeltaEventVariant2Delta(
            global::G.ChatToolCallDeltaEventVariant2DeltaToolCall? toolCall)
        {
            this.ToolCall = toolCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2Delta" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2Delta()
        {
        }
    }
}