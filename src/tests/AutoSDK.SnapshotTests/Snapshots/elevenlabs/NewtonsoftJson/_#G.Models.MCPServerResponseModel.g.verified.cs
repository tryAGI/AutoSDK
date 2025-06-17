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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MCPServerConfigOutput Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// List of agents that depend on this MCP Server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependent_agents")]
        public global::System.Collections.Generic.IList<global::G.DependentAgentsItem4>? DependentAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MCPServerMetadataResponseModel Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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