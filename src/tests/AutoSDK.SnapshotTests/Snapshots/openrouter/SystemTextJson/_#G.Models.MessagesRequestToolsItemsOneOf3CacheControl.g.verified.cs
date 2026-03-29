//HintName: G.Models.MessagesRequestToolsItemsOneOf3CacheControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItemsOneOf3CacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlTypeJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf3CacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlTtlJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf3CacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf3CacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItemsOneOf3CacheControl(
            global::G.MessagesRequestToolsItemsOneOf3CacheControlType type,
            global::G.MessagesRequestToolsItemsOneOf3CacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItemsOneOf3CacheControl" /> class.
        /// </summary>
        public MessagesRequestToolsItemsOneOf3CacheControl()
        {
        }
    }
}