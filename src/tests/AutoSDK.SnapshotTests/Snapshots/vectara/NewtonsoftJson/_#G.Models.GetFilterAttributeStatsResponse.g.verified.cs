//HintName: G.Models.GetFilterAttributeStatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing statistics and value distributions for filter attributes in a corpus, providing insights into metadata distributions and values.
    /// </summary>
    public sealed partial class GetFilterAttributeStatsResponse
    {
        /// <summary>
        /// Array of statistics, one per requested or available filter attribute. Each statistic contains value distributions and optional numeric statistics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_attribute_stats", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FilterAttributeStat> FilterAttributeStats { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilterAttributeStatsResponse" /> class.
        /// </summary>
        /// <param name="filterAttributeStats">
        /// Array of statistics, one per requested or available filter attribute. Each statistic contains value distributions and optional numeric statistics.
        /// </param>
        public GetFilterAttributeStatsResponse(
            global::System.Collections.Generic.IList<global::G.FilterAttributeStat> filterAttributeStats)
        {
            this.FilterAttributeStats = filterAttributeStats ?? throw new global::System.ArgumentNullException(nameof(filterAttributeStats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilterAttributeStatsResponse" /> class.
        /// </summary>
        public GetFilterAttributeStatsResponse()
        {
        }
    }
}