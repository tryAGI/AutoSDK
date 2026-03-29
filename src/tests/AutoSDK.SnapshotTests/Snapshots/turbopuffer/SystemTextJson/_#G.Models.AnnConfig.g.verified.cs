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
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DistanceMetricJsonConverter))]
        public global::G.DistanceMetric? DistanceMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnConfig" /> class.
        /// </summary>
        /// <param name="distanceMetric">
        /// A function used to calculate vector similarity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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