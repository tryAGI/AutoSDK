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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Traffic percentage to deploy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traffic_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double TrafficPercentage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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