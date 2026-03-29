//HintName: G.Models.GuardrailSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailSummary
    {
        /// <summary>
        /// Unique identifier of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Organisation UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Workspace UUID (null for organisation-level guardrails)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Current status of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GuardrailSummaryStatusJsonConverter))]
        public global::G.GuardrailSummaryStatus? Status { get; set; }

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
        /// UUID of the user who created the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OwnerId { get; set; }

        /// <summary>
        /// UUID of the user who last updated the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public global::System.Guid? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the guardrail
        /// </param>
        /// <param name="name">
        /// Name of the guardrail
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="ownerId">
        /// UUID of the user who created the guardrail
        /// </param>
        /// <param name="organisationId">
        /// Organisation UUID
        /// </param>
        /// <param name="workspaceId">
        /// Workspace UUID (null for organisation-level guardrails)
        /// </param>
        /// <param name="status">
        /// Current status of the guardrail
        /// </param>
        /// <param name="updatedBy">
        /// UUID of the user who last updated the guardrail
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailSummary(
            string id,
            string name,
            string slug,
            global::System.DateTime createdAt,
            global::System.DateTime lastUpdatedAt,
            global::System.Guid ownerId,
            global::System.Guid? organisationId,
            global::System.Guid? workspaceId,
            global::G.GuardrailSummaryStatus? status,
            global::System.Guid? updatedBy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.OwnerId = ownerId;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSummary" /> class.
        /// </summary>
        public GuardrailSummary()
        {
        }
    }
}