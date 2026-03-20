//HintName: G.Models.ChatToolCallDeltaEventDeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventDeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::G.ChatToolCallDeltaEventDeltaMessageToolCalls? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventDeltaMessage" /> class.
        /// </summary>
        /// <param name="toolCalls"></param>
        public ChatToolCallDeltaEventDeltaMessage(
            global::G.ChatToolCallDeltaEventDeltaMessageToolCalls? toolCalls)
        {
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventDeltaMessage" /> class.
        /// </summary>
        public ChatToolCallDeltaEventDeltaMessage()
        {
        }
    }
}