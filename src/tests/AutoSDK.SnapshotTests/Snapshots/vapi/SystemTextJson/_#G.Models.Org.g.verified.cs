//HintName: G.Models.Org.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Org
    {
        /// <summary>
        /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false.<br/>
        /// When HIPAA is enabled, only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively.<br/>
        /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaaEnabled")]
        public bool? HipaaEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::G.Subscription? Subscription { get; set; }

        /// <summary>
        /// This is the ID of the subscription the org belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// This is the unique identifier for the org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the org was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the org was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the subscription for the org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeSubscriptionId")]
        public string? StripeSubscriptionId { get; set; }

        /// <summary>
        /// This is the subscription's subscription item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeSubscriptionItemId")]
        public string? StripeSubscriptionItemId { get; set; }

        /// <summary>
        /// This is the subscription's current period start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeSubscriptionCurrentPeriodStart")]
        public global::System.DateTime? StripeSubscriptionCurrentPeriodStart { get; set; }

        /// <summary>
        /// This is the subscription's status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeSubscriptionStatus")]
        public string? StripeSubscriptionStatus { get; set; }

        /// <summary>
        /// This is the secret key used for signing JWT tokens for the org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwtSecret")]
        public string? JwtSecret { get; set; }

        /// <summary>
        /// This is the total number of call minutes used by this org across all time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutesUsed")]
        public double? MinutesUsed { get; set; }

        /// <summary>
        /// This is the name of the org. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgChannelJsonConverter))]
        public global::G.OrgChannel? Channel { get; set; }

        /// <summary>
        /// This is the monthly billing limit for the org. To go beyond $1000/mo, please contact us at support@vapi.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingLimit")]
        public double? BillingLimit { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// This is the concurrency limit for the org. This is the maximum number of calls that can be active at any given time. To go beyond 10, please contact us at support@vapi.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyLimit")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? ConcurrencyLimit { get; set; }

        /// <summary>
        /// Stores the information about the compliance plan enforced at the organization level. Currently pciEnabled is supported through this field.<br/>
        /// When this is enabled, any logs, recordings, or transcriptions will be shipped to the customer endpoints if provided else lost.<br/>
        /// At the end of the call, you will receive an end-of-call-report message to store on your server, if webhook is provided.<br/>
        /// Defaults to false.<br/>
        /// When PCI is enabled, only PCI-compliant Providers will be available for LLM, Voice and transcribers.<br/>
        /// This is due to the compliance requirements of PCI. Other providers may not meet these requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliancePlan")]
        public global::G.CompliancePlan? CompliancePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Org" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the org.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the org was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the org was last updated.
        /// </param>
        /// <param name="hipaaEnabled">
        /// When this is enabled, logs, recordings, and transcriptions will be stored in HIPAA-compliant storage. Defaults to false.<br/>
        /// When HIPAA is enabled, only HIPAA-compliant providers will be available for LLM, Voice, and Transcriber respectively.<br/>
        /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.<br/>
        /// Example: false
        /// </param>
        /// <param name="subscription"></param>
        /// <param name="subscriptionId">
        /// This is the ID of the subscription the org belongs to.
        /// </param>
        /// <param name="stripeSubscriptionId">
        /// This is the subscription for the org.
        /// </param>
        /// <param name="stripeSubscriptionItemId">
        /// This is the subscription's subscription item.
        /// </param>
        /// <param name="stripeSubscriptionCurrentPeriodStart">
        /// This is the subscription's current period start.
        /// </param>
        /// <param name="stripeSubscriptionStatus">
        /// This is the subscription's status.
        /// </param>
        /// <param name="jwtSecret">
        /// This is the secret key used for signing JWT tokens for the org.
        /// </param>
        /// <param name="minutesUsed">
        /// This is the total number of call minutes used by this org across all time.
        /// </param>
        /// <param name="name">
        /// This is the name of the org. This is just for your own reference.
        /// </param>
        /// <param name="channel">
        /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
        /// </param>
        /// <param name="billingLimit">
        /// This is the monthly billing limit for the org. To go beyond $1000/mo, please contact us at support@vapi.ai.
        /// </param>
        /// <param name="server">
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </param>
        /// <param name="compliancePlan">
        /// Stores the information about the compliance plan enforced at the organization level. Currently pciEnabled is supported through this field.<br/>
        /// When this is enabled, any logs, recordings, or transcriptions will be shipped to the customer endpoints if provided else lost.<br/>
        /// At the end of the call, you will receive an end-of-call-report message to store on your server, if webhook is provided.<br/>
        /// Defaults to false.<br/>
        /// When PCI is enabled, only PCI-compliant Providers will be available for LLM, Voice and transcribers.<br/>
        /// This is due to the compliance requirements of PCI. Other providers may not meet these requirements.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Org(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool? hipaaEnabled,
            global::G.Subscription? subscription,
            string? subscriptionId,
            string? stripeSubscriptionId,
            string? stripeSubscriptionItemId,
            global::System.DateTime? stripeSubscriptionCurrentPeriodStart,
            string? stripeSubscriptionStatus,
            string? jwtSecret,
            double? minutesUsed,
            string? name,
            global::G.OrgChannel? channel,
            double? billingLimit,
            global::G.Server? server,
            global::G.CompliancePlan? compliancePlan)
        {
            this.HipaaEnabled = hipaaEnabled;
            this.Subscription = subscription;
            this.SubscriptionId = subscriptionId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StripeSubscriptionId = stripeSubscriptionId;
            this.StripeSubscriptionItemId = stripeSubscriptionItemId;
            this.StripeSubscriptionCurrentPeriodStart = stripeSubscriptionCurrentPeriodStart;
            this.StripeSubscriptionStatus = stripeSubscriptionStatus;
            this.JwtSecret = jwtSecret;
            this.MinutesUsed = minutesUsed;
            this.Name = name;
            this.Channel = channel;
            this.BillingLimit = billingLimit;
            this.Server = server;
            this.CompliancePlan = compliancePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Org" /> class.
        /// </summary>
        public Org()
        {
        }
    }
}