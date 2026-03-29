//HintName: G.Models.DirectorySyncJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a directory sync job.
    /// </summary>
    public sealed partial class DirectorySyncJobResponse
    {
        /// <summary>
        /// Unique identifier for the directory sync job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Directory being processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryId { get; set; }

        /// <summary>
        /// Status of the listing process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listing_status_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ListingStatusDetails ListingStatusDetails { get; set; }

        /// <summary>
        /// Status of the diffing process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffing_status_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DiffingStatusDetails DiffingStatusDetails { get; set; }

        /// <summary>
        /// Status of the apply process (file updates and deletions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_status_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApplyStatusDetails ApplyStatusDetails { get; set; }

        /// <summary>
        /// Timestamp when job processing started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when job completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySyncJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the directory sync job
        /// </param>
        /// <param name="projectId">
        /// Project this job belongs to
        /// </param>
        /// <param name="directoryId">
        /// Directory being processed
        /// </param>
        /// <param name="listingStatusDetails">
        /// Status of the listing process
        /// </param>
        /// <param name="diffingStatusDetails">
        /// Status of the diffing process
        /// </param>
        /// <param name="applyStatusDetails">
        /// Status of the apply process (file updates and deletions)
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="startedAt">
        /// Timestamp when job processing started
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when job completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectorySyncJobResponse(
            string id,
            string projectId,
            string directoryId,
            global::G.ListingStatusDetails listingStatusDetails,
            global::G.DiffingStatusDetails diffingStatusDetails,
            global::G.ApplyStatusDetails applyStatusDetails,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.DirectoryId = directoryId ?? throw new global::System.ArgumentNullException(nameof(directoryId));
            this.ListingStatusDetails = listingStatusDetails ?? throw new global::System.ArgumentNullException(nameof(listingStatusDetails));
            this.DiffingStatusDetails = diffingStatusDetails ?? throw new global::System.ArgumentNullException(nameof(diffingStatusDetails));
            this.ApplyStatusDetails = applyStatusDetails ?? throw new global::System.ArgumentNullException(nameof(applyStatusDetails));
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySyncJobResponse" /> class.
        /// </summary>
        public DirectorySyncJobResponse()
        {
        }
    }
}