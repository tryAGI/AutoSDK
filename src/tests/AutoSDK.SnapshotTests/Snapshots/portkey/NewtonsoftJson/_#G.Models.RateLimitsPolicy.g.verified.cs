//HintName: G.Models.RateLimitsPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitsPolicy
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RateLimitsPolicyTypeJsonConverter))]
        public global::G.RateLimitsPolicyType Type { get; set; } = default!;

        /// <summary>
        /// Rate unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RateLimitsPolicyUnitJsonConverter))]
        public global::G.RateLimitsPolicyUnit Unit { get; set; } = default!;

        /// <summary>
        /// Rate limit value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Policy status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RateLimitsPolicyStatusJsonConverter))]
        public global::G.RateLimitsPolicyStatus Status { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsPolicy" /> class.
        /// </summary>
        /// <param name="id">
        /// Policy UUID
        /// </param>
        /// <param name="type">
        /// Policy type
        /// </param>
        /// <param name="unit">
        /// Rate unit
        /// </param>
        /// <param name="value">
        /// Rate limit value
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
        public RateLimitsPolicy(
            global::System.Guid id,
            global::G.RateLimitsPolicyType type,
            global::G.RateLimitsPolicyUnit unit,
            double value,
            global::G.RateLimitsPolicyStatus status,
            global::System.Guid workspaceId,
            global::System.Guid organisationId,
            global::System.DateTime createdAt,
            global::System.DateTime lastUpdatedAt,
            string? name,
            global::System.Collections.Generic.IList<global::G.Condition>? conditions,
            global::System.Collections.Generic.IList<global::G.GroupBy>? groupBy)
        {
            this.Id = id;
            this.Name = name;
            this.Conditions = conditions;
            this.GroupBy = groupBy;
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
            this.Status = status;
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsPolicy" /> class.
        /// </summary>
        public RateLimitsPolicy()
        {
        }
    }
}