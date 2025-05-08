//HintName: G.Models.AuditLogCheckpointPermissionCreatedData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to create the checkpoint permission.
    /// </summary>
    public sealed partial class AuditLogCheckpointPermissionCreatedData
    {
        /// <summary>
        /// The ID of the project that the checkpoint permission was created for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The ID of the fine-tuned model checkpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuned_model_checkpoint")]
        public string? FineTunedModelCheckpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionCreatedData" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project that the checkpoint permission was created for.
        /// </param>
        /// <param name="fineTunedModelCheckpoint">
        /// The ID of the fine-tuned model checkpoint.
        /// </param>
        public AuditLogCheckpointPermissionCreatedData(
            string? projectId,
            string? fineTunedModelCheckpoint)
        {
            this.ProjectId = projectId;
            this.FineTunedModelCheckpoint = fineTunedModelCheckpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionCreatedData" /> class.
        /// </summary>
        public AuditLogCheckpointPermissionCreatedData()
        {
        }
    }
}