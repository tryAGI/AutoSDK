//HintName: G.Models.BroadcasterSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BroadcasterSubscription
    {
        /// <summary>
        /// An ID that identifies the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The ID of the user that gifted the subscription to the user. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GifterId { get; set; } = default!;

        /// <summary>
        /// The gifter’s login name. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string GifterLogin { get; set; } = default!;

        /// <summary>
        /// The gifter’s display name. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string GifterName { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_gift", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsGift { get; set; } = default!;

        /// <summary>
        /// The name of the subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PlanName { get; set; } = default!;

        /// <summary>
        /// The type of subscription. Possible values are:  
        ///   
        /// * 1000 — Tier 1
        /// * 2000 — Tier 2
        /// * 3000 — Tier 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BroadcasterSubscriptionTier Tier { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the subscribing user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}