//HintName: G.Models.SearchPool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains details about the index you queried.
    /// </summary>
    public sealed partial class SearchPool
    {
        /// <summary>
        /// The number of videos in the index you queried.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The total duration of the videos.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration")]
        public double? TotalDuration { get; set; }

        /// <summary>
        /// The unique identifier of the index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_id")]
        public string? IndexId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPool" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of videos in the index you queried.
        /// </param>
        /// <param name="totalDuration">
        /// The total duration of the videos.
        /// </param>
        /// <param name="indexId">
        /// The unique identifier of the index.
        /// </param>
        public SearchPool(
            int? totalCount,
            double? totalDuration,
            string? indexId)
        {
            this.TotalCount = totalCount;
            this.TotalDuration = totalDuration;
            this.IndexId = indexId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPool" /> class.
        /// </summary>
        public SearchPool()
        {
        }
    }
}