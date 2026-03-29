//HintName: G.Models.CreateNamespacesDebugRecallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a successful cache warm request.
    /// </summary>
    public sealed partial class CreateNamespacesDebugRecallResponse
    {
        /// <summary>
        /// The average recall of the queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_recall")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgRecall { get; set; }

        /// <summary>
        /// The average number of documents retrieved by the exhaustive searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_exhaustive_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgExhaustiveCount { get; set; }

        /// <summary>
        /// The average number of documents retrieved by the approximate nearest neighbor searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_ann_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgAnnCount { get; set; }

        /// <summary>
        /// Ground truth data including query vectors and true nearest neighbors. Only included when include_ground_truth is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public global::System.Collections.Generic.IList<global::G.CreateNamespacesDebugRecallResponseGroundTruthItem>? GroundTruth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesDebugRecallResponse" /> class.
        /// </summary>
        /// <param name="avgRecall">
        /// The average recall of the queries.
        /// </param>
        /// <param name="avgExhaustiveCount">
        /// The average number of documents retrieved by the exhaustive searches.
        /// </param>
        /// <param name="avgAnnCount">
        /// The average number of documents retrieved by the approximate nearest neighbor searches.
        /// </param>
        /// <param name="groundTruth">
        /// Ground truth data including query vectors and true nearest neighbors. Only included when include_ground_truth is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNamespacesDebugRecallResponse(
            double avgRecall,
            double avgExhaustiveCount,
            double avgAnnCount,
            global::System.Collections.Generic.IList<global::G.CreateNamespacesDebugRecallResponseGroundTruthItem>? groundTruth)
        {
            this.AvgRecall = avgRecall;
            this.AvgExhaustiveCount = avgExhaustiveCount;
            this.AvgAnnCount = avgAnnCount;
            this.GroundTruth = groundTruth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesDebugRecallResponse" /> class.
        /// </summary>
        public CreateNamespacesDebugRecallResponse()
        {
        }
    }
}