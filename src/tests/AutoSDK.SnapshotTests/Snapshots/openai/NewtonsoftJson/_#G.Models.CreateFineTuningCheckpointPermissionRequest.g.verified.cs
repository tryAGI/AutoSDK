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
        [global::Newtonsoft.Json.JsonProperty("project_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ProjectIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningCheckpointPermissionRequest" /> class.
        /// </summary>
        /// <param name="projectIds">
        /// The project identifiers to grant access to.
        /// </param>
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