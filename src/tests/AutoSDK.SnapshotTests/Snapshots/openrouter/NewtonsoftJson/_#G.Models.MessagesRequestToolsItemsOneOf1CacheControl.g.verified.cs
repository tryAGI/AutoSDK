//HintName: G.Models.MessagesRequestToolsItemsOneOf1CacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItemsOneOf1CacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlTypeJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf1CacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlTtlJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf1CacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf1CacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public MessagesRequestToolsItemsOneOf1CacheControl(
            global::G.MessagesRequestToolsItemsOneOf1CacheControlType type,
            global::G.MessagesRequestToolsItemsOneOf1CacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf1CacheControl" /> class.
        /// </summary>
        public MessagesRequestToolsItemsOneOf1CacheControl()
        {
        }
    }
}