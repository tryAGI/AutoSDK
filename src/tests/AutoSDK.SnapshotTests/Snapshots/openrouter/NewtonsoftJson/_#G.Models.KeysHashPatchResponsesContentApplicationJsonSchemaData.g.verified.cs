//HintName: G.Models.KeysHashPatchResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The updated API key information
    /// </summary>
    public sealed partial class KeysHashPatchResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Unique hash identifier for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string Hash { get; set; } = default!;

        /// <summary>
        /// Name of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Human-readable label for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Whether the API key is disabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Disabled { get; set; } = default!;

        /// <summary>
        /// Spending limit for the API key in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

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
        /// ISO 8601 timestamp of when the API key was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp of when the API key was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeysHashPatchResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="hash">
        /// Unique hash identifier for the API key
        /// </param>
        /// <param name="name">
        /// Name of the API key
        /// </param>
        /// <param name="label">
        /// Human-readable label for the API key
        /// </param>
        /// <param name="disabled">
        /// Whether the API key is disabled
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include external BYOK usage in the credit limit
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
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the API key was created
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
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the API key was last updated
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration
        /// </param>
        /// <param name="creatorUserId">
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.
        /// </param>
        public KeysHashPatchResponsesContentApplicationJsonSchemaData(
            string hash,
            string name,
            string label,
            bool disabled,
            bool includeByokInLimit,
            double usage,
            double usageDaily,
            double usageWeekly,
            double usageMonthly,
            double byokUsage,
            double byokUsageDaily,
            double byokUsageWeekly,
            double byokUsageMonthly,
            string createdAt,
            double? limit,
            double? limitRemaining,
            string? limitReset,
            string? updatedAt,
            global::System.DateTime? expiresAt,
            string? creatorUserId)
        {
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Disabled = disabled;
            this.Limit = limit;
            this.LimitRemaining = limitRemaining;
            this.LimitReset = limitReset;
            this.IncludeByokInLimit = includeByokInLimit;
            this.Usage = usage;
            this.UsageDaily = usageDaily;
            this.UsageWeekly = usageWeekly;
            this.UsageMonthly = usageMonthly;
            this.ByokUsage = byokUsage;
            this.ByokUsageDaily = byokUsageDaily;
            this.ByokUsageWeekly = byokUsageWeekly;
            this.ByokUsageMonthly = byokUsageMonthly;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt;
            this.ExpiresAt = expiresAt;
            this.CreatorUserId = creatorUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeysHashPatchResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public KeysHashPatchResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}