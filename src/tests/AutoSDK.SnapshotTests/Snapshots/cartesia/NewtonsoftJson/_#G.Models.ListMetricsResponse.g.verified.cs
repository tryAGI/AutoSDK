//HintName: G.Models.ListMetricsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMetricsResponse
    {
        /// <summary>
        /// List of metrics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Metric> Data { get; set; } = default!;

        /// <summary>
        /// Whether there are more metrics to fetch (using `starting_after=id`, where id is the ID of the last Metric in the current response).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The ID of the last Metric in the current response as a cursor for the next page of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetricsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of metrics.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more metrics to fetch (using `starting_after=id`, where id is the ID of the last Metric in the current response).
        /// </param>
        /// <param name="nextPage">
        /// The ID of the last Metric in the current response as a cursor for the next page of results.
        /// </param>
        public ListMetricsResponse(
            global::System.Collections.Generic.IList<global::G.Metric> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetricsResponse" /> class.
        /// </summary>
        public ListMetricsResponse()
        {
        }
    }
}