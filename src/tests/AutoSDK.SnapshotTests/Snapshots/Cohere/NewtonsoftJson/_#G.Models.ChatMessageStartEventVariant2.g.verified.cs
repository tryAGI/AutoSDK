//HintName: G.Models.ChatMessageStartEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventVariant2
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
        public global::G.ChatMessageStartEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the generated reply.
        /// </param>
        /// <param name="delta"></param>
        public ChatMessageStartEventVariant2(
            string? id,
            global::G.ChatMessageStartEventVariant2Delta? delta)
        {
            this.Id = id;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2" /> class.
        /// </summary>
        public ChatMessageStartEventVariant2()
        {
        }
    }
}