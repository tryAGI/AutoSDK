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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Project this job belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Directory being processed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directory_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DirectoryId { get; set; } = default!;

        /// <summary>
        /// Status of the listing process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("listing_status_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListingStatusDetails ListingStatusDetails { get; set; } = default!;

        /// <summary>
        /// Status of the diffing process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diffing_status_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DiffingStatusDetails DiffingStatusDetails { get; set; } = default!;

        /// <summary>
        /// Status of the apply process (file updates and deletions)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_status_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApplyStatusDetails ApplyStatusDetails { get; set; } = default!;

        /// <summary>
        /// Timestamp when job processing started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when job completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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