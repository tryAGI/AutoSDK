//HintName: G.Models.ChatContentCacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cache control for the content part
    /// </summary>
    public sealed partial class ChatContentCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatContentCacheControlTypeJsonConverter))]
        public global::G.ChatContentCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatContentCacheControlTtlJsonConverter))]
        public global::G.ChatContentCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public ChatContentCacheControl(
            global::G.ChatContentCacheControlType type,
            global::G.ChatContentCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentCacheControl" /> class.
        /// </summary>
        public ChatContentCacheControl()
        {
        }
    }
}