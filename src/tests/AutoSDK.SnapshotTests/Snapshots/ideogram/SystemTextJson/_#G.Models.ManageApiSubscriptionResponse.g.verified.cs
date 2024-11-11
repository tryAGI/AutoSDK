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
        [global::System.Text.Json.Serialization.JsonPropertyName("has_accepted_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAcceptedTerms { get; set; }

        /// <summary>
        /// Whether or not Stripe is setup for API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_stripe_setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasStripeSetup { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_dashboard_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardUrl { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard, in dark mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_dashboard_dark_mode_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MetronomeDashboardDarkModeUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metronome_links")]
        public global::G.MetronomeLinks? MetronomeLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recharge_settings")]
        public global::G.RechargeSettingsResponse? RechargeSettings { get; set; }

        /// <summary>
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="hasAcceptedTerms">
        /// Whether or not the latest required terms have been accepted.
        /// </param>
        /// <param name="hasStripeSetup">
        /// Whether or not Stripe is setup for API usage.
        /// </param>
        /// <param name="metronomeLinks"></param>
        /// <param name="rechargeSettings"></param>
        /// <param name="stripeBillingUrl">
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ManageApiSubscriptionResponse(
            bool hasAcceptedTerms,
            bool hasStripeSetup,
            global::G.MetronomeLinks? metronomeLinks,
            global::G.RechargeSettingsResponse? rechargeSettings,
            string? stripeBillingUrl)
        {
            this.HasAcceptedTerms = hasAcceptedTerms;
            this.HasStripeSetup = hasStripeSetup;
            this.MetronomeLinks = metronomeLinks;
            this.RechargeSettings = rechargeSettings;
            this.StripeBillingUrl = stripeBillingUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        public ManageApiSubscriptionResponse()
        {
        }
    }
}