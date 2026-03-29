//HintName: G.Models.CreateDatasetGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetGroupRequest
    {
        /// <summary>
        /// Name of the dataset group. Must be unique within the workspace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional: ID of the workspace where the dataset group will be created. If not provided, uses the workspace associated with your API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the dataset group. Must be unique within the workspace.
        /// </param>
        /// <param name="workspaceId">
        /// Optional: ID of the workspace where the dataset group will be created. If not provided, uses the workspace associated with your API key.
        /// </param>
        public CreateDatasetGroupRequest(
            string name,
            int? workspaceId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupRequest" /> class.
        /// </summary>
        public CreateDatasetGroupRequest()
        {
        }
    }
}