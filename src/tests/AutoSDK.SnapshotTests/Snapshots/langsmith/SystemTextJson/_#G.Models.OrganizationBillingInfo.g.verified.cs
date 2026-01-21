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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Organization level configuration. May include any field that exists in tenant config and additional fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrganizationConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_to_stripe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConnectedToStripe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_to_metronome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConnectedToMetronome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public global::G.PaymentPlanTier? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public global::G.StripePaymentMethodInfo? PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_billing_period")]
        public global::System.DateTime? EndOfBillingPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_plan")]
        public global::G.CustomerVisiblePlanInfo? CurrentPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upcoming_plan")]
        public global::G.CustomerVisiblePlanInfo? UpcomingPlan { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reached_max_workspaces")]
        public bool? ReachedMaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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