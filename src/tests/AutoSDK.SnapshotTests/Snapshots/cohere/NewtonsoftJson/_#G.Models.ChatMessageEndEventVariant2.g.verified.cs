//HintName: G.Models.ChatMessageEndEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageEndEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public global::G.ChatMessageEndEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="id"></param>
        public ChatMessageEndEventVariant2(
            global::G.ChatMessageEndEventVariant2Delta? delta,
            string? id)
        {
            this.Delta = delta;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageEndEventVariant2" /> class.
        /// </summary>
        public ChatMessageEndEventVariant2()
        {
        }
    }
}