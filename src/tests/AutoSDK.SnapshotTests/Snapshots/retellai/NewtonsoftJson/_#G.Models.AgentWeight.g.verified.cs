//HintName: G.Models.AgentWeight.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentWeight
    {
        /// <summary>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("agent_version")]
        public int? AgentVersion { get; set; }

        /// <summary>
        /// The weight of the agent. When used in a list of agents, the total weights must add up to 1.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::Newtonsoft.Json.JsonProperty("weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWeight" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="weight">
        /// The weight of the agent. When used in a list of agents, the total weights must add up to 1.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="agentVersion">
        /// Example: 1
        /// </param>
        public AgentWeight(
            string agentId,
            double weight,
            int? agentVersion)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersion = agentVersion;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWeight" /> class.
        /// </summary>
        public AgentWeight()
        {
        }
    }
}