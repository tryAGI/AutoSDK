//HintName: G.Models.CohortAgent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cohort_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CohortId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_versions")]
        public global::System.Collections.Generic.IList<double>? AgentVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAgent" /> class.
        /// </summary>
        /// <param name="cohortId"></param>
        /// <param name="agentId"></param>
        /// <param name="agentVersions"></param>
        public CohortAgent(
            string cohortId,
            string agentId,
            global::System.Collections.Generic.IList<double>? agentVersions)
        {
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentVersions = agentVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAgent" /> class.
        /// </summary>
        public CohortAgent()
        {
        }
    }
}