//HintName: G.Models.McpIntegrationListItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.McpIntegrationListItemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_type")]
        public global::G.McpIntegrationListItemAuthType? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.McpIntegrationListItemTransport? Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configurations")]
        public object? Configurations { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces_count")]
        public double? WorkspacesCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="ownerId"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
        /// <param name="configurations"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="slug"></param>
        /// <param name="workspaceId"></param>
        /// <param name="description"></param>
        /// <param name="workspacesCount"></param>
        public McpIntegrationListItem(
            global::System.Guid? id,
            string? name,
            string? ownerId,
            string? status,
            global::G.McpIntegrationListItemType? type,
            string? url,
            global::G.McpIntegrationListItemAuthType? authType,
            global::G.McpIntegrationListItemTransport? transport,
            object? configurations,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? slug,
            string? workspaceId,
            string? description,
            double? workspacesCount)
        {
            this.Id = id;
            this.Name = name;
            this.OwnerId = ownerId;
            this.Status = status;
            this.Type = type;
            this.Url = url;
            this.AuthType = authType;
            this.Transport = transport;
            this.Configurations = configurations;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Slug = slug;
            this.WorkspaceId = workspaceId;
            this.Description = description;
            this.WorkspacesCount = workspacesCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationListItem" /> class.
        /// </summary>
        public McpIntegrationListItem()
        {
        }
    }
}