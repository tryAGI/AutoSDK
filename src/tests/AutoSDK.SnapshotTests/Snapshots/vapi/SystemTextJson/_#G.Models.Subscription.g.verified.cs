//HintName: G.Models.Subscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Subscription
    {
        /// <summary>
        /// This is the unique identifier for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the timestamp when the subscription was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the timestamp when the subscription was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the type / tier of the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionType Type { get; set; }

        /// <summary>
        /// This is the status of the subscription. Past due subscriptions are subscriptions<br/>
        /// with past due payments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubscriptionStatus Status { get; set; }

        /// <summary>
        /// This is the number of credits the subscription currently has.<br/>
        /// Note: This is a string to avoid floating point precision issues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Credits { get; set; }

        /// <summary>
        /// This is the total number of active calls (concurrency) across all orgs under this subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyCounter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConcurrencyCounter { get; set; }

        /// <summary>
        /// This is the default concurrency limit for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyLimitIncluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConcurrencyLimitIncluded { get; set; }

        /// <summary>
        /// This is the number of free phone numbers the subscription has
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbersCounter")]
        public double? PhoneNumbersCounter { get; set; }

        /// <summary>
        /// This is the maximum number of free phone numbers the subscription can have
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbersIncluded")]
        public double? PhoneNumbersIncluded { get; set; }

        /// <summary>
        /// This is the purchased add-on concurrency limit for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyLimitPurchased")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConcurrencyLimitPurchased { get; set; }

        /// <summary>
        /// This is the ID of the monthly job that charges for subscription add ons and phone numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyChargeScheduleId")]
        public double? MonthlyChargeScheduleId { get; set; }

        /// <summary>
        /// This is the ID of the monthly job that checks whether the credit balance of the subscription<br/>
        /// is sufficient for the monthly charge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyCreditCheckScheduleId")]
        public double? MonthlyCreditCheckScheduleId { get; set; }

        /// <summary>
        /// This is the Stripe customer ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeCustomerId")]
        public string? StripeCustomerId { get; set; }

        /// <summary>
        /// This is the Stripe payment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripePaymentMethodId")]
        public string? StripePaymentMethodId { get; set; }

        /// <summary>
        /// If this flag is true, then the user has purchased slack support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackSupportEnabled")]
        public bool? SlackSupportEnabled { get; set; }

        /// <summary>
        /// If this subscription has a slack support subscription, the slack channel's ID will be stored here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackChannelId")]
        public string? SlackChannelId { get; set; }

        /// <summary>
        /// This is the HIPAA enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable HIPAA compliance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaaEnabled")]
        public bool? HipaaEnabled { get; set; }

        /// <summary>
        /// This is the ZDR enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable ZDR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zdrEnabled")]
        public bool? ZdrEnabled { get; set; }

        /// <summary>
        /// This is the data retention enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable data retention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataRetentionEnabled")]
        public bool? DataRetentionEnabled { get; set; }

        /// <summary>
        /// This is the ID for the Common Paper agreement outlining the HIPAA contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaaCommonPaperAgreementId")]
        public string? HipaaCommonPaperAgreementId { get; set; }

        /// <summary>
        /// This is the Stripe fingerprint of the payment method (card). It allows us<br/>
        /// to detect users who try to abuse our system through multiple sign-ups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripePaymentMethodFingerprint")]
        public string? StripePaymentMethodFingerprint { get; set; }

        /// <summary>
        /// This is the customer's email on Stripe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeCustomerEmail")]
        public string? StripeCustomerEmail { get; set; }

        /// <summary>
        /// This is the email of the referrer for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referredByEmail")]
        public string? ReferredByEmail { get; set; }

        /// <summary>
        /// This is the auto reload plan configured for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoReloadPlan")]
        public global::G.AutoReloadPlan? AutoReloadPlan { get; set; }

        /// <summary>
        /// The number of minutes included in the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesIncluded")]
        public double? MinutesIncluded { get; set; }

        /// <summary>
        /// The number of minutes used in the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesUsed")]
        public double? MinutesUsed { get; set; }

        /// <summary>
        /// This is the timestamp at which the number of monthly free minutes is scheduled to reset at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesUsedNextResetAt")]
        public global::System.DateTime? MinutesUsedNextResetAt { get; set; }

        /// <summary>
        /// The per minute charge on minutes that exceed the included minutes. Enterprise only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesOverageCost")]
        public double? MinutesOverageCost { get; set; }

        /// <summary>
        /// The list of providers included in the subscription. Enterprise only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providersIncluded")]
        public global::System.Collections.Generic.IList<string>? ProvidersIncluded { get; set; }

        /// <summary>
        /// The maximum number of outbound calls this subscription may make in a day. Resets every night.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outboundCallsDailyLimit")]
        public double? OutboundCallsDailyLimit { get; set; }

        /// <summary>
        /// The current number of outbound calls the subscription has made in the current day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outboundCallsCounter")]
        public double? OutboundCallsCounter { get; set; }

        /// <summary>
        /// This is the timestamp at which the outbound calls counter is scheduled to reset at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outboundCallsCounterNextResetAt")]
        public global::System.DateTime? OutboundCallsCounterNextResetAt { get; set; }

        /// <summary>
        /// This is the IDs of the coupons applicable to this subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("couponIds")]
        public global::System.Collections.Generic.IList<string>? CouponIds { get; set; }

        /// <summary>
        /// This is the number of credits left obtained from a coupon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("couponUsageLeft")]
        public string? CouponUsageLeft { get; set; }

        /// <summary>
        /// This is the invoice plan for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoicePlan")]
        public global::G.InvoicePlan? InvoicePlan { get; set; }

        /// <summary>
        /// This is the PCI enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable PCI compliance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pciEnabled")]
        public bool? PciEnabled { get; set; }

        /// <summary>
        /// This is the ID for the Common Paper agreement outlining the PCI contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pciCommonPaperAgreementId")]
        public string? PciCommonPaperAgreementId { get; set; }

        /// <summary>
        /// This is the call retention days for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callRetentionDays")]
        public double? CallRetentionDays { get; set; }

        /// <summary>
        /// This is the chat retention days for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatRetentionDays")]
        public double? ChatRetentionDays { get; set; }

        /// <summary>
        /// This is the minutes_included reset frequency for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesIncludedResetFrequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubscriptionMinutesIncludedResetFrequencyJsonConverter))]
        public global::G.SubscriptionMinutesIncludedResetFrequency? MinutesIncludedResetFrequency { get; set; }

        /// <summary>
        /// This is the Role Based Access Control (RBAC) enabled flag for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbacEnabled")]
        public bool? RbacEnabled { get; set; }

        /// <summary>
        /// This is the platform fee for the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platformFee")]
        public double? PlatformFee { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the subscription.
        /// </param>
        /// <param name="createdAt">
        /// This is the timestamp when the subscription was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the timestamp when the subscription was last updated.
        /// </param>
        /// <param name="type">
        /// This is the type / tier of the subscription.
        /// </param>
        /// <param name="status">
        /// This is the status of the subscription. Past due subscriptions are subscriptions<br/>
        /// with past due payments.
        /// </param>
        /// <param name="credits">
        /// This is the number of credits the subscription currently has.<br/>
        /// Note: This is a string to avoid floating point precision issues.
        /// </param>
        /// <param name="concurrencyCounter">
        /// This is the total number of active calls (concurrency) across all orgs under this subscription.
        /// </param>
        /// <param name="concurrencyLimitIncluded">
        /// This is the default concurrency limit for the subscription.
        /// </param>
        /// <param name="concurrencyLimitPurchased">
        /// This is the purchased add-on concurrency limit for the subscription.
        /// </param>
        /// <param name="phoneNumbersCounter">
        /// This is the number of free phone numbers the subscription has
        /// </param>
        /// <param name="phoneNumbersIncluded">
        /// This is the maximum number of free phone numbers the subscription can have
        /// </param>
        /// <param name="monthlyChargeScheduleId">
        /// This is the ID of the monthly job that charges for subscription add ons and phone numbers.
        /// </param>
        /// <param name="monthlyCreditCheckScheduleId">
        /// This is the ID of the monthly job that checks whether the credit balance of the subscription<br/>
        /// is sufficient for the monthly charge.
        /// </param>
        /// <param name="stripeCustomerId">
        /// This is the Stripe customer ID.
        /// </param>
        /// <param name="stripePaymentMethodId">
        /// This is the Stripe payment ID.
        /// </param>
        /// <param name="slackSupportEnabled">
        /// If this flag is true, then the user has purchased slack support.
        /// </param>
        /// <param name="slackChannelId">
        /// If this subscription has a slack support subscription, the slack channel's ID will be stored here.
        /// </param>
        /// <param name="hipaaEnabled">
        /// This is the HIPAA enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable HIPAA compliance.
        /// </param>
        /// <param name="zdrEnabled">
        /// This is the ZDR enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable ZDR.
        /// </param>
        /// <param name="dataRetentionEnabled">
        /// This is the data retention enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable data retention.
        /// </param>
        /// <param name="hipaaCommonPaperAgreementId">
        /// This is the ID for the Common Paper agreement outlining the HIPAA contract.
        /// </param>
        /// <param name="stripePaymentMethodFingerprint">
        /// This is the Stripe fingerprint of the payment method (card). It allows us<br/>
        /// to detect users who try to abuse our system through multiple sign-ups.
        /// </param>
        /// <param name="stripeCustomerEmail">
        /// This is the customer's email on Stripe.
        /// </param>
        /// <param name="referredByEmail">
        /// This is the email of the referrer for the subscription.
        /// </param>
        /// <param name="autoReloadPlan">
        /// This is the auto reload plan configured for the subscription.
        /// </param>
        /// <param name="minutesIncluded">
        /// The number of minutes included in the subscription.
        /// </param>
        /// <param name="minutesUsed">
        /// The number of minutes used in the subscription.
        /// </param>
        /// <param name="minutesUsedNextResetAt">
        /// This is the timestamp at which the number of monthly free minutes is scheduled to reset at.
        /// </param>
        /// <param name="minutesOverageCost">
        /// The per minute charge on minutes that exceed the included minutes. Enterprise only.
        /// </param>
        /// <param name="providersIncluded">
        /// The list of providers included in the subscription. Enterprise only.
        /// </param>
        /// <param name="outboundCallsDailyLimit">
        /// The maximum number of outbound calls this subscription may make in a day. Resets every night.
        /// </param>
        /// <param name="outboundCallsCounter">
        /// The current number of outbound calls the subscription has made in the current day.
        /// </param>
        /// <param name="outboundCallsCounterNextResetAt">
        /// This is the timestamp at which the outbound calls counter is scheduled to reset at.
        /// </param>
        /// <param name="couponIds">
        /// This is the IDs of the coupons applicable to this subscription.
        /// </param>
        /// <param name="couponUsageLeft">
        /// This is the number of credits left obtained from a coupon.
        /// </param>
        /// <param name="invoicePlan">
        /// This is the invoice plan for the subscription.
        /// </param>
        /// <param name="pciEnabled">
        /// This is the PCI enabled flag for the subscription. It determines whether orgs under this<br/>
        /// subscription have the option to enable PCI compliance.
        /// </param>
        /// <param name="pciCommonPaperAgreementId">
        /// This is the ID for the Common Paper agreement outlining the PCI contract.
        /// </param>
        /// <param name="callRetentionDays">
        /// This is the call retention days for the subscription.
        /// </param>
        /// <param name="chatRetentionDays">
        /// This is the chat retention days for the subscription.
        /// </param>
        /// <param name="minutesIncludedResetFrequency">
        /// This is the minutes_included reset frequency for the subscription.
        /// </param>
        /// <param name="rbacEnabled">
        /// This is the Role Based Access Control (RBAC) enabled flag for the subscription.
        /// </param>
        /// <param name="platformFee">
        /// This is the platform fee for the subscription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Subscription(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.SubscriptionType type,
            global::G.SubscriptionStatus status,
            string credits,
            double concurrencyCounter,
            double concurrencyLimitIncluded,
            double concurrencyLimitPurchased,
            double? phoneNumbersCounter,
            double? phoneNumbersIncluded,
            double? monthlyChargeScheduleId,
            double? monthlyCreditCheckScheduleId,
            string? stripeCustomerId,
            string? stripePaymentMethodId,
            bool? slackSupportEnabled,
            string? slackChannelId,
            bool? hipaaEnabled,
            bool? zdrEnabled,
            bool? dataRetentionEnabled,
            string? hipaaCommonPaperAgreementId,
            string? stripePaymentMethodFingerprint,
            string? stripeCustomerEmail,
            string? referredByEmail,
            global::G.AutoReloadPlan? autoReloadPlan,
            double? minutesIncluded,
            double? minutesUsed,
            global::System.DateTime? minutesUsedNextResetAt,
            double? minutesOverageCost,
            global::System.Collections.Generic.IList<string>? providersIncluded,
            double? outboundCallsDailyLimit,
            double? outboundCallsCounter,
            global::System.DateTime? outboundCallsCounterNextResetAt,
            global::System.Collections.Generic.IList<string>? couponIds,
            string? couponUsageLeft,
            global::G.InvoicePlan? invoicePlan,
            bool? pciEnabled,
            string? pciCommonPaperAgreementId,
            double? callRetentionDays,
            double? chatRetentionDays,
            global::G.SubscriptionMinutesIncludedResetFrequency? minutesIncludedResetFrequency,
            bool? rbacEnabled,
            double? platformFee)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Type = type;
            this.Status = status;
            this.Credits = credits ?? throw new global::System.ArgumentNullException(nameof(credits));
            this.ConcurrencyCounter = concurrencyCounter;
            this.ConcurrencyLimitIncluded = concurrencyLimitIncluded;
            this.PhoneNumbersCounter = phoneNumbersCounter;
            this.PhoneNumbersIncluded = phoneNumbersIncluded;
            this.ConcurrencyLimitPurchased = concurrencyLimitPurchased;
            this.MonthlyChargeScheduleId = monthlyChargeScheduleId;
            this.MonthlyCreditCheckScheduleId = monthlyCreditCheckScheduleId;
            this.StripeCustomerId = stripeCustomerId;
            this.StripePaymentMethodId = stripePaymentMethodId;
            this.SlackSupportEnabled = slackSupportEnabled;
            this.SlackChannelId = slackChannelId;
            this.HipaaEnabled = hipaaEnabled;
            this.ZdrEnabled = zdrEnabled;
            this.DataRetentionEnabled = dataRetentionEnabled;
            this.HipaaCommonPaperAgreementId = hipaaCommonPaperAgreementId;
            this.StripePaymentMethodFingerprint = stripePaymentMethodFingerprint;
            this.StripeCustomerEmail = stripeCustomerEmail;
            this.ReferredByEmail = referredByEmail;
            this.AutoReloadPlan = autoReloadPlan;
            this.MinutesIncluded = minutesIncluded;
            this.MinutesUsed = minutesUsed;
            this.MinutesUsedNextResetAt = minutesUsedNextResetAt;
            this.MinutesOverageCost = minutesOverageCost;
            this.ProvidersIncluded = providersIncluded;
            this.OutboundCallsDailyLimit = outboundCallsDailyLimit;
            this.OutboundCallsCounter = outboundCallsCounter;
            this.OutboundCallsCounterNextResetAt = outboundCallsCounterNextResetAt;
            this.CouponIds = couponIds;
            this.CouponUsageLeft = couponUsageLeft;
            this.InvoicePlan = invoicePlan;
            this.PciEnabled = pciEnabled;
            this.PciCommonPaperAgreementId = pciCommonPaperAgreementId;
            this.CallRetentionDays = callRetentionDays;
            this.ChatRetentionDays = chatRetentionDays;
            this.MinutesIncludedResetFrequency = minutesIncludedResetFrequency;
            this.RbacEnabled = rbacEnabled;
            this.PlatformFee = platformFee;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        public Subscription()
        {
        }
    }
}