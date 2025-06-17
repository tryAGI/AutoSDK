//HintName: G.Models.ChatToolCallDeltaEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatToolCallDeltaEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="index"></param>
        public ChatToolCallDeltaEventVariant2(
            global::G.ChatToolCallDeltaEventVariant2Delta? delta,
            int? index)
        {
            this.Delta = delta;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2()
        {
        }
    }
}