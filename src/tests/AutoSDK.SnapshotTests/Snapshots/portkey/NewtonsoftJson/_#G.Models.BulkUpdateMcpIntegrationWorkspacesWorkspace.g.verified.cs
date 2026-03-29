//HintName: G.Models.BulkUpdateMcpIntegrationWorkspacesWorkspace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpIntegrationWorkspacesWorkspace
    {
        /// <summary>
        /// Workspace ID or slug
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationWorkspacesWorkspace" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace ID or slug
        /// </param>
        /// <param name="enabled"></param>
        public BulkUpdateMcpIntegrationWorkspacesWorkspace(
            string id,
            bool enabled)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationWorkspacesWorkspace" /> class.
        /// </summary>
        public BulkUpdateMcpIntegrationWorkspacesWorkspace()
        {
        }
    }
}