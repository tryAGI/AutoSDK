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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationWorkspacesWorkspace" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace ID or slug
        /// </param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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