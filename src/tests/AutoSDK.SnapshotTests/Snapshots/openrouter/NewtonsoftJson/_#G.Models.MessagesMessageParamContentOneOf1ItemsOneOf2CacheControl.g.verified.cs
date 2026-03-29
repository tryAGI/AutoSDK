//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlType type,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2CacheControl()
        {
        }
    }
}