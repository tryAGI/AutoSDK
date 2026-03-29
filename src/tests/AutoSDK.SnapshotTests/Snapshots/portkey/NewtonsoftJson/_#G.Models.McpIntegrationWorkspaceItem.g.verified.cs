//HintName: G.Models.McpIntegrationWorkspaceItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationWorkspaceItem
    {
        /// <summary>
        /// Workspace ID or slug (slug when using workspace API key)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspaceItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace ID or slug (slug when using workspace API key)
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        public McpIntegrationWorkspaceItem(
            string? id,
            bool? enabled,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspaceItem" /> class.
        /// </summary>
        public McpIntegrationWorkspaceItem()
        {
        }
    }
}