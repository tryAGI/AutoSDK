//HintName: G.Models.CreateNamespacesDebugRecallResponseGroundTruthItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNamespacesDebugRecallResponseGroundTruthItem
    {
        /// <summary>
        /// The query vector used for this search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> QueryVector { get; set; }

        /// <summary>
        /// The true nearest neighbors with their distances and vectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nearest_neighbors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Row> NearestNeighbors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesDebugRecallResponseGroundTruthItem" /> class.
        /// </summary>
        /// <param name="queryVector">
        /// The query vector used for this search.
        /// </param>
        /// <param name="nearestNeighbors">
        /// The true nearest neighbors with their distances and vectors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNamespacesDebugRecallResponseGroundTruthItem(
            global::System.Collections.Generic.IList<double> queryVector,
            global::System.Collections.Generic.IList<global::G.Row> nearestNeighbors)
        {
            this.QueryVector = queryVector ?? throw new global::System.ArgumentNullException(nameof(queryVector));
            this.NearestNeighbors = nearestNeighbors ?? throw new global::System.ArgumentNullException(nameof(nearestNeighbors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesDebugRecallResponseGroundTruthItem" /> class.
        /// </summary>
        public CreateNamespacesDebugRecallResponseGroundTruthItem()
        {
        }
    }
}