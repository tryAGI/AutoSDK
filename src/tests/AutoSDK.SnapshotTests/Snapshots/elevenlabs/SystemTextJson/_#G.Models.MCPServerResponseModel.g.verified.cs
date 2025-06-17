//HintName: G.Models.MCPServerResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model representing an MCP Server configuration.
    /// </summary>
    public sealed partial class MCPServerResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MCPServerConfigOutput Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// List of agents that depend on this MCP Server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependent_agents")]
        public global::System.Collections.Generic.IList<global::G.DependentAgentsItem4>? DependentAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MCPServerMetadataResponseModel Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config"></param>
        /// <param name="accessInfo"></param>
        /// <param name="dependentAgents">
        /// List of agents that depend on this MCP Server.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerResponseModel(
            string id,
            global::G.MCPServerConfigOutput config,
            global::G.MCPServerMetadataResponseModel metadata,
            global::G.ResourceAccessInfo? accessInfo,
            global::System.Collections.Generic.IList<global::G.DependentAgentsItem4>? dependentAgents)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.AccessInfo = accessInfo;
            this.DependentAgents = dependentAgents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerResponseModel" /> class.
        /// </summary>
        public MCPServerResponseModel()
        {
        }
    }
}