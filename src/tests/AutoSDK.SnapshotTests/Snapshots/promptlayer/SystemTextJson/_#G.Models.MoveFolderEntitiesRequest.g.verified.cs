//HintName: G.Models.MoveFolderEntitiesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveFolderEntitiesRequest
    {
        /// <summary>
        /// List of entities to move.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EntityReference> Entities { get; set; }

        /// <summary>
        /// The ID of the destination folder. If null or not provided, entities are moved to the workspace root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

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
        /// Initializes a new instance of the <see cref="MoveFolderEntitiesRequest" /> class.
        /// </summary>
        /// <param name="entities">
        /// List of entities to move.
        /// </param>
        /// <param name="folderId">
        /// The ID of the destination folder. If null or not provided, entities are moved to the workspace root.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveFolderEntitiesRequest(
            global::System.Collections.Generic.IList<global::G.EntityReference> entities,
            int? folderId,
            int? workspaceId)
        {
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.FolderId = folderId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFolderEntitiesRequest" /> class.
        /// </summary>
        public MoveFolderEntitiesRequest()
        {
        }
    }
}