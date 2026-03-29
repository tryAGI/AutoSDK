//HintName: G.Models.ChatRequestCacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enable automatic prompt caching. When set, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
    /// </summary>
    public sealed partial class ChatRequestCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatRequestCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        public global::G.ChatRequestCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public ChatRequestCacheControl(
            global::G.ChatRequestCacheControlType type,
            global::G.ChatRequestCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCacheControl" /> class.
        /// </summary>
        public ChatRequestCacheControl()
        {
        }
    }
}