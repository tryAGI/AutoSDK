//HintName: G.Models.CreateMCPServerRequestConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMCPServerRequestConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_type")]
        public global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType? McpServerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPServerRequestConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="mcpServerType"></param>
        public CreateMCPServerRequestConfigDiscriminator(
            global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType? mcpServerType)
        {
            this.McpServerType = mcpServerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPServerRequestConfigDiscriminator" /> class.
        /// </summary>
        public CreateMCPServerRequestConfigDiscriminator()
        {
        }
    }
}