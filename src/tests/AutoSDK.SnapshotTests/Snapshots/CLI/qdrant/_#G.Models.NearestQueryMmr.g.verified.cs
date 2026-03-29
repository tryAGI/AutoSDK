//HintName: G.Models.NearestQueryMmr.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Perform MMR (Maximal Marginal Relevance) reranking after search, using the same vector in this query to calculate relevance.
    /// </summary>
    public sealed partial class NearestQueryMmr
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}