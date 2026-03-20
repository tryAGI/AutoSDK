//HintName: G.Models.ChatContentDeltaEvent3m0vqs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentDeltaEvent3m0vqs
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
        public global::G.ChatContentDeltaEventDelta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.LogprobItem? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEvent3m0vqs" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        /// <param name="logprobs"></param>
        public ChatContentDeltaEvent3m0vqs(
            int? index,
            global::G.ChatContentDeltaEventDelta? delta,
            global::G.LogprobItem? logprobs)
        {
            this.Index = index;
            this.Delta = delta;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentDeltaEvent3m0vqs" /> class.
        /// </summary>
        public ChatContentDeltaEvent3m0vqs()
        {
        }
    }
}