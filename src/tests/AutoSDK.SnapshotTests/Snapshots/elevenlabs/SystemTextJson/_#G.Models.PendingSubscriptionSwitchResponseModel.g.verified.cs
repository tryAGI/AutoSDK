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
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The tier to change to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PendingSubscriptionSwitchResponseModelNextTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PendingSubscriptionSwitchResponseModelNextTier NextTier { get; set; }

        /// <summary>
        /// The billing period to change to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_billing_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BillingPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BillingPeriod NextBillingPeriod { get; set; }

        /// <summary>
        /// The timestamp of the change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimestampSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingSubscriptionSwitchResponseModel" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: change
        /// </param>
        /// <param name="nextTier">
        /// The tier to change to.
        /// </param>
        /// <param name="nextBillingPeriod">
        /// The billing period to change to.
        /// </param>
        /// <param name="timestampSeconds">
        /// The timestamp of the change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingSubscriptionSwitchResponseModel(
            global::G.PendingSubscriptionSwitchResponseModelNextTier nextTier,
            global::G.BillingPeriod nextBillingPeriod,
            int timestampSeconds,
            string? kind)
        {
            this.NextTier = nextTier;
            this.NextBillingPeriod = nextBillingPeriod;
            this.TimestampSeconds = timestampSeconds;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingSubscriptionSwitchResponseModel" /> class.
        /// </summary>
        public PendingSubscriptionSwitchResponseModel()
        {
        }
    }
}