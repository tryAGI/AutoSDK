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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_attribute_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FilterAttributeStat> FilterAttributeStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilterAttributeStatsResponse" /> class.
        /// </summary>
        /// <param name="filterAttributeStats">
        /// Array of statistics, one per requested or available filter attribute. Each statistic contains value distributions and optional numeric statistics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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