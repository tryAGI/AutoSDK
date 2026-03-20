//HintName: G.Models.ChatMessageStartEventLsegeq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventLsegeq
    {
        /// <summary>
        /// Unique identifier for the generated reply.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatMessageStartEventDelta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventLsegeq" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the generated reply.
        /// </param>
        /// <param name="delta"></param>
        public ChatMessageStartEventLsegeq(
            string? id,
            global::G.ChatMessageStartEventDelta? delta)
        {
            this.Id = id;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventLsegeq" /> class.
        /// </summary>
        public ChatMessageStartEventLsegeq()
        {
        }
    }
}