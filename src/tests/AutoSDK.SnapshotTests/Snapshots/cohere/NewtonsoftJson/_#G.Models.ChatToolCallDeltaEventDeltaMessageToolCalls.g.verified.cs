//HintName: G.Models.ChatToolCallDeltaEventDeltaMessageToolCalls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventDeltaMessageToolCalls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ChatToolCallDeltaEventDeltaMessageToolCallsFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventDeltaMessageToolCalls" /> class.
        /// </summary>
        /// <param name="function"></param>
        public ChatToolCallDeltaEventDeltaMessageToolCalls(
            global::G.ChatToolCallDeltaEventDeltaMessageToolCallsFunction? function)
        {
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventDeltaMessageToolCalls" /> class.
        /// </summary>
        public ChatToolCallDeltaEventDeltaMessageToolCalls()
        {
        }
    }
}