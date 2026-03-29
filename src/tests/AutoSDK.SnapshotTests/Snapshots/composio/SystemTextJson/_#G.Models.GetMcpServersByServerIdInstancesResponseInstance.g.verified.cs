//HintName: G.Models.GetMcpServersByServerIdInstancesResponseInstance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP server instance details
    /// </summary>
    public sealed partial class GetMcpServersByServerIdInstancesResponseInstance
    {
        /// <summary>
        /// UUID of the instance record<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The instance identifier (same as the user_id)<br/>
        /// Example: user_123456
        /// </summary>
        /// <example>user_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceId { get; set; }

        /// <summary>
        /// UUID of the parent MCP server<br/>
        /// Example: 660e8400-e29b-41d4-a716-446655440001
        /// </summary>
        /// <example>660e8400-e29b-41d4-a716-446655440001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// Date and time when this instance was created<br/>
        /// Example: 2023-06-10T09:15:00.000Z
        /// </summary>
        /// <example>2023-06-10T09:15:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Date and time when this instance was last modified<br/>
        /// Example: 2023-06-15T14:30:00.000Z
        /// </summary>
        /// <example>2023-06-15T14:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpServersByServerIdInstancesResponseInstance" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID of the instance record<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="instanceId">
        /// The instance identifier (same as the user_id)<br/>
        /// Example: user_123456
        /// </param>
        /// <param name="mcpServerId">
        /// UUID of the parent MCP server<br/>
        /// Example: 660e8400-e29b-41d4-a716-446655440001
        /// </param>
        /// <param name="createdAt">
        /// Date and time when this instance was created<br/>
        /// Example: 2023-06-10T09:15:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when this instance was last modified<br/>
        /// Example: 2023-06-15T14:30:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMcpServersByServerIdInstancesResponseInstance(
            string id,
            string instanceId,
            string mcpServerId,
            string createdAt,
            string updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InstanceId = instanceId ?? throw new global::System.ArgumentNullException(nameof(instanceId));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpServersByServerIdInstancesResponseInstance" /> class.
        /// </summary>
        public GetMcpServersByServerIdInstancesResponseInstance()
        {
        }
    }
}