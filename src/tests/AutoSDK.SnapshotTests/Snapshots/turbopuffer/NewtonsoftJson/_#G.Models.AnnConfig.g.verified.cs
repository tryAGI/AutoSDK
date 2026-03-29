//HintName: G.Models.AnnConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for ANN (Approximate Nearest Neighbor) indexing.
    /// </summary>
    public sealed partial class AnnConfig
    {
        /// <summary>
        /// A function used to calculate vector similarity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance_metric")]
        public global::G.DistanceMetric? DistanceMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnConfig" /> class.
        /// </summary>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
        public AnnConfig(
            global::G.DistanceMetric? distanceMetric)
        {
            this.DistanceMetric = distanceMetric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnConfig" /> class.
        /// </summary>
        public AnnConfig()
        {
        }
    }
}