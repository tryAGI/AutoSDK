//HintName: G.Models.DeleteFolderEntitiesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFolderEntitiesRequest
    {
        /// <summary>
        /// List of entities to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EntityReference> Entities { get; set; }

        /// <summary>
        /// When true, recursively deletes all contents of any folders in the entities list. When false, attempting to delete a non-empty folder returns an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascade")]
        public bool? Cascade { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderEntitiesRequest" /> class.
        /// </summary>
        /// <param name="entities">
        /// List of entities to delete.
        /// </param>
        /// <param name="cascade">
        /// When true, recursively deletes all contents of any folders in the entities list. When false, attempting to delete a non-empty folder returns an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFolderEntitiesRequest(
            global::System.Collections.Generic.IList<global::G.EntityReference> entities,
            bool? cascade,
            int? workspaceId)
        {
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.Cascade = cascade;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderEntitiesRequest" /> class.
        /// </summary>
        public DeleteFolderEntitiesRequest()
        {
        }
    }
}