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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitsPolicyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimitsPolicyType Type { get; set; }

        /// <summary>
        /// Rate unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitsPolicyUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimitsPolicyUnit Unit { get; set; }

        /// <summary>
        /// Rate limit value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Policy status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitsPolicyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimitsPolicyStatus Status { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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