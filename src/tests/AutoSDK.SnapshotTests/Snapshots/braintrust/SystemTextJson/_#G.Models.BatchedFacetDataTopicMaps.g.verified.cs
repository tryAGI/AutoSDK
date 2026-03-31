//HintName: G.Models.BatchedFacetDataTopicMaps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Topic maps that depend on facets in this batch, keyed by source facet name. Each source facet can have multiple topic maps.
    /// </summary>
    public sealed partial class BatchedFacetDataTopicMaps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}