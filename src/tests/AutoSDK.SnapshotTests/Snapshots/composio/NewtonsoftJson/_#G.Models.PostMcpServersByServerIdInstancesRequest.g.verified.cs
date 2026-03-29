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
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersByServerIdInstancesRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID (entity ID) that will be used as both the user identifier and instance ID<br/>
        /// Example: user_123456
        /// </param>
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