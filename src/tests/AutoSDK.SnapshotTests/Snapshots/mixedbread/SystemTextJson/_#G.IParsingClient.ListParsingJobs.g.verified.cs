//HintName: G.IParsingClient.ListParsingJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// List parsing jobs<br/>
        /// List parsing jobs with pagination.<br/>
        /// Args:<br/>
        ///     limit: The number of items to return.<br/>
        ///     offset: The number of items to skip.<br/>
        /// Returns:<br/>
        ///     List of parsing jobs with pagination.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="statuses">
        /// Status to filter by
        /// </param>
        /// <param name="q">
        /// Search query to filter by
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParsingJobListResponse> ListParsingJobsAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::System.Collections.Generic.IList<global::G.ParsingJobStatus>? statuses = default,
            string? q = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}