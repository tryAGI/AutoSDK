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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Spending limit for the API key in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Total OpenRouter credit usage (in USD) for the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageDaily { get; set; }

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC week (Monday-Sunday)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_weekly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageWeekly { get; set; }

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_monthly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageMonthly { get; set; }

        /// <summary>
        /// Total external BYOK usage (in USD) for the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsage { get; set; }

        /// <summary>
        /// External BYOK usage (in USD) for the current UTC day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageDaily { get; set; }

        /// <summary>
        /// External BYOK usage (in USD) for the current UTC week (Monday-Sunday)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_weekly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageWeekly { get; set; }

        /// <summary>
        /// External BYOK usage (in USD) for current UTC month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_monthly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageMonthly { get; set; }

        /// <summary>
        /// Whether this is a free tier API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_free_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFreeTier { get; set; }

        /// <summary>
        /// Whether this is a management key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_management_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsManagementKey { get; set; }

        /// <summary>
        /// Whether this is a management key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_provisioning_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsProvisioningKey { get; set; }

        /// <summary>
        /// Remaining spending limit in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_remaining")]
        public double? LimitRemaining { get; set; }

        /// <summary>
        /// Type of limit reset for the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_reset")]
        public string? LimitReset { get; set; }

        /// <summary>
        /// Whether to include external BYOK usage in the credit limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInLimit { get; set; }

        /// <summary>
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// Legacy rate limit information about a key. Will always return -1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit RateLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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