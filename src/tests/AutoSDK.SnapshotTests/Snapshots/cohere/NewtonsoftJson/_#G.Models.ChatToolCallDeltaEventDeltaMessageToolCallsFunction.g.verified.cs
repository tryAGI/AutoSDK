//HintName: G.Models.ChatToolCallDeltaEventDeltaMessageToolCallsFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventDeltaMessageToolCallsFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventDeltaMessageToolCallsFunction" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        public ChatToolCallDeltaEventDeltaMessageToolCallsFunction(
            string? arguments)
        {
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventDeltaMessageToolCallsFunction" /> class.
        /// </summary>
        public ChatToolCallDeltaEventDeltaMessageToolCallsFunction()
        {
        }
    }
}