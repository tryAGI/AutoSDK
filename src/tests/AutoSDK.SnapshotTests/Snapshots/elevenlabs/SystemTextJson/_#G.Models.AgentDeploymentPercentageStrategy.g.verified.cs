//HintName: G.Models.AgentDeploymentPercentageStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDeploymentPercentageStrategy
    {
        /// <summary>
        /// Default Value: percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Traffic percentage to deploy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TrafficPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentPercentageStrategy" /> class.
        /// </summary>
        /// <param name="trafficPercentage">
        /// Traffic percentage to deploy
        /// </param>
        /// <param name="type">
        /// Default Value: percentage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDeploymentPercentageStrategy(
            double trafficPercentage,
            string? type)
        {
            this.Type = type;
            this.TrafficPercentage = trafficPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentPercentageStrategy" /> class.
        /// </summary>
        public AgentDeploymentPercentageStrategy()
        {
        }
    }
}