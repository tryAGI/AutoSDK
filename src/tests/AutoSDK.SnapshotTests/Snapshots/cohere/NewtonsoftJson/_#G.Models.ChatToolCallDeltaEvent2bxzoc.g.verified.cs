//HintName: G.Models.ChatToolCallDeltaEvent2bxzoc.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEvent2bxzoc
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatToolCallDeltaEventDelta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEvent2bxzoc" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        public ChatToolCallDeltaEvent2bxzoc(
            int? index,
            global::G.ChatToolCallDeltaEventDelta? delta)
        {
            this.Index = index;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEvent2bxzoc" /> class.
        /// </summary>
        public ChatToolCallDeltaEvent2bxzoc()
        {
        }
    }
}