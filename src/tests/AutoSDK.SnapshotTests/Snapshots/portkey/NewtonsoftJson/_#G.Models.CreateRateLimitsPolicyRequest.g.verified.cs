//HintName: G.Models.CreateRateLimitsPolicyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRateLimitsPolicyRequest
    {
        /// <summary>
        /// Policy name<br/>
        /// Example: 100 Requests per Minute
        /// </summary>
        /// <example>100 Requests per Minute</example>
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
        public global::G.CreateRateLimitsPolicyRequestType Type { get; set; } = default!;

        /// <summary>
        /// Rate unit:<br/>
        /// - `rpm` - Requests/Tokens per minute<br/>
        /// - `rph` - Requests/Tokens per hour<br/>
        /// - `rpd` - Requests/Tokens per day
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateRateLimitsPolicyRequestUnit Unit { get; set; } = default!;

        /// <summary>
        /// Rate limit value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateRateLimitsPolicyRequest" /> class.
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
        /// <param name="unit">
        /// Rate unit:<br/>
        /// - `rpm` - Requests/Tokens per minute<br/>
        /// - `rph` - Requests/Tokens per hour<br/>
        /// - `rpd` - Requests/Tokens per day
        /// </param>
        /// <param name="value">
        /// Rate limit value
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: 100 Requests per Minute
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID or slug. Required if not using API key authentication.
        /// </param>
        /// <param name="organisationId">
        /// Organization ID. Required if not using API key authentication.
        /// </param>
        public CreateRateLimitsPolicyRequest(
            global::System.Collections.Generic.IList<global::G.Condition> conditions,
            global::System.Collections.Generic.IList<global::G.GroupBy> groupBy,
            global::G.CreateRateLimitsPolicyRequestType type,
            global::G.CreateRateLimitsPolicyRequestUnit unit,
            double value,
            string? name,
            string? workspaceId,
            global::System.Guid? organisationId)
        {
            this.Name = name;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
            this.WorkspaceId = workspaceId;
            this.OrganisationId = organisationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRateLimitsPolicyRequest" /> class.
        /// </summary>
        public CreateRateLimitsPolicyRequest()
        {
        }
    }
}