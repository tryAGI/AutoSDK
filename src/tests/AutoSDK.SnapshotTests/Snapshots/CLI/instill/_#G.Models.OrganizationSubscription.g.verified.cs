//HintName: G.Models.OrganizationSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OrganizationSubscription details describe the plan (i.e., features) an organization has access to.
    /// </summary>
    public sealed partial class OrganizationSubscription
    {
        /// <summary>
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrganizationSubscriptionPlanJsonConverter))]
        public global::G.OrganizationSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::G.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Number of used seats within the organization subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedSeats")]
        public int? UsedSeats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSubscription" /> class.
        /// </summary>
        /// <param name="plan">
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="detail">
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usedSeats">
        /// Number of used seats within the organization subscription.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSubscription(
            global::G.OrganizationSubscriptionPlan? plan,
            global::G.StripeSubscriptionDetail? detail,
            int? usedSeats)
        {
            this.Plan = plan;
            this.Detail = detail;
            this.UsedSeats = usedSeats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSubscription" /> class.
        /// </summary>
        public OrganizationSubscription()
        {
        }
    }
}