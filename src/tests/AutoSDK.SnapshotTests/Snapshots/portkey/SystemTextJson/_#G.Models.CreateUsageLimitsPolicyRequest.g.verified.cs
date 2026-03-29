//HintName: G.Models.CreateUsageLimitsPolicyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUsageLimitsPolicyRequest
    {
        /// <summary>
        /// Policy name<br/>
        /// Example: Monthly Cost Limit
        /// </summary>
        /// <example>Monthly Cost Limit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Array of conditions that define which requests the policy applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Condition> Conditions { get; set; }

        /// <summary>
        /// Array of group by fields that define how usage is aggregated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GroupBy> GroupBy { get; set; }

        /// <summary>
        /// Policy type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateUsageLimitsPolicyRequestType Type { get; set; }

        /// <summary>
        /// Maximum usage allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditLimit { get; set; }

        /// <summary>
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_threshold")]
        public double? AlertThreshold { get; set; }

        /// <summary>
        /// Reset period. If not provided, limit is cumulative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodic_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter))]
        public global::G.CreateUsageLimitsPolicyRequestPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Workspace ID or slug. Required if not using API key authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Organization ID. Required if not using API key authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUsageLimitsPolicyRequest" /> class.
        /// </summary>
        /// <param name="conditions">
        /// Array of conditions that define which requests the policy applies to
        /// </param>
        /// <param name="groupBy">
        /// Array of group by fields that define how usage is aggregated
        /// </param>
        /// <param name="type">
        /// Policy type
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Monthly Cost Limit
        /// </param>
        /// <param name="alertThreshold">
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </param>
        /// <param name="periodicReset">
        /// Reset period. If not provided, limit is cumulative.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID or slug. Required if not using API key authentication.
        /// </param>
        /// <param name="organisationId">
        /// Organization ID. Required if not using API key authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUsageLimitsPolicyRequest(
            global::System.Collections.Generic.IList<global::G.Condition> conditions,
            global::System.Collections.Generic.IList<global::G.GroupBy> groupBy,
            global::G.CreateUsageLimitsPolicyRequestType type,
            double creditLimit,
            string? name,
            double? alertThreshold,
            global::G.CreateUsageLimitsPolicyRequestPeriodicReset? periodicReset,
            string? workspaceId,
            global::System.Guid? organisationId)
        {
            this.Name = name;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.Type = type;
            this.CreditLimit = creditLimit;
            this.AlertThreshold = alertThreshold;
            this.PeriodicReset = periodicReset;
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUsageLimitsPolicyRequest" /> class.
        /// </summary>
        public CreateUsageLimitsPolicyRequest()
        {
        }
    }
}