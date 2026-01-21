//HintName: G.Models.OrganizationBillingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about an organization's billing configuration.
    /// </summary>
    public sealed partial class OrganizationBillingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OrganizationConfig Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_to_stripe", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ConnectedToStripe { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_to_metronome", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ConnectedToMetronome { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPersonal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier")]
        public global::G.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payment_method")]
        public global::G.StripePaymentMethodInfo? PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_of_billing_period")]
        public global::System.DateTime? EndOfBillingPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_plan")]
        public global::G.CustomerVisiblePlanInfo? CurrentPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upcoming_plan")]
        public global::G.CustomerVisiblePlanInfo? UpcomingPlan { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationBillingInfo" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="config">
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </param>
        /// <param name="connectedToStripe"></param>
        /// <param name="connectedToMetronome"></param>
        /// <param name="isPersonal"></param>
        /// <param name="tier"></param>
        /// <param name="paymentMethod"></param>
        /// <param name="endOfBillingPeriod"></param>
        /// <param name="currentPlan"></param>
        /// <param name="upcomingPlan"></param>
        /// <param name="reachedMaxWorkspaces">
        /// Default Value: false
        /// </param>
        /// <param name="disabled">
        /// Default Value: false
        /// </param>
        public OrganizationBillingInfo(
            string displayName,
            global::G.OrganizationConfig config,
            bool connectedToStripe,
            bool connectedToMetronome,
            bool isPersonal,
            global::System.Guid? id,
            global::G.PaymentPlanTier? tier,
            global::G.StripePaymentMethodInfo? paymentMethod,
            global::System.DateTime? endOfBillingPeriod,
            global::G.CustomerVisiblePlanInfo? currentPlan,
            global::G.CustomerVisiblePlanInfo? upcomingPlan,
            bool? reachedMaxWorkspaces,
            bool? disabled)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ConnectedToStripe = connectedToStripe;
            this.ConnectedToMetronome = connectedToMetronome;
            this.IsPersonal = isPersonal;
            this.Id = id;
            this.Tier = tier;
            this.PaymentMethod = paymentMethod;
            this.EndOfBillingPeriod = endOfBillingPeriod;
            this.CurrentPlan = currentPlan;
            this.UpcomingPlan = upcomingPlan;
            this.ReachedMaxWorkspaces = reachedMaxWorkspaces;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationBillingInfo" /> class.
        /// </summary>
        public OrganizationBillingInfo()
        {
        }
    }
}