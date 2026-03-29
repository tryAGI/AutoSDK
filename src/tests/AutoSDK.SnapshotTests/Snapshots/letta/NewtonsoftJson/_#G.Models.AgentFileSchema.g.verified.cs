//HintName: G.Models.AgentFileSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for serialized agent file that can be exported to JSON and imported into agent server.
    /// </summary>
    public sealed partial class AgentFileSchema
    {
        /// <summary>
        /// List of agents in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasAgentFileAgentSchema> Agents { get; set; } = default!;

        /// <summary>
        /// List of groups in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groups", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GroupSchema> Groups { get; set; } = default!;

        /// <summary>
        /// List of memory blocks in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blocks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BlockSchema> Blocks { get; set; } = default!;

        /// <summary>
        /// List of files in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FileSchema> Files { get; set; } = default!;

        /// <summary>
        /// List of sources in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SourceSchema> Sources { get; set; } = default!;

        /// <summary>
        /// List of tools in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasAgentFileToolSchema> Tools { get; set; } = default!;

        /// <summary>
        /// List of MCP servers in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_servers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MCPServerSchema> McpServers { get; set; } = default!;

        /// <summary>
        /// List of skills in this agent file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skills")]
        public global::System.Collections.Generic.IList<global::G.SkillSchema>? Skills { get; set; }

        /// <summary>
        /// Metadata for this agent file, including revision_id and other export information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFileSchema" /> class.
        /// </summary>
        /// <param name="agents">
        /// List of agents in this agent file
        /// </param>
        /// <param name="groups">
        /// List of groups in this agent file
        /// </param>
        /// <param name="blocks">
        /// List of memory blocks in this agent file
        /// </param>
        /// <param name="files">
        /// List of files in this agent file
        /// </param>
        /// <param name="sources">
        /// List of sources in this agent file
        /// </param>
        /// <param name="tools">
        /// List of tools in this agent file
        /// </param>
        /// <param name="mcpServers">
        /// List of MCP servers in this agent file
        /// </param>
        /// <param name="skills">
        /// List of skills in this agent file
        /// </param>
        /// <param name="metadata">
        /// Metadata for this agent file, including revision_id and other export information.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
        public AgentFileSchema(
            global::System.Collections.Generic.IList<global::G.LettaSchemasAgentFileAgentSchema> agents,
            global::System.Collections.Generic.IList<global::G.GroupSchema> groups,
            global::System.Collections.Generic.IList<global::G.BlockSchema> blocks,
            global::System.Collections.Generic.IList<global::G.FileSchema> files,
            global::System.Collections.Generic.IList<global::G.SourceSchema> sources,
            global::System.Collections.Generic.IList<global::G.LettaSchemasAgentFileToolSchema> tools,
            global::System.Collections.Generic.IList<global::G.MCPServerSchema> mcpServers,
            global::System.Collections.Generic.IList<global::G.SkillSchema>? skills,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? createdAt)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.McpServers = mcpServers ?? throw new global::System.ArgumentNullException(nameof(mcpServers));
            this.Skills = skills;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFileSchema" /> class.
        /// </summary>
        public AgentFileSchema()
        {
        }
    }
}