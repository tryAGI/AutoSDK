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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Clerk user ID of the assigned member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// ID of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GuardrailId { get; set; }

        /// <summary>
        /// User ID of who made the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_by")]
        public string? AssignedBy { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the assignment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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