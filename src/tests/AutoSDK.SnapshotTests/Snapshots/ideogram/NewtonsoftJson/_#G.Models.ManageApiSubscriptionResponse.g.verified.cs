//HintName: G.Models.ManageApiSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"recharge_settings":{"is_active":true},"has_stripe_setup":true,"metronome_dashboard_dark_mode_url":"metronome_dashboard_dark_mode_url","stripe_billing_url":"stripe_billing_url","has_accepted_terms":true,"metronome_dashboard_url":"metronome_dashboard_url","metronome_links":{"credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}}
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
        /// Example: {"credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}
        /// </summary>
        /// <example>{"credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}</example>
        [global::Newtonsoft.Json.JsonProperty("metronome_links")]
        public global::G.MetronomeLinks? MetronomeLinks { get; set; }

        /// <summary>
        /// Example: {"is_active":true}
        /// </summary>
        /// <example>{"is_active":true}</example>
        [global::Newtonsoft.Json.JsonProperty("recharge_settings")]
        public global::G.RechargeSettingsResponse? RechargeSettings { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="hasAcceptedTerms">
        /// Whether or not the latest required terms have been accepted.
        /// </param>
        /// <param name="hasStripeSetup">
        /// Whether or not Stripe is setup for API usage.
        /// </param>
        /// <param name="metronomeLinks">
        /// Example: {"credits_iframe_dark_mode_url":"credits_iframe_dark_mode_url","invoices_iframe_dark_mode_url":"invoices_iframe_dark_mode_url","invoices_iframe_url":"invoices_iframe_url","credits_iframe_url":"credits_iframe_url"}
        /// </param>
        /// <param name="rechargeSettings">
        /// Example: {"is_active":true}
        /// </param>
        /// <param name="stripeBillingUrl">
        /// The URL for the user to manage the existing Stripe subscription plan.
        /// </param>
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