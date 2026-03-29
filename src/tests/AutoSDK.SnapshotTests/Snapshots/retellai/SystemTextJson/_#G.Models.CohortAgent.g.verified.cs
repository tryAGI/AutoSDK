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
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CohortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_versions")]
        public global::System.Collections.Generic.IList<double>? AgentVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAgent" /> class.
        /// </summary>
        /// <param name="cohortId"></param>
        /// <param name="agentId"></param>
        /// <param name="agentVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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