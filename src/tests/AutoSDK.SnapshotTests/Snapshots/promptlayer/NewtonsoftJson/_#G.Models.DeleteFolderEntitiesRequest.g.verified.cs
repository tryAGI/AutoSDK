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
        [global::Newtonsoft.Json.JsonProperty("entities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EntityReference> Entities { get; set; } = default!;

        /// <summary>
        /// When true, recursively deletes all contents of any folders in the entities list. When false, attempting to delete a non-empty folder returns an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cascade")]
        public bool? Cascade { get; set; }

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