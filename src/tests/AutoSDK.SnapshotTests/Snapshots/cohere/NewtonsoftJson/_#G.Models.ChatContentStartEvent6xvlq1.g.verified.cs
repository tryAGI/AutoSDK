//HintName: G.Models.ChatContentStartEvent6xvlq1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentStartEvent6xvlq1
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
        public global::G.ChatContentStartEventDelta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentStartEvent6xvlq1" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        public ChatContentStartEvent6xvlq1(
            int? index,
            global::G.ChatContentStartEventDelta? delta)
        {
            this.Index = index;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentStartEvent6xvlq1" /> class.
        /// </summary>
        public ChatContentStartEvent6xvlq1()
        {
        }
    }
}