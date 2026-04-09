//HintName: G.Models.MessagesRequestToolsItemsOneOf0CacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItemsOneOf0CacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTypeJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf0CacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTtlJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf0CacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf0CacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public MessagesRequestToolsItemsOneOf0CacheControl(
            global::G.MessagesRequestToolsItemsOneOf0CacheControlType type,
            global::G.MessagesRequestToolsItemsOneOf0CacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf0CacheControl" /> class.
        /// </summary>
        public MessagesRequestToolsItemsOneOf0CacheControl()
        {
        }
    }
}