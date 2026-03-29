//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTtlJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControl(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlType type,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControl" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControl()
        {
        }
    }
}