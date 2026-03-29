//HintName: G.Models.PostMcpServersByServerIdInstancesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a new MCP server instance
    /// </summary>
    public sealed partial class PostMcpServersByServerIdInstancesRequest
    {
        /// <summary>
        /// The user ID (entity ID) that will be used as both the user identifier and instance ID<br/>
        /// Example: user_123456
        /// </summary>
        /// <example>user_123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersByServerIdInstancesRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID (entity ID) that will be used as both the user identifier and instance ID<br/>
        /// Example: user_123456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostMcpServersByServerIdInstancesRequest(
            string userId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersByServerIdInstancesRequest" /> class.
        /// </summary>
        public PostMcpServersByServerIdInstancesRequest()
        {
        }
    }
}