//HintName: G.Models.ChatV3Response2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatV3Response2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ChatV3MessageDetail? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatV3ResponseEventJsonConverter))]
        public global::G.ChatV3ResponseEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3Response2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event"></param>
        public ChatV3Response2(
            global::G.ChatV3MessageDetail? data,
            global::G.ChatV3ResponseEvent? @event)
        {
            this.Data = data;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3Response2" /> class.
        /// </summary>
        public ChatV3Response2()
        {
        }
    }
}