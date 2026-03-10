//HintName: G.Models.AgentPromptChangeToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPromptChangeToolConfig
    {
        /// <summary>
        /// Default Value: agent_prompt_change
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPromptChangeToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: agent_prompt_change
        /// </param>
        public AgentPromptChangeToolConfig(
            string? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPromptChangeToolConfig" /> class.
        /// </summary>
        public AgentPromptChangeToolConfig()
        {
        }
    }
}