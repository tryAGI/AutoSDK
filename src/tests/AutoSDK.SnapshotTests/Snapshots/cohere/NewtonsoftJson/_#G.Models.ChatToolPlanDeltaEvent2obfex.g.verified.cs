//HintName: G.Models.ChatToolPlanDeltaEvent2obfex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolPlanDeltaEvent2obfex
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatToolPlanDeltaEventDelta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEvent2obfex" /> class.
        /// </summary>
        /// <param name="delta"></param>
        public ChatToolPlanDeltaEvent2obfex(
            global::G.ChatToolPlanDeltaEventDelta? delta)
        {
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEvent2obfex" /> class.
        /// </summary>
        public ChatToolPlanDeltaEvent2obfex()
        {
        }
    }
}