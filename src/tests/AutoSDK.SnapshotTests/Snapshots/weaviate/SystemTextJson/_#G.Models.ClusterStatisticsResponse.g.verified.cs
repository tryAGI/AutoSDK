//HintName: G.Models.ClusterStatisticsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The cluster statistics of all of the Weaviate nodes
    /// </summary>
    public sealed partial class ClusterStatisticsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::System.Collections.Generic.IList<global::G.Statistics>? Statistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synchronized")]
        public bool? Synchronized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}