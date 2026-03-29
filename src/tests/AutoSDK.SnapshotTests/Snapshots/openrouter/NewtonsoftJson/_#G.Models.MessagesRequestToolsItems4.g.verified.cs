//HintName: G.Models.MessagesRequestToolsItems4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolsItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesRequestToolsItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.MessagesRequestToolsItemsOneOf4Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_callers")]
        public global::System.Collections.Generic.IList<global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems>? AllowedCallers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_uses")]
        public double? MaxUses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.OneOf<global::G.MessagesRequestToolsItemsOneOf4UserLocation, object>? UserLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesRequestToolsItemsOneOf4CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="blockedDomains"></param>
        /// <param name="maxUses"></param>
        /// <param name="userLocation"></param>
        /// <param name="cacheControl"></param>
        public MessagesRequestToolsItems4(
            global::G.MessagesRequestToolsItemsOneOf4Type type,
            global::G.MessagesRequestToolsItemsOneOf4Name name,
            global::System.Collections.Generic.IList<global::G.MessagesRequestToolsItemsOneOf4AllowedCallersItems>? allowedCallers,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            double? maxUses,
            global::G.OneOf<global::G.MessagesRequestToolsItemsOneOf4UserLocation, object>? userLocation,
            global::G.MessagesRequestToolsItemsOneOf4CacheControl? cacheControl)
        {
            this.Type = type;
            this.Name = name;
            this.AllowedCallers = allowedCallers;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.MaxUses = maxUses;
            this.UserLocation = userLocation;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolsItems4" /> class.
        /// </summary>
        public MessagesRequestToolsItems4()
        {
        }
    }
}