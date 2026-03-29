//HintName: G.Models.KeyGetResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current API key information
    /// </summary>
    public sealed partial class KeyGetResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Human-readable label for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Spending limit for the API key in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Total OpenRouter credit usage (in USD) for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public double Usage { get; set; } = default!;

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC day
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_daily", Required = global::Newtonsoft.Json.Required.Always)]
        public double UsageDaily { get; set; } = default!;

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC week (Monday-Sunday)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_weekly", Required = global::Newtonsoft.Json.Required.Always)]
        public double UsageWeekly { get; set; } = default!;

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC month
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_monthly", Required = global::Newtonsoft.Json.Required.Always)]
        public double UsageMonthly { get; set; } = default!;

        /// <summary>
        /// Total external BYOK usage (in USD) for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byok_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public double ByokUsage { get; set; } = default!;

        /// <summary>
        /// External BYOK usage (in USD) for the current UTC day
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byok_usage_daily", Required = global::Newtonsoft.Json.Required.Always)]
        public double ByokUsageDaily { get; set; } = default!;

        /// <summary>
        /// External BYOK usage (in USD) for the current UTC week (Monday-Sunday)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byok_usage_weekly", Required = global::Newtonsoft.Json.Required.Always)]
        public double ByokUsageWeekly { get; set; } = default!;

        /// <summary>
        /// External BYOK usage (in USD) for current UTC month
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("byok_usage_monthly", Required = global::Newtonsoft.Json.Required.Always)]
        public double ByokUsageMonthly { get; set; } = default!;

        /// <summary>
        /// Whether this is a free tier API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_free_tier", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFreeTier { get; set; } = default!;

        /// <summary>
        /// Whether this is a management key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_management_key", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsManagementKey { get; set; } = default!;

        /// <summary>
        /// Whether this is a management key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_provisioning_key", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsProvisioningKey { get; set; } = default!;

        /// <summary>
        /// Remaining spending limit in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_remaining")]
        public double? LimitRemaining { get; set; }

        /// <summary>
        /// Type of limit reset for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_reset")]
        public string? LimitReset { get; set; }

        /// <summary>
        /// Whether to include external BYOK usage in the credit limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_byok_in_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncludeByokInLimit { get; set; } = default!;

        /// <summary>
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// Legacy rate limit information about a key. Will always return -1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit RateLimit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="label">
        /// Human-readable label for the API key
        /// </param>
        /// <param name="usage">
        /// Total OpenRouter credit usage (in USD) for the API key
        /// </param>
        /// <param name="usageDaily">
        /// OpenRouter credit usage (in USD) for the current UTC day
        /// </param>
        /// <param name="usageWeekly">
        /// OpenRouter credit usage (in USD) for the current UTC week (Monday-Sunday)
        /// </param>
        /// <param name="usageMonthly">
        /// OpenRouter credit usage (in USD) for the current UTC month
        /// </param>
        /// <param name="byokUsage">
        /// Total external BYOK usage (in USD) for the API key
        /// </param>
        /// <param name="byokUsageDaily">
        /// External BYOK usage (in USD) for the current UTC day
        /// </param>
        /// <param name="byokUsageWeekly">
        /// External BYOK usage (in USD) for the current UTC week (Monday-Sunday)
        /// </param>
        /// <param name="byokUsageMonthly">
        /// External BYOK usage (in USD) for current UTC month
        /// </param>
        /// <param name="isFreeTier">
        /// Whether this is a free tier API key
        /// </param>
        /// <param name="isManagementKey">
        /// Whether this is a management key
        /// </param>
        /// <param name="isProvisioningKey">
        /// Whether this is a management key
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include external BYOK usage in the credit limit
        /// </param>
        /// <param name="rateLimit">
        /// Legacy rate limit information about a key. Will always return -1.
        /// </param>
        /// <param name="limit">
        /// Spending limit for the API key in USD
        /// </param>
        /// <param name="limitRemaining">
        /// Remaining spending limit in USD
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration
        /// </param>
        /// <param name="creatorUserId">
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.
        /// </param>
        public KeyGetResponsesContentApplicationJsonSchemaData(
            string label,
            double usage,
            double usageDaily,
            double usageWeekly,
            double usageMonthly,
            double byokUsage,
            double byokUsageDaily,
            double byokUsageWeekly,
            double byokUsageMonthly,
            bool isFreeTier,
            bool isManagementKey,
            bool isProvisioningKey,
            bool includeByokInLimit,
            global::G.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit rateLimit,
            double? limit,
            double? limitRemaining,
            string? limitReset,
            global::System.DateTime? expiresAt,
            string? creatorUserId)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Limit = limit;
            this.Usage = usage;
            this.UsageDaily = usageDaily;
            this.UsageWeekly = usageWeekly;
            this.UsageMonthly = usageMonthly;
            this.ByokUsage = byokUsage;
            this.ByokUsageDaily = byokUsageDaily;
            this.ByokUsageWeekly = byokUsageWeekly;
            this.ByokUsageMonthly = byokUsageMonthly;
            this.IsFreeTier = isFreeTier;
            this.IsManagementKey = isManagementKey;
            this.IsProvisioningKey = isProvisioningKey;
            this.LimitRemaining = limitRemaining;
            this.LimitReset = limitReset;
            this.IncludeByokInLimit = includeByokInLimit;
            this.ExpiresAt = expiresAt;
            this.CreatorUserId = creatorUserId;
            this.RateLimit = rateLimit ?? throw new global::System.ArgumentNullException(nameof(rateLimit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public KeyGetResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}