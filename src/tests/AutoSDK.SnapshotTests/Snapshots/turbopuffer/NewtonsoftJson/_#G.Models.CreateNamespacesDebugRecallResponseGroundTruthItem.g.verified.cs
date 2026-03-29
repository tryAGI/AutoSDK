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
        [global::Newtonsoft.Json.JsonProperty("query_vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> QueryVector { get; set; } = default!;

        /// <summary>
        /// The true nearest neighbors with their distances and vectors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nearest_neighbors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Row> NearestNeighbors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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