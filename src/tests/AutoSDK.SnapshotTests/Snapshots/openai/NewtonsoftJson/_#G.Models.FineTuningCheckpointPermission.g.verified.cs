//HintName: G.Models.FineTuningCheckpointPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `checkpoint.permission` object represents a permission for a fine-tuned model checkpoint.
    /// </summary>
    public sealed partial class FineTuningCheckpointPermission
    {
        /// <summary>
        /// The permission identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the permission was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The project identifier that the permission is for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "checkpoint.permission".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FineTuningCheckpointPermissionObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningCheckpointPermission" /> class.
        /// </summary>
        /// <param name="id">
        /// The permission identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the permission was created.
        /// </param>
        /// <param name="projectId">
        /// The project identifier that the permission is for.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "checkpoint.permission".
        /// </param>
        public FineTuningCheckpointPermission(
            string id,
            global::System.DateTimeOffset createdAt,
            string projectId,
            global::G.FineTuningCheckpointPermissionObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningCheckpointPermission" /> class.
        /// </summary>
        public FineTuningCheckpointPermission()
        {
        }
    }
}