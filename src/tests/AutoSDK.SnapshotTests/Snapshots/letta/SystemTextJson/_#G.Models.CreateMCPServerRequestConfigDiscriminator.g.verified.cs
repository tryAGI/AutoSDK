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
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter))]
        public global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType? McpServerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMCPServerRequestConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="mcpServerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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