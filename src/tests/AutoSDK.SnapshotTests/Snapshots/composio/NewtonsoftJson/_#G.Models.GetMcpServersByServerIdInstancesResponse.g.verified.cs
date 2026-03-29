//HintName: G.Models.GetMcpServersByServerIdInstancesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated list of instances for an MCP server
    /// </summary>
    public sealed partial class GetMcpServersByServerIdInstancesResponse
    {
        /// <summary>
        /// List of instance objects associated with this MCP server for the current page<br/>
        /// Example: [{"id":"550e8400-e29b-41d4-a716-446655440000","instance_id":"user_123456","mcp_server_id":"660e8400-e29b-41d4-a716-446655440001","created_at":"2023-06-10T09:15:00.000Z","updated_at":"2023-06-15T14:30:00.000Z"}]
        /// </summary>
        /// <example>[{"id":"550e8400-e29b-41d4-a716-446655440000","instance_id":"user_123456","mcp_server_id":"660e8400-e29b-41d4-a716-446655440001","created_at":"2023-06-10T09:15:00.000Z","updated_at":"2023-06-15T14:30:00.000Z"}]</example>
        [global::Newtonsoft.Json.JsonProperty("instances", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetMcpServersByServerIdInstancesResponseInstance> Instances { get; set; } = default!;

        /// <summary>
        /// UUID of the MCP server<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("server_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerId { get; set; } = default!;

        /// <summary>
        /// Name of the MCP server<br/>
        /// Example: Production GitHub Integration
        /// </summary>
        /// <example>Production GitHub Integration</example>
        [global::Newtonsoft.Json.JsonProperty("server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerName { get; set; } = default!;

        /// <summary>
        /// Total number of pages in the paginated response<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("total_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalPages { get; set; } = default!;

        /// <summary>
        /// Current page number being returned<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("current_page", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpServersByServerIdInstancesResponse" /> class.
        /// </summary>
        /// <param name="instances">
        /// List of instance objects associated with this MCP server for the current page<br/>
        /// Example: [{"id":"550e8400-e29b-41d4-a716-446655440000","instance_id":"user_123456","mcp_server_id":"660e8400-e29b-41d4-a716-446655440001","created_at":"2023-06-10T09:15:00.000Z","updated_at":"2023-06-15T14:30:00.000Z"}]
        /// </param>
        /// <param name="serverId">
        /// UUID of the MCP server<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="serverName">
        /// Name of the MCP server<br/>
        /// Example: Production GitHub Integration
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages in the paginated response<br/>
        /// Example: 3
        /// </param>
        /// <param name="currentPage">
        /// Current page number being returned<br/>
        /// Example: 1
        /// </param>
        public GetMcpServersByServerIdInstancesResponse(
            global::System.Collections.Generic.IList<global::G.GetMcpServersByServerIdInstancesResponseInstance> instances,
            string serverId,
            string serverName,
            double totalPages,
            double currentPage)
        {
            this.Instances = instances ?? throw new global::System.ArgumentNullException(nameof(instances));
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpServersByServerIdInstancesResponse" /> class.
        /// </summary>
        public GetMcpServersByServerIdInstancesResponse()
        {
        }
    }
}