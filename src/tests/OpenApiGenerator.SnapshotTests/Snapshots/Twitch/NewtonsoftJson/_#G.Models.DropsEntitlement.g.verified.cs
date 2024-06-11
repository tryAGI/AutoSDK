//HintName: G.Models.DropsEntitlement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropsEntitlement
    {
        /// <summary>
        /// An ID that identifies the entitlement.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the benefit (reward).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("benefit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BenefitId { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the entitlement was granted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the user who was granted the entitlement.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the game the user was playing when the reward was entitled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("game_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GameId { get; set; } = default!;

        /// <summary>
        /// The entitlement’s fulfillment status. Possible values are:   
        ///   
        /// * CLAIMED
        /// * FULFILLED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fulfillment_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DropsEntitlementFulfillmentStatus FulfillmentStatus { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the entitlement was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdated { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}