//HintName: G.Models.ListMetricResultsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMetricResultsResponse
    {
        /// <summary>
        /// List of metric results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MetricResult> Data { get; set; }

        /// <summary>
        /// Whether there are more metric results to fetch (using `starting_after=id`, where id is the ID of the last MetricResult in the current response).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The cursor for the next page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetricResultsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of metric results.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more metric results to fetch (using `starting_after=id`, where id is the ID of the last MetricResult in the current response).
        /// </param>
        /// <param name="nextPage">
        /// The cursor for the next page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMetricResultsResponse(
            global::System.Collections.Generic.IList<global::G.MetricResult> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetricResultsResponse" /> class.
        /// </summary>
        public ListMetricResultsResponse()
        {
        }
    }
}