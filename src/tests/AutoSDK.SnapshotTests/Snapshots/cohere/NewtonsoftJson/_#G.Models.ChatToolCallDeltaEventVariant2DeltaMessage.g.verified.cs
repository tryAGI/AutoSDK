//HintName: G.Models.ChatToolCallDeltaEventVariant2DeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2DeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::G.ChatToolCallDeltaEventVariant2DeltaMessageToolCalls? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        /// <param name="toolCalls"></param>
        public ChatToolCallDeltaEventVariant2DeltaMessage(
            global::G.ChatToolCallDeltaEventVariant2DeltaMessageToolCalls? toolCalls)
        {
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2DeltaMessage()
        {
        }
    }
}