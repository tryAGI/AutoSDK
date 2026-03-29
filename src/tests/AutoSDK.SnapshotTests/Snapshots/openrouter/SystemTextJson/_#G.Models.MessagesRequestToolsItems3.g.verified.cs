//HintName: G.Models.MessagesRequestToolsItems3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItems3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf3TypeJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolsItemsOneOf3NameJsonConverter))]
        public global::G.MessagesRequestToolsItemsOneOf3Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public double? MaxUses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesRequestToolsItemsOneOf3UserLocation, object>))]
        public global::G.OneOf<global::G.MessagesRequestToolsItemsOneOf3UserLocation, object>? UserLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.MessagesRequestToolsItemsOneOf3CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="blockedDomains"></param>
        /// <param name="maxUses"></param>
        /// <param name="userLocation"></param>
        /// <param name="cacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolsItems3(
            global::G.MessagesRequestToolsItemsOneOf3Type type,
            global::G.MessagesRequestToolsItemsOneOf3Name name,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            double? maxUses,
            global::G.OneOf<global::G.MessagesRequestToolsItemsOneOf3UserLocation, object>? userLocation,
            global::G.MessagesRequestToolsItemsOneOf3CacheControl? cacheControl)
        {
            this.Type = type;
            this.Name = name;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.MaxUses = maxUses;
            this.UserLocation = userLocation;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems3" /> class.
        /// </summary>
        public MessagesRequestToolsItems3()
        {
        }
    }
}