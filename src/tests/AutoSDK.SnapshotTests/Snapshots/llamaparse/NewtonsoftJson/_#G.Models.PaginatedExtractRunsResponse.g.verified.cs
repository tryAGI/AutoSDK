//HintName: G.Models.PaginatedExtractRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for paginated extraction runs response.
    /// </summary>
    public sealed partial class PaginatedExtractRunsResponse
    {
        /// <summary>
        /// The list of extraction runs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtractRun> Items { get; set; } = default!;

        /// <summary>
        /// The total number of extraction runs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// The number of extraction runs skipped
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip", Required = global::Newtonsoft.Json.Required.Always)]
        public int Skip { get; set; } = default!;

        /// <summary>
        /// The maximum number of extraction runs returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedExtractRunsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// The list of extraction runs
        /// </param>
        /// <param name="total">
        /// The total number of extraction runs
        /// </param>
        /// <param name="skip">
        /// The number of extraction runs skipped
        /// </param>
        /// <param name="limit">
        /// The maximum number of extraction runs returned
        /// </param>
        public PaginatedExtractRunsResponse(
            global::System.Collections.Generic.IList<global::G.ExtractRun> items,
            int total,
            int skip,
            int limit)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Total = total;
            this.Skip = skip;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedExtractRunsResponse" /> class.
        /// </summary>
        public PaginatedExtractRunsResponse()
        {
        }
    }
}