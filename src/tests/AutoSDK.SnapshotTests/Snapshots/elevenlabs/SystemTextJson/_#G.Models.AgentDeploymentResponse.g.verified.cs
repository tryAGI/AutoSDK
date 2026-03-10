//HintName: G.Models.AgentDeploymentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDeploymentResponse
    {
        /// <summary>
        /// Map of branch IDs to traffic percentages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_percentage_branch_id_map")]
        public global::System.Collections.Generic.Dictionary<string, double>? TrafficPercentageBranchIdMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentResponse" /> class.
        /// </summary>
        /// <param name="trafficPercentageBranchIdMap">
        /// Map of branch IDs to traffic percentages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDeploymentResponse(
            global::System.Collections.Generic.Dictionary<string, double>? trafficPercentageBranchIdMap)
        {
            this.TrafficPercentageBranchIdMap = trafficPercentageBranchIdMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentResponse" /> class.
        /// </summary>
        public AgentDeploymentResponse()
        {
        }
    }
}