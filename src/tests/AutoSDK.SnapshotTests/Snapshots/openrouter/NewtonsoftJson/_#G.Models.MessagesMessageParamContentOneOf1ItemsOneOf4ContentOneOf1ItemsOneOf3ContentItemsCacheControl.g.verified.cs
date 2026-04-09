//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTtlJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControl(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlType type,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControl" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControl()
        {
        }
    }
}