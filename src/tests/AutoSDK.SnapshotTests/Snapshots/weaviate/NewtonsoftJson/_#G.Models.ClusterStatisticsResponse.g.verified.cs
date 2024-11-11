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
        [global::Newtonsoft.Json.JsonProperty("statistics")]
        public global::System.Collections.Generic.IList<global::G.Statistics>? Statistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("synchronized")]
        public bool? Synchronized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatisticsResponse" /> class.
        /// </summary>
        /// <param name="statistics"></param>
        /// <param name="synchronized"></param>
        public ClusterStatisticsResponse(
            global::System.Collections.Generic.IList<global::G.Statistics>? statistics,
            bool? synchronized)
        {
            this.Statistics = statistics;
            this.Synchronized = synchronized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatisticsResponse" /> class.
        /// </summary>
        public ClusterStatisticsResponse()
        {
        }
    }
}