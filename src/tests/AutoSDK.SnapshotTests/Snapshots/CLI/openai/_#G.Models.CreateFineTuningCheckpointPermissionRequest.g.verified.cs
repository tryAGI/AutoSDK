//HintName: G.Models.CreateFineTuningCheckpointPermissionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningCheckpointPermissionRequest
    {
        /// <summary>
        /// The project identifiers to grant access to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningCheckpointPermissionRequest" /> class.
        /// </summary>
        /// <param name="projectIds">
        /// The project identifiers to grant access to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFineTuningCheckpointPermissionRequest(
            global::System.Collections.Generic.IList<string> projectIds)
        {
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningCheckpointPermissionRequest" /> class.
        /// </summary>
        public CreateFineTuningCheckpointPermissionRequest()
        {
        }
    }
}