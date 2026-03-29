//HintName: G.Models.UpdateMCPServerRequestConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMCPServerRequestConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter))]
        public global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType? McpServerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMCPServerRequestConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="mcpServerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMCPServerRequestConfigDiscriminator(
            global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType? mcpServerType)
        {
            this.McpServerType = mcpServerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMCPServerRequestConfigDiscriminator" /> class.
        /// </summary>
        public UpdateMCPServerRequestConfigDiscriminator()
        {
        }
    }
}