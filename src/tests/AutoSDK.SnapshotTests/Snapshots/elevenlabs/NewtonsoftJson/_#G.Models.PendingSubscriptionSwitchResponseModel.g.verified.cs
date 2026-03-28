//HintName: G.Models.PendingSubscriptionSwitchResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingSubscriptionSwitchResponseModel
    {
        /// <summary>
        /// Default Value: change
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The tier to change to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PendingSubscriptionSwitchResponseModelNextTier NextTier { get; set; } = default!;

        /// <summary>
        /// The billing period to change to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_billing_period", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BillingPeriod NextBillingPeriod { get; set; } = default!;

        /// <summary>
        /// The timestamp of the change.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public int TimestampSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingSubscriptionSwitchResponseModel" /> class.
        /// </summary>
        /// <param name="nextTier">
        /// The tier to change to.
        /// </param>
        /// <param name="nextBillingPeriod">
        /// The billing period to change to.
        /// </param>
        /// <param name="timestampSeconds">
        /// The timestamp of the change.
        /// </param>
        /// <param name="kind">
        /// Default Value: change
        /// </param>
        public PendingSubscriptionSwitchResponseModel(
            global::G.PendingSubscriptionSwitchResponseModelNextTier nextTier,
            global::G.BillingPeriod nextBillingPeriod,
            int timestampSeconds,
            string? kind)
        {
            this.Kind = kind;
            this.NextTier = nextTier;
            this.NextBillingPeriod = nextBillingPeriod;
            this.TimestampSeconds = timestampSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingSubscriptionSwitchResponseModel" /> class.
        /// </summary>
        public PendingSubscriptionSwitchResponseModel()
        {
        }
    }
}