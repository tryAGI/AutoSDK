//HintName: G.Models.ListWorkflowsResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWorkflowsResponseItem
    {
        /// <summary>
        /// Unique identifier for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// ID of the workspace this workflow belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// ID of the user who created this workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the workflow is deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeleted { get; set; }

        /// <summary>
        /// The latest version number of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_number")]
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Array of release label names associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the workflow
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this workflow belongs to
        /// </param>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="isDeleted">
        /// Whether the workflow is deleted
        /// </param>
        /// <param name="releaseLabels">
        /// Array of release label names associated with the workflow
        /// </param>
        /// <param name="userId">
        /// ID of the user who created this workflow
        /// </param>
        /// <param name="latestVersionNumber">
        /// The latest version number of the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkflowsResponseItem(
            int id,
            int workspaceId,
            string name,
            bool isDeleted,
            global::System.Collections.Generic.IList<string> releaseLabels,
            int? userId,
            int? latestVersionNumber)
        {
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.UserId = userId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsDeleted = isDeleted;
            this.LatestVersionNumber = latestVersionNumber;
            this.ReleaseLabels = releaseLabels ?? throw new global::System.ArgumentNullException(nameof(releaseLabels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponseItem" /> class.
        /// </summary>
        public ListWorkflowsResponseItem()
        {
        }
    }
}