//HintName: G.Models.Organization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName2 { get; set; }

        /// <summary>
        /// Whether outage mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outage_mode_enabled")]
        public bool? OutageModeEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_urls")]
        public global::System.Collections.Generic.IList<global::G.OrganizationWebhookUrl>? WebhookUrls { get; set; }

        /// <summary>
        /// API key for webhook authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_key")]
        public string? WebhookKey { get; set; }

        /// <summary>
        /// Maximum concurrent calls allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_burst_enabled")]
        public bool? ConcurrencyBurstEnabled { get; set; }

        /// <summary>
        /// Maximum token length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_token_length")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Maximum call duration in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_ms")]
        public int? MaxCallDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_voice_ids")]
        public global::System.Collections.Generic.IList<string>? CustomVoiceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio_subaccount_sid")]
        public string? TwilioSubaccountSid { get; set; }

        /// <summary>
        /// Whether KYC verification has been passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kyc_passed")]
        public bool? KycPassed { get; set; }

        /// <summary>
        /// Unix timestamp of creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_audit")]
        public bool? SkipAudit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_provided")]
        public bool? ReviewProvided { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cps_config")]
        public global::G.OrganizationCpsConfig? CpsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_bucket")]
        public object? FeatureBucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_stable_server")]
        public bool? UseStableServer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="orgName">
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </param>
        /// <param name="orgName2">
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </param>
        /// <param name="outageModeEnabled">
        /// Whether outage mode is enabled
        /// </param>
        /// <param name="webhookUrls"></param>
        /// <param name="webhookKey">
        /// API key for webhook authentication
        /// </param>
        /// <param name="concurrency">
        /// Maximum concurrent calls allowed
        /// </param>
        /// <param name="concurrencyBurstEnabled">
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit (up to 3x or +300, whichever is lower) with a $0.10/min surcharge on burst calls.
        /// </param>
        /// <param name="maxTokenLength">
        /// Maximum token length
        /// </param>
        /// <param name="maxCallDurationMs">
        /// Maximum call duration in milliseconds
        /// </param>
        /// <param name="customVoiceIds"></param>
        /// <param name="twilioSubaccountSid"></param>
        /// <param name="kycPassed">
        /// Whether KYC verification has been passed
        /// </param>
        /// <param name="createdTimestamp">
        /// Unix timestamp of creation
        /// </param>
        /// <param name="skipAudit"></param>
        /// <param name="reviewProvided"></param>
        /// <param name="cpsConfig"></param>
        /// <param name="enterpriseId"></param>
        /// <param name="featureBucket"></param>
        /// <param name="useStableServer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            string? orgName,
            string? orgName2,
            bool? outageModeEnabled,
            global::System.Collections.Generic.IList<global::G.OrganizationWebhookUrl>? webhookUrls,
            string? webhookKey,
            int? concurrency,
            bool? concurrencyBurstEnabled,
            int? maxTokenLength,
            int? maxCallDurationMs,
            global::System.Collections.Generic.IList<string>? customVoiceIds,
            string? twilioSubaccountSid,
            bool? kycPassed,
            global::System.DateTimeOffset? createdTimestamp,
            bool? skipAudit,
            bool? reviewProvided,
            global::G.OrganizationCpsConfig? cpsConfig,
            string? enterpriseId,
            object? featureBucket,
            bool? useStableServer)
        {
            this.OrgName = orgName;
            this.OrgName2 = orgName2;
            this.OutageModeEnabled = outageModeEnabled;
            this.WebhookUrls = webhookUrls;
            this.WebhookKey = webhookKey;
            this.Concurrency = concurrency;
            this.ConcurrencyBurstEnabled = concurrencyBurstEnabled;
            this.MaxTokenLength = maxTokenLength;
            this.MaxCallDurationMs = maxCallDurationMs;
            this.CustomVoiceIds = customVoiceIds;
            this.TwilioSubaccountSid = twilioSubaccountSid;
            this.KycPassed = kycPassed;
            this.CreatedTimestamp = createdTimestamp;
            this.SkipAudit = skipAudit;
            this.ReviewProvided = reviewProvided;
            this.CpsConfig = cpsConfig;
            this.EnterpriseId = enterpriseId;
            this.FeatureBucket = featureBucket;
            this.UseStableServer = useStableServer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}