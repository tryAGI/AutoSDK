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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExtractRun> Items { get; set; }

        /// <summary>
        /// The total number of extraction runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// The number of extraction runs skipped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Skip { get; set; }

        /// <summary>
        /// The maximum number of extraction runs returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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