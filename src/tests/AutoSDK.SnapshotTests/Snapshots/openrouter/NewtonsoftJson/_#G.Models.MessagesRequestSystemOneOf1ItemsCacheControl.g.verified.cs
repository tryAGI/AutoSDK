//HintName: G.Models.MessagesRequestSystemOneOf1ItemsCacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestSystemOneOf1ItemsCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesRequestSystemOneOf1ItemsCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        public global::G.MessagesRequestSystemOneOf1ItemsCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestSystemOneOf1ItemsCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public MessagesRequestSystemOneOf1ItemsCacheControl(
            global::G.MessagesRequestSystemOneOf1ItemsCacheControlType type,
            global::G.MessagesRequestSystemOneOf1ItemsCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestSystemOneOf1ItemsCacheControl" /> class.
        /// </summary>
        public MessagesRequestSystemOneOf1ItemsCacheControl()
        {
        }
    }
}