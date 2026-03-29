//HintName: G.Models.GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// Unique identifier for the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Clerk user ID of the assigned member
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// ID of the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrail_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GuardrailId { get; set; } = default!;

        /// <summary>
        /// User ID of who made the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_by")]
        public string? AssignedBy { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the assignment was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the assignment
        /// </param>
        /// <param name="userId">
        /// Clerk user ID of the assigned member
        /// </param>
        /// <param name="organizationId">
        /// Organization ID
        /// </param>
        /// <param name="guardrailId">
        /// ID of the guardrail
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the assignment was created
        /// </param>
        /// <param name="assignedBy">
        /// User ID of who made the assignment
        /// </param>
        public GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems(
            global::System.Guid id,
            string userId,
            string organizationId,
            global::System.Guid guardrailId,
            string createdAt,
            string? assignedBy)
        {
            this.Id = id;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.GuardrailId = guardrailId;
            this.AssignedBy = assignedBy;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public GuardrailsIdAssignmentsMembersGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}