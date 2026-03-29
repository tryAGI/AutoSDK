//HintName: G.Models.HnswGlobalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HnswGlobalConfig
    {
        /// <summary>
        /// Enable HNSW healing if the ratio of missing points is no more than this value. To disable healing completely, set this value to `0.0`.<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("healing_threshold")]
        public double? HealingThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswGlobalConfig" /> class.
        /// </summary>
        /// <param name="healingThreshold">
        /// Enable HNSW healing if the ratio of missing points is no more than this value. To disable healing completely, set this value to `0.0`.<br/>
        /// Default Value: 0.3F
        /// </param>
        public HnswGlobalConfig(
            double? healingThreshold)
        {
            this.HealingThreshold = healingThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HnswGlobalConfig" /> class.
        /// </summary>
        public HnswGlobalConfig()
        {
        }
    }
}