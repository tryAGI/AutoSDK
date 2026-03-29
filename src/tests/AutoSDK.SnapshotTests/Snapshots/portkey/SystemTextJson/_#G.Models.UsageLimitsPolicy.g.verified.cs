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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Array of conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::G.Condition>? Conditions { get; set; }

        /// <summary>
        /// Array of group by fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::G.GroupBy>? GroupBy { get; set; }

        /// <summary>
        /// Policy type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageLimitsPolicyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UsageLimitsPolicyType Type { get; set; }

        /// <summary>
        /// Maximum usage allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// Alert threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_threshold")]
        public double? AlertThreshold { get; set; }

        /// <summary>
        /// Reset period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodic_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageLimitsPolicyPeriodicResetJsonConverter))]
        public global::G.UsageLimitsPolicyPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Policy status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageLimitsPolicyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UsageLimitsPolicyStatus Status { get; set; }

        /// <summary>
        /// Workspace UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Organization UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrganisationId { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdatedAt { get; set; }

        /// <summary>
        /// Map of value keys to usage information (only included when include_usage=true)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_key_usage_map")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ValueKeyUsage>? ValueKeyUsageMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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