//HintName: G.Models.UsageLimitsPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimitsPolicy
    {
        /// <summary>
        /// Policy UUID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Policy name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Array of conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions")]
        public global::System.Collections.Generic.IList<global::G.Condition>? Conditions { get; set; }

        /// <summary>
        /// Array of group by fields
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by")]
        public global::System.Collections.Generic.IList<global::G.GroupBy>? GroupBy { get; set; }

        /// <summary>
        /// Policy type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageLimitsPolicyType Type { get; set; } = default!;

        /// <summary>
        /// Maximum usage allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// Alert threshold
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_threshold")]
        public double? AlertThreshold { get; set; }

        /// <summary>
        /// Reset period
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periodic_reset")]
        public global::G.UsageLimitsPolicyPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Policy status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageLimitsPolicyStatus Status { get; set; } = default!;

        /// <summary>
        /// Workspace UUID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid WorkspaceId { get; set; } = default!;

        /// <summary>
        /// Organization UUID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganisationId { get; set; } = default!;

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdatedAt { get; set; } = default!;

        /// <summary>
        /// Map of value keys to usage information (only included when include_usage=true)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_key_usage_map")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ValueKeyUsage>? ValueKeyUsageMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicy" /> class.
        /// </summary>
        /// <param name="id">
        /// Policy UUID
        /// </param>
        /// <param name="type">
        /// Policy type
        /// </param>
        /// <param name="status">
        /// Policy status
        /// </param>
        /// <param name="workspaceId">
        /// Workspace UUID
        /// </param>
        /// <param name="organisationId">
        /// Organization UUID
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="conditions">
        /// Array of conditions
        /// </param>
        /// <param name="groupBy">
        /// Array of group by fields
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="alertThreshold">
        /// Alert threshold
        /// </param>
        /// <param name="periodicReset">
        /// Reset period
        /// </param>
        /// <param name="valueKeyUsageMap">
        /// Map of value keys to usage information (only included when include_usage=true)
        /// </param>
        public UsageLimitsPolicy(
            global::System.Guid id,
            global::G.UsageLimitsPolicyType type,
            global::G.UsageLimitsPolicyStatus status,
            global::System.Guid workspaceId,
            global::System.Guid organisationId,
            global::System.DateTime createdAt,
            global::System.DateTime lastUpdatedAt,
            string? name,
            global::System.Collections.Generic.IList<global::G.Condition>? conditions,
            global::System.Collections.Generic.IList<global::G.GroupBy>? groupBy,
            double? creditLimit,
            double? alertThreshold,
            global::G.UsageLimitsPolicyPeriodicReset? periodicReset,
            global::System.Collections.Generic.Dictionary<string, global::G.ValueKeyUsage>? valueKeyUsageMap)
        {
            this.Id = id;
            this.Name = name;
            this.Conditions = conditions;
            this.GroupBy = groupBy;
            this.Type = type;
            this.CreditLimit = creditLimit;
            this.AlertThreshold = alertThreshold;
            this.PeriodicReset = periodicReset;
            this.Status = status;
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.ValueKeyUsageMap = valueKeyUsageMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicy" /> class.
        /// </summary>
        public UsageLimitsPolicy()
        {
        }
    }
}