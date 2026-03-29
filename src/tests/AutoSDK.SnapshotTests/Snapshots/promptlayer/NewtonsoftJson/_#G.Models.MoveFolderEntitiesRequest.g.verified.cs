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
        [global::Newtonsoft.Json.JsonProperty("entities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EntityReference> Entities { get; set; } = default!;

        /// <summary>
        /// The ID of the destination folder. If null or not provided, entities are moved to the workspace root.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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