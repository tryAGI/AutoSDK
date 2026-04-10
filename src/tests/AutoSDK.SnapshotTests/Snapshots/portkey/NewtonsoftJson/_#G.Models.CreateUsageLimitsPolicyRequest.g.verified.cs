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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Array of conditions that define which requests the policy applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Condition> Conditions { get; set; } = default!;

        /// <summary>
        /// Array of group by fields that define how usage is aggregated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GroupBy> GroupBy { get; set; } = default!;

        /// <summary>
        /// Policy type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateUsageLimitsPolicyRequestTypeJsonConverter))]
        public global::G.CreateUsageLimitsPolicyRequestType Type { get; set; } = default!;

        /// <summary>
        /// Maximum usage allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreditLimit { get; set; } = default!;

        /// <summary>
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_threshold")]
        public double? AlertThreshold { get; set; }

        /// <summary>
        /// Reset period. If not provided, limit is cumulative.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periodic_reset")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateUsageLimitsPolicyRequestPeriodicResetJsonConverter))]
        public global::G.CreateUsageLimitsPolicyRequestPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Workspace ID or slug. Required if not using API key authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Organization ID. Required if not using API key authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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