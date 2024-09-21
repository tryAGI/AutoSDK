//HintName: G.Models.ManageApiSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManageApiSubscriptionResponse
    {
        /// <summary>
        /// Whether or not the latest required terms have been accepted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_accepted_terms", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasAcceptedTerms { get; set; } = default!;

        /// <summary>
        /// Whether or not Stripe is setup for API usage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_stripe_setup", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasStripeSetup { get; set; } = default!;

        /// <summary>
        /// The URL to display the customer usage dashboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metronome_dashboard_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardUrl { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard, in dark mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metronome_dashboard_dark_mode_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardDarkModeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metronome_links")]
        public global::G.MetronomeLinks? MetronomeLinks { get; set; }

        /// <summary>
        /// The current recharge settings for the API subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recharge_settings")]
        public global::G.RechargeSettings? RechargeSettings { get; set; }

        /// <summary>
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stripe_billing_url")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}