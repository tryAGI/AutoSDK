//HintName: G.Models.ChatToolCallDeltaEventVariant2DeltaMessageToolCalls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2DeltaMessageToolCalls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ChatToolCallDeltaEventVariant2DeltaMessageToolCallsFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaMessageToolCalls" /> class.
        /// </summary>
        /// <param name="function"></param>
        public ChatToolCallDeltaEventVariant2DeltaMessageToolCalls(
            global::G.ChatToolCallDeltaEventVariant2DeltaMessageToolCallsFunction? function)
        {
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaMessageToolCalls" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2DeltaMessageToolCalls()
        {
        }
    }
}